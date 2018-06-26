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

namespace TagExplorer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioBFolder_CheckedChanged(object sender, EventArgs e)
        {
            PanelFolder.Visible = true;
            PanelTags.Visible = false;
            PanelFolder.Dock = DockStyle.Fill;

        }

        private void RadioBTags_CheckedChanged(object sender, EventArgs e)
        {
            PanelFolder.Visible = false;
            PanelTags.Visible = true;
            PanelTags.Dock = DockStyle.Fill;

        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtPath.Text = folderBrowserDialog1.SelectedPath;
            if ( txtPath.Text != "" ) {
                BtnAdd.Enabled = true;
            }
            else {
                BtnAdd.Enabled = false;
            }
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Globals.settingsChanged = true;
            if (txtPath.Text == "")
            {
                MessageBox.Show("Choose a folder!");
                return;
            }
            if (!Directory.Exists(txtPath.Text))
            {
                MessageBox.Show("Invalid directory!");
                return;
            }
            if ( !ListFolder.Items.Contains(txtPath.Text) ) {
                ListFolder.Items.Add(txtPath.Text);
                Globals.folderChanged = true;
            }
            else{
                MessageBox.Show("Path already exists!");
            }
 
        }

        private void ListFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRemove.Enabled = true;
            if (ListFolder.SelectedIndex >= 0)
            {
                txtPath.Text = ListFolder.SelectedItem.ToString();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Globals.settingsChanged = true;
            Globals.folderChanged = true;
            ListFolder.Items.RemoveAt(ListFolder.SelectedIndex);
            BtnRemove.Enabled = false;
            txtPath.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveExit();
            this.Close();
        }


        private void btnAddTags_Click(object sender, EventArgs e)
        {
            if (!Globals.isValidFileName(txtTag.Text))
            {
                MessageBox.Show("Tags can not contains < > : \" / \\ | ? *", "Invalid Filename", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Globals.settingsChanged = true;
            if (txtTag.Text != "")
            {
                bool tagExist = false;
                foreach(ListViewItem vItem in listTags.Items)
                {
                    if (vItem.SubItems[0].Text == txtTag.Text)
                    {
                        tagExist = true;
                        break;
                    }
                }

                if (tagExist)
                {
                    MessageBox.Show("Tag Exists!");
                }
                else
                {
                    
                    addNewTags(txtTag.Text);
                    Globals.settingsChanged = true;
                }
            }
            txtTag.Clear();
            txtTag.Focus();
        }

        private void addNewTags(string pTag)
        {
            //ListViewItem li;
            //string[] liArr = new string[2];
            //int num = listTags.Items.Count + 1;
            //liArr[0] = num.ToString();
            //liArr[1] = pTag.ToString();
            //li = new ListViewItem(liArr);
            //listTags.Items.Add(li);
            listTags.Items.Add(pTag);


        }

        private void listTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            //UNUSED
            if (listTags.SelectedItems.Count > 0)
            {
                btnBringDown.Enabled = true;
                btnBringLast.Enabled = true;
                btnBringUp.Enabled = true;
                btnBringFirst.Enabled = true;
                BtnRemoveTags.Enabled = true;
            }
        }

        private void moveList(int idxOri, int idxDest, char direction)
        {
            //UNUSED
            if (idxDest >=0 && idxDest < listTags.Items.Count)
            {
                Globals.settingsChanged = true;
                if (direction == 'U')
                {
                    //listTags.Items[idxOri].SubItems[0].Text = (idxDest + 1).ToString();
                    //int numVal = 0;
                    //for (int i = idxDest; i < idxOri; i++)
                    //{
                    //    numVal = Convert.ToInt32(listTags.Items[i].SubItems[0].Text);
                    //    listTags.Items[i].SubItems[0].Text = (numVal + 1).ToString();
                    //}
                }
                else
                {
                    //listTags.Items[idxOri].SubItems[0].Text = (idxDest + 1).ToString();
                    //int numVal = 0;
                    //for (int i = idxOri + 1; i <= idxDest; i++)
                    //{
                    //    numVal = Convert.ToInt32(listTags.Items[i].SubItems[0].Text);
                    //    listTags.Items[i].SubItems[0].Text = (numVal - 1).ToString();
                    //}
                }

                //listTags.ListViewItemSorter = new tagsComparer();
                listTags.Sort();

                listTags.SelectedItems.Clear();
                listTags.SelectedIndices.Add(idxDest);
                //listTags.Items[idxDest].Selected = true;
            }
            listTags.Select();

        }


        private void btnBringFirst_Click(object sender, EventArgs e)
        {
            var idxSelect = listTags.SelectedIndices[0];
            moveList(idxSelect, 0, 'U');
        }

        private void brnBringUp_Click(object sender, EventArgs e)
        {
            var idxSelect = listTags.SelectedIndices[0];
            moveList(idxSelect, idxSelect - 1, 'U');
        }

        private void btnBringDown_Click(object sender, EventArgs e)
        {
            var idxSelect = listTags.SelectedIndices[0];
            moveList(idxSelect, idxSelect + 1, 'D');

        }

        private void btnBringLast_Click(object sender, EventArgs e)
        {
            var idxSelect = listTags.SelectedIndices[0];
            moveList(idxSelect, listTags.Items.Count - 1, 'D');
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.settingsChanged)
            {
                if (MessageBox.Show("Save data?", "Close Settings", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveExit();
                }
            }
        }

        private void saveExit(){
            if (Globals.settingsChanged)
            {
                saveFolder();
                saveTags();

                Globals.settingsChanged = false;
                Globals.files = new List<FileTags>();

                if (Globals.folderChanged)
                {
                    Form1 frmUtama = (Form1)Application.OpenForms["Form1"];
                    frmUtama.initiateBGWork();
                }
            }
        }

        private void saveFolder()
        {
            Globals.folders = new List<Folder>();
            foreach( string fText in ListFolder.Items) 
            {
                Folder fClass = new Folder();
                fClass.path = fText;
                Globals.folders.Add(fClass);

            }
            Globals.jsonFolders = JsonConvert.SerializeObject(Globals.folders);
            File.WriteAllText(Globals.jFolderPath, Globals.jsonFolders);
        }

        private void saveTags()
        {
            Globals.tags = new List<Tag>();
            foreach (ListViewItem item in listTags.Items)
            {
                Tag fClass = new Tag();
                fClass.order = item.Index;
                fClass.text = item.SubItems[0].Text;
                Globals.tags.Add(fClass);

            }
            Globals.jsonTags = JsonConvert.SerializeObject(Globals.tags);
            File.WriteAllText(Globals.jTagsPath, Globals.jsonTags);
        }

        private void populateFiles()
        {
            Globals.fileTags = new List<FileTags>();
        }

        private void BtnRemoveTags_Click(object sender, EventArgs e)
        {
            Globals.settingsChanged = true;
            btnBringDown.Enabled = false;
            btnBringLast.Enabled = false;
            btnBringUp.Enabled = false;
            btnBringFirst.Enabled = false;
            BtnRemoveTags.Enabled = false;

            listTags.Items.RemoveAt(listTags.SelectedIndices[0]);

            int acc = 0;
            foreach (ListViewItem item in listTags.Items)
            {
                acc++;
                item.SubItems[0].Text = acc.ToString();
            }
            listTags.SelectedItems.Clear();

        }

        private void btnResetDefault_Click(object sender, EventArgs e)
        {
            listTags.Items.Clear();
            ListFolder.Items.Clear();
            Globals.settingsChanged = true;
            Globals.folderChanged = true;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //listTags.Columns[0].Width = 25;
            //listTags.Columns[1].Width = listTags.Width - listTags.Columns[0].Width;
            listTags.Columns[0].Width = listTags.Width;
            //listTags.Columns[0].TextAlign = HorizontalAlignment.Right;

            Globals.folderChanged = false;

            listTags.Items.Clear();
            ListFolder.Items.Clear();

            foreach (Tag cTag in Globals.tags)
            {
                string[] strTag = new string[2];
                //strTag[0] = cTag.order.ToString();
                strTag[0] = cTag.text;
                ListViewItem li = new ListViewItem(strTag);
                listTags.Items.Add(li);
            }

            foreach (Folder cFol in Globals.folders)
            {
                ListFolder.Items.Add(cFol.path);
            }

            if (Globals.files.Count <= 0)
            {
                RadioBFolder.Checked = true;
                RadioBFolder_CheckedChanged(sender, e);
            }
            

        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (RadioBTags.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnAddTags_Click(sender, e);
                }
            }
        }

        private void txtTag_KeyDown(object sender, KeyEventArgs e)
        {
            SettingsForm_KeyDown(sender, e);
        }

        private void btnRemTagAll_Click(object sender, EventArgs e)
        {
            listTags.Items.Clear();
        }

    }

 
}
