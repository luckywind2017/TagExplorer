using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.CodeDom.Compiler;
using System.CodeDom;
using System.Text.RegularExpressions;
//using ctrl = System.Windows.Controls;
//using Microsoft.DirectX.AudioVideoPlayback;


namespace TagExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Code Shortcuts:
        //#BGWORK : BackgroundWork related


        private void Form1_Load(object sender, EventArgs e)
        {
            //INITIALIZATION
            this.Enabled = false;

            Globals.tags = new List<Tag>();
            Globals.folders = new List<Folder>();
            Globals.fileTags = new List<FileTags>();
            Globals.files = new List<FileTags>();
            Globals.filterTags = new List<string>();

            Globals.isResetTags = false;
            Globals.isChangeByClick = true;
            Globals.folderChanged = true;
            Globals.isFilterMode = true; 
            Globals.isMultiActive = false;
            Globals.warnings = new List<string>();

            Globals.lastFileTags = new Stack<FileTags>();

            Globals.draggedFiles = new DataObject();

            //LOADS JSON FILES
            if (File.Exists(Globals.jFolderPath))
            {
                Globals.folders = JsonConvert.DeserializeObject<List<Folder>>(File.ReadAllText(Globals.jFolderPath));
            }
            if (File.Exists(Globals.jTagsPath))
            {
                Globals.tags = JsonConvert.DeserializeObject<List<Tag>>(File.ReadAllText(Globals.jTagsPath));
            }
            if (File.Exists(Globals.jFilePath))
            {
                Globals.fileTags = JsonConvert.DeserializeObject<List<FileTags>>(File.ReadAllText(Globals.jFilePath));

                Globals.files.Clear();
                foreach (FileTags file in Globals.fileTags)
                {
                    Globals.files.Add(file);
                }
            }

            //SET TOOLTIPS ON BUTTON
            ToolTip hoverTip = new ToolTip();
            hoverTip.SetToolTip(BtnSettings, "Settings");
            hoverTip.SetToolTip(btnSave, "Save");
            hoverTip.SetToolTip(btnRename, "Add tags to File");
            hoverTip.SetToolTip(btnMultipleEdit, "Multi Edit");
            
            //changeLayout(); //UNUSED

            //MOUSE CLICK METHODS
            addHandlers();

            //RELOAD FILES FROM JSON FILE OR THROUGH BACKGROUND WORK
            if (Globals.fileTags.Count == 0 && Globals.folders.Count > 0)
            {
                initiateBGWork();
            }
            else
            {
                reloadCompleted(sender, e);
            }

        }

        //#BGWORK RUN WORKER
        public void initiateBGWork()
        {
            //CHECKING BACKGROUND WORKER IS BUSY
            int secondWasted = 0;
            int secondStep = 5;
            while (bgWorker.IsBusy)
            {
                System.Threading.Thread.Sleep(1);
                secondWasted++;
                if (secondWasted % secondStep == 0)
                {
                    if (MessageBox.Show("Process is busy right now. Are you want to wait?", "Waiting...",MessageBoxButtons.YesNo) == DialogResult.No )
                    {
                        if (MessageBox.Show("Last changes will be lost. Are you sure?", "Waiting...", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                        {
                        break;
                        }
                    }
                    secondStep++;
                }
            }

            if (!bgWorker.IsBusy) 
            {
                progressBar1.Visible = true;
                statusStrip1.Visible = false;

                //DO BACKGROUND WORKER
                bgWorker.RunWorkerAsync();
            }
            
        }

        //#BGWORK START WORK
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Globals.populateFiles(bgWorker);
            bgWorker.ReportProgress(100);
        }

        //#BGWORK COMPLETED -1
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            reloadCompleted(sender, e);
        }

        private void reloadCompleted(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            statusStrip1.Visible = true;
            this.Enabled = true;
            this.Text = "TagExplorer";
            txtSearchFile.Text = "";
            reloadList();
            if (Globals.warnings.Count > 0)
            {
                string warningMsg = String.Join("\n", Globals.warnings);
                MessageBox.Show(warningMsg, "Error Messages", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Globals.files.Count <= 0)
            {
                BtnSettings_Click(sender, e);
            }

        }


        //#BGWORK PROGRESS
        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            this.Text = "TagExplorer (Loading... " + e.ProgressPercentage.ToString() + "%)";
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm FrmSet = new SettingsForm();
            FrmSet.ShowDialog();
        }

        public void reloadList()
        {
            listFiles.Items.Clear();
            foreach (FileTags cFile in Globals.files)
            {
                //bool isRightFile = cFile.filename.Contains(txtSearchFile.Text, System.Globalization.CompareOptions.OrdinalIgnoreCase);
                int idxFound = cFile.filename.IndexOf(txtSearchFile.Text, 0, cFile.filename.Length, StringComparison.OrdinalIgnoreCase);
                if (txtSearchFile.Text != "" && idxFound < 0) { continue; }
                var taggedFile = Globals.fileTags.Find(x => x.filename.Equals(cFile.filename));
                string tagStr = "";
                if (taggedFile != null && (!chkBlankOnly.Checked || chkShowAll.Checked)) //file has been tagged
                {
                    if (!taggedFile.containTags(Globals.filterTags)) { continue; }

                    List<string> tagArr = new List<string>();
                    foreach (Tag tagItem in taggedFile.tags)
                    {
                        tagArr.Add(tagItem.text);
                    }
                    tagStr = string.Join(Globals.tagSeparator, tagArr.ToArray());
                }
                else if (!chkBlankInclude.Checked && !chkBlankOnly.Checked && !chkShowAll.Checked)
                {
                    continue;
                }
                string cRes = "";
                if (cFile.resolution <= 0)
                {
                    cRes = "";
                }
                else
                {
                    cRes = cFile.resolution.ToString();
                }
                listFiles.Items.Add(newListItem(cFile.filename, cRes, tagStr, cFile.folder.path));
            }

            if (Globals.totalFiles < listFiles.Items.Count)
            {
                Globals.totalFiles = listFiles.Items.Count;
            }

            stripLabel.Text = listFiles.Items.Count.ToString() + " of " + Globals.totalFiles + " files generated.";
            reloadTagList();
        }

        private void reloadTagList()
        {

            if (Globals.isFilterMode && !chkShowAll.Checked && !Globals.settingsChanged) {
                Globals.isResetTags = false;
                return; 
            }
            Globals.settingsChanged = false;
            Globals.isResetTags = true;

            if (chkShowAll.Checked || chkBlankOnly.Checked)
            {
                foreach (ListViewItem item in listTagPicker.Items)
                {
                    item.Checked = false;
                }
            }

            listTagPicker.Clear();

            foreach (Tag cTag in Globals.tags)
            {
                int idxFound = cTag.text.IndexOf(txtSearchTags.Text, 0, cTag.text.Length, StringComparison.OrdinalIgnoreCase);
                if (txtSearchTags.Text != "" && idxFound < 0) { continue; }

                ListViewItem li = new ListViewItem(cTag.text);
                if (Globals.filterTags.Count > 0)
                {
                    li.Checked = Globals.filterTags.Contains(cTag.text);
                }
                listTagPicker.Items.Add(cTag.text);
            }
            Globals.isResetTags = false;

        }


        private ListViewItem newListItem(string fname, string fresolution, string fTags, string fFolder)
        {
            string[] fItems = new string[4];
            fItems[0] = fname;
            fItems[1] = fresolution;
            fItems[2] = fTags;
            fItems[3] = fFolder;
            ListViewItem li = new ListViewItem(fItems);
            return li;
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fSearch = "";

            if (Globals.isMultiActive)
            {
                foreach (ListViewItem item in listFiles.SelectedItems)
                {
                    item.Checked = true;
                }
            }

            if (listFiles.SelectedItems.Count <= 0 ) { return; }

            //if ( Globals.isFilterMode ) { return; }
            if (Globals.currFile != null && !Globals.isFilterMode) // update class array for fileTags; saving last file changed
            {
                int idxFile = Globals.fileTags.FindIndex( x => x.filename == Globals.currFile.filename);
                if (idxFile >= 0) {
                    Globals.fileTags[idxFile].updateTags(Globals.currFile.tags);
                }
                else{
                    Globals.fileTags.Add(Globals.currFile);
                }
            }

            Globals.isResetTags = true;

            foreach (ListViewItem cItem in listTagPicker.CheckedItems)
            {
                cItem.Checked = false;
            }

            fSearch = listFiles.SelectedItems[0].SubItems[0].Text;
            Globals.currFile = Globals.fileTags.Find(x => x.filename.Equals(fSearch)); //Cari filter

            if (Globals.currFile == null) {
                Globals.currFile = Globals.files.Find(x => x.filename.Equals(fSearch)); //Cari file non filter
                Globals.isResetTags = false;
                return;
            }

            Globals.isResetTags = false;
        }



        private void listTagPicker_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (Globals.isResetTags) { return; }

            if (Globals.isFilterMode)
            {
                Globals.isChangeByClick = false;
                if (listTagPicker.CheckedItems.Count > 0)
                {
                    chkShowAll.Checked = false;
                }
                else if (!chkBlankOnly.Checked && !chkShowAll.Checked)
                {
                    chkShowAll.Checked = true;
                }
                Globals.filterTags.Clear();
                foreach (ListViewItem item in listTagPicker.CheckedItems)
                {
                    Globals.filterTags.Add(item.Text);
                }
                Globals.isChangeByClick = true;
                reloadList();
            }
            else
            {
                if (listFiles.SelectedItems.Count <= 0) { return; }
                //editFileTags(sender,e);
            }
        }

        private void editFileTags(object sender, ItemCheckedEventArgs e)
        {
            //Globals.folderChanged = true;
            Globals.multiFiles = new List<FileTags>();

            List<ListViewItem> chkItems = new List<ListViewItem>();

            if (!Globals.isMultiActive)
            {
                chkItems.Add(listFiles.SelectedItems[0]);
            }
            else{
                foreach( ListViewItem li in listFiles.CheckedItems)
                {
                    chkItems.Add(li);
                }
            }
            
            //PROCESSING TAG CHECK ON SINGLE & MULTI MODE
            foreach (ListViewItem item in chkItems)
            {

                string fSearch = item.SubItems[0].Text;
                Globals.currFile = Globals.fileTags.Find(x => x.filename.Equals(fSearch)); //Get existing fileTag

                if (Globals.currFile == null)
                {
                    string cFolder = listFiles.SelectedItems[0].SubItems[3].Text;
                    string cRes = listFiles.SelectedItems[0].SubItems[1].Text;
                    string cName = listFiles.SelectedItems[0].SubItems[0].Text;

                    Globals.currFile = new FileTags(cFolder, Globals.cIntNull(cRes), cName);
                    Globals.fileTags.Add(Globals.currFile); // Add new filetag, if not exist
                }

                if (e.Item.Checked == false)
                {
                    Globals.currFile.delTags(e.Item.Text);
                }
                else
                {
                    Globals.currFile.addTags(e.Item.Text);
                }

                bool fileExist = false;
                foreach (FileTags file in Globals.fileTags)
                {
                    if (file.filename.Equals(Globals.currFile.filename) && file.folder.path.Equals(Globals.currFile.folder.path))
                    {
                        file.updateTags(Globals.currFile.tags);
                        fileExist = true;
                    }
                }

                if (!fileExist)
                {
                    Globals.fileTags.Add(Globals.currFile);
                }

                Globals.multiFiles.Add(Globals.currFile);

            }
            updateTagsList();

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Globals.settingsChanged = false;
            Form FrmSet;
            if (Type.GetType("SettingsForm_beta") != null && Globals.betaMode)
            {
                FrmSet = new SettingsForm_beta();
            }
            else
            {
                FrmSet = new SettingsForm();
            }

            FrmSet.ShowDialog();
        }

        private void saveTaggedFilles()
        {
            foreach (FileTags fTag in Globals.fileTags)
            {
                int fIdx = Globals.files.FindIndex(x => x.isSameFile(fTag));
                if (fIdx >= 0)
                {
                    Globals.files[fIdx].updateTags(fTag.tags);
                }
                else
                {
                    Globals.files.Add(fTag);
                }
            }

            Globals.jsonFiles = JsonConvert.SerializeObject(Globals.files);
            File.WriteAllText(Globals.jFilePath, Globals.jsonFiles);

            //Insert tags onto files
            foreach (FileTags file in Globals.fileTags)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listFiles.SelectedItems.Clear();
            saveTaggedFilles();
            Globals.folderChanged = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.folderChanged)
            {
                if (MessageBox.Show("Save data?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveTaggedFilles();
                }
            }
        }

        private void updateTagsList()
        {
            //UPDATING TAGS ON FILES LIST
            if (Globals.multiFiles == null)
            {
                Globals.multiFiles = new List<FileTags>();
                Globals.multiFiles.Add(Globals.currFile);
            }
            foreach (FileTags ft in Globals.multiFiles)
            {
                List<string> tagArr = new List<string>();
                foreach (Tag tagItem in ft.tags)
                {
                    tagArr.Add(tagItem.text);
                }
                string tagsComb = String.Join(Globals.tagSeparator, tagArr.ToArray());
                foreach (ListViewItem item in listFiles.Items)
                {
                    if (item.SubItems[0].Text.Equals(ft.filename) && item.SubItems[3].Text.Equals(ft.folder.path))
                    {
                        item.SubItems[2].Text = tagsComb;
                        break;
                    }
                }
            }
        }

        private void changeLayout()
        {
            if (Globals.isFilterMode)
            {
            }
            else
            {
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listFiles.SelectedItems.Clear();

            //Get filter Tags
            Globals.isResetTags = true;
            foreach (ListViewItem li in listTagPicker.SelectedItems)
            {
                li.Checked = false;
            }

            foreach (string cTag in Globals.filterTags)
            {
                ListViewItem li = listTagPicker.FindItemWithText(cTag);
                if (li != null)
                {
                    listTagPicker.Items[li.Index].Checked = true;
                }
            }
            Globals.isResetTags = false;

            Globals.isFilterMode = true;
            changeLayout();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            listFiles.SelectedItems.Clear();

            Globals.isFilterMode = false;
            changeLayout();
        }

        private void chkBlankInclude_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlankInclude.Checked)
            {
                chkBlankOnly.Checked = false;
                chkShowAll.Checked = false;
            }
            else if (!chkBlankInclude.Checked && !chkBlankOnly.Checked && Globals.filterTags.Count <= 0)
            {
                chkShowAll.Checked = true;
            }

            reloadList();
        }

        private void chkBlankOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlankOnly.Checked) {
                chkBlankInclude.Checked = false;
                chkShowAll.Checked = false;
            }
            else if (!chkBlankInclude.Checked && !chkBlankOnly.Checked && Globals.filterTags.Count <= 0)
            {
                chkShowAll.Checked = true;
            }

            reloadList();
        }

        private void chkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (Globals.isChangeByClick)
            {
                if (chkShowAll.Checked)
                {
                    chkBlankOnly.Checked = false;
                    chkBlankInclude.Checked = false;
                }
                else if (!chkBlankInclude.Checked && !chkBlankOnly.Checked && Globals.filterTags.Count <= 0)
                {
                    chkShowAll.Checked = true;
                }
                reloadList();
            }
        }

        private void txtSearchFile_TextChanged(object sender, EventArgs e)
        {
            reloadList();
        }

        private void btnClrSearchTags_Click(object sender, EventArgs e)
        {
            txtSearchTags.Text = "";
        }

        private void btnClrSearchFile_Click(object sender, EventArgs e)
        {
            txtSearchFile.Text = "";
        }

        private void txtSearchTags_TextChanged(object sender, EventArgs e)
        {
            reloadTagList();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (Globals.currFile != null)
            {
                RenameForm rnmForm = new RenameForm();
                rnmForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("A File must be selected!");
            }
        }

        public void updateNewFilename()
        {
            string oldFileName = listFiles.SelectedItems[0].SubItems[0].Text;
            listFiles.SelectedItems[0].SubItems[0].Text = Globals.currFile.filename;

            foreach (FileTags fileTag in Globals.fileTags)
            {
                if (fileTag.filename.Equals(oldFileName))
                {
                    fileTag.filename = Globals.currFile.filename;
                    break;
                }
            }
            foreach (FileTags file in Globals.files)
            {
                if (file.filename.Equals(oldFileName))
                {
                    file.filename = Globals.currFile.filename;
                    break;
                }
            }
            Globals.folderChanged = true;
        }

        private void openFile()
        {
            if (listFiles.SelectedItems.Count <= 0) { return; }

            string fSearch = listFiles.SelectedItems[0].SubItems[0].Text;
            Globals.currFile = Globals.files.Find(x => x.filename.Equals(fSearch));

            if (Globals.currFile != null)
            {
                FileInfo fInfo = new FileInfo(Globals.currFile.folder.path + "\\" + Globals.currFile.filename);
                //string pathEscape = "\"" + Regex.Replace(fInfo.FullName, @"(\\+)$", @"$1$1") + "\"";
                string fullPath = fInfo.FullName;
                System.Diagnostics.Process.Start(fullPath);
            }
        }

        private void listFiles_DoubleClick(object sender, EventArgs e)
        {
            openFile();
        }

        private void checkRadioButtons(object sender, EventArgs e)
        {
            //Globals.files = from element in Globals.files orderby element.filename ascending select element;
            if (radioSortName.Checked && radioAsc.Checked)
            {
                Globals.files.Sort((a, b) => a.filename.CompareTo(b.filename));
            }
            else if (radioSortName.Checked && radioDesc.Checked)
            {
                Globals.files.Sort((a, b) => a.filename.CompareTo(b.filename) * -1);
            }
            if (radioSortFolder.Checked && radioAsc.Checked)
            {
                Globals.files.Sort((a, b) => a.folder.path.CompareTo(b.folder.path));
            }
            else if (radioSortFolder.Checked && radioDesc.Checked)
            {
                Globals.files.Sort((a, b) => a.folder.path.CompareTo(b.folder.path) * -1);
            }
            if (radioSortHeight.Checked && radioAsc.Checked)
            {
                Globals.files.Sort((a, b) => a.resolution.CompareTo(b.resolution));
            }
            else if (radioSortHeight.Checked && radioDesc.Checked)
            {
                Globals.files.Sort((a, b) => a.resolution.CompareTo(b.resolution) * -1);
            }
            reloadList();

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //Globals.files.OrderBy(x => rnd.Next());
            shuffleFiles();
            reloadList();
        }
        public static void shuffleFiles() // Fisher-Yates shuffle algorithm
        {
            Random rng = new Random();
            int n = Globals.files.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                FileTags tempFile = Globals.files[k];
                Globals.files[k] = Globals.files[n];
                Globals.files[n] = tempFile;
            }
        }

        private void labelRemoveTags_Click(object sender, EventArgs e)
        {

        }

        private void labelUndo_Click(object sender, EventArgs e)
        {

        }


        private void addTags()
        {

            Globals.isResetTags = true;
            tagsEdit.Items.Clear();
            tagsEdit.CheckBoxes = true;
            tagsEdit.Visible = true;
            //tagsEdit.SelectionMode = SelectionMode.MultiSimple;
            tagsEdit.Location = this.PointToClient(Cursor.Position);
            //new Point(Cursor.P .X,Cursor.Position.Y);
            int calcCol = (tagsEdit.Items.Count / 12) + 1;
            tagsEdit.Width = calcCol * 120;
            tagsEdit.Height = 300;

            foreach (Tag cTag in Globals.tags)
            {
                tagsEdit.Items.Add(cTag.text);
            }

            foreach (Tag cTag in Globals.currFile.tags)
            {
                ListViewItem li = tagsEdit.FindItemWithText(cTag.text);
                if (li != null)
                {
                    tagsEdit.Items[li.Index].Checked = true;
                }
            }

            Globals.isResetTags = false;
        }

        private void listFiles_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                if (Globals.currFile == null) { return; }

                addTags();
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (tagsEdit.Visible)
                {
                    tagsEdit.Visible = false;
                }
            }

        }

        private void tagsEdit_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (Globals.isResetTags) { return; } 
            editFileTags(sender, e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tagsEdit.Visible = false;
            }
        }

        private void addHandlers()
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals("tagsEdit")) { continue; }

                c.MouseClick += new MouseEventHandler(Form1_MouseClick);
            }
        }

        private void listTagPicker_Click(object sender, EventArgs e)
        {
            tagsEdit.Visible = false;
        }

        private void btnRemoveTags_Click(object sender, EventArgs e)
        {
            if (Globals.lastFileTags.Count > 30)
            {
                Globals.lastFileTags.Clear();
            }

            //Globals.fileTags.CopyTo(Globals.lastFileTags, 0);
            if (!Globals.isMultiActive)
            {
                if (Globals.currFile == null) { return; }

                FileTags remFile = new FileTags("", 0, "");
                remFile.CopyFrom(Globals.currFile);
                Globals.lastFileTags.Push(remFile);
                Globals.currFile.tags = new List<Tag>();
            }
            else
            {
                Globals.multiFiles = new List<FileTags>();
                foreach(ListViewItem item in listFiles.SelectedItems)
                {
                    string fName = item.SubItems[0].Text;
                    int res = item.SubItems[1].Text != "" ? Convert.ToInt16(item.SubItems[1].Text) : 0;
                    string folder = item.SubItems[3].Text;
                    Globals.currFile = new FileTags(folder,res,fName);
                    FileTags remFile = new FileTags("", 0, "");
                    remFile.CopyFrom(Globals.currFile);
                    Globals.lastFileTags.Push(remFile);
                    Globals.currFile.tags = new List<Tag>();
                    Globals.multiFiles.Add(Globals.currFile);
                }
            }
            updateTagsList();

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (Globals.lastFileTags.Count <= 0) { return; }

            FileTags undoFile = Globals.lastFileTags.Pop();

            foreach (ListViewItem fItem in listFiles.Items)
            {
                if (fItem.SubItems[0].Text == undoFile.filename &&  //filename
                    fItem.SubItems[3].Text == undoFile.folder.path) //folder
                {
                    List<string> tagArr = new List<string>();
                    foreach (Tag tagItem in undoFile.tags)
                    {
                        tagArr.Add(tagItem.text);
                    }
                    string tagsComb = String.Join(Globals.tagSeparator, tagArr.ToArray());
                    fItem.SubItems[2].Text = tagsComb;
                    break;
                }
            }
            //Globals.fileTags = Globals.lastFileTags;
            //reloadList();
            listFiles.SelectedItems.Clear();
            Globals.currFile = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void listFiles_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listFiles.DoDragDrop(Globals.draggedFiles, DragDropEffects.Copy);
            
            //d.SetData(DataFormats.Serializable, e.Item);
            //d.SetData(DataFormats.Text, e.Item.ToString());
            ////listFiles.DoDragDrop(e.Item, DragDropEffects.Copy);

            //DoDragDrop(d, DragDropEffects.Copy);
            
        }

        private void listFiles_MouseDown(object sender, MouseEventArgs e)
        {
            //listFiles_MouseClick(sender,e);
            if (e.Button == MouseButtons.Left)
            {
                string[] fileStr;

                if (listFiles.CheckedItems.Count > 1)
                {
                    fileStr = new string[listFiles.CheckedItems.Count];
                    int i = 0;
                    foreach (ListViewItem cursorItem in listFiles.CheckedItems)
                    {
                        fileStr[i] = cursorItem.SubItems[3].Text + "\\" + cursorItem.SubItems[0].Text;
                        i++;
                    }
                }
                else
                {
                    fileStr = new string[1];
                    ListViewItem cursorItem = listFiles.GetItemAt(e.X, e.Y);
                    if (cursorItem == null) { return; }

                    fileStr[0] = cursorItem.SubItems[3].Text + "\\" + cursorItem.SubItems[0].Text;
                }
                Globals.draggedFiles.SetData(DataFormats.FileDrop, fileStr);
                //listFiles.DoDragDrop(Globals.draggedFiles, DragDropEffects.Copy);
            }
            
        }

        private void listFiles_DragOver(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            listFiles.DoDragDrop(Globals.draggedFiles, DragDropEffects.Copy);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMultipleEdit_Click(object sender, EventArgs e)
        {
            Globals.isMultiActive = !Globals.isMultiActive;

            Globals.isResetTags = true;
            listFiles.SelectedItems.Clear();
            foreach (ListViewItem item in listFiles.CheckedItems)
            {
                item.Checked = false;
            }

            if (Globals.isMultiActive)
            {
                listFiles.BackColor = Color.White;
                btnMultipleEdit.BackColor = Color.PaleTurquoise;
                listFiles.CheckBoxes = true;
                listFiles.MultiSelect = true;
            }
            else {
                listFiles.BackColor = Color.Gainsboro;
                btnMultipleEdit.BackColor = Color.LightSeaGreen;
                listFiles.CheckBoxes = false;
                listFiles.MultiSelect = false;
            }
            Globals.isResetTags = false;

        }

        private void btnRefreshFiles_Click(object sender, EventArgs e)
        {
            if (Globals.folders.Count > 0)
            {
                initiateBGWork();
            }

        }

        private void listFiles_MouseClick(object sender, EventArgs e)
        {

        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            addTags();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFile();
        }




  
    }

    public class tagsComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            string sX = (x as ListViewItem).SubItems[0].Text;
            string sY = (y as ListViewItem).SubItems[0].Text;
            int nX = sX != null || sX != "" ? Convert.ToInt16(sX) : 0;
            int nY = sY != null || sY != "" ? Convert.ToInt16(sY) : 0;
            return nX.CompareTo(nY);
        }
    }

    //static class Globals
    //{

    //}
}
