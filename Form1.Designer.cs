namespace TagExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listFiles = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTagPicker = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEditFilter = new System.Windows.Forms.Label();
            this.tagsEdit = new System.Windows.Forms.ListView();
            this.txtSearchFile = new System.Windows.Forms.TextBox();
            this.chkBlankInclude = new System.Windows.Forms.CheckBox();
            this.chkBlankOnly = new System.Windows.Forms.CheckBox();
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchTags = new System.Windows.Forms.TextBox();
            this.btnClrSearchFile = new System.Windows.Forms.Button();
            this.btnClrSearchTags = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioSortHeight = new System.Windows.Forms.RadioButton();
            this.radioSortFolder = new System.Windows.Forms.RadioButton();
            this.radioSortName = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioDesc = new System.Windows.Forms.RadioButton();
            this.radioAsc = new System.Windows.Forms.RadioButton();
            this.btnRandom = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRemoveTags = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnAddTags = new System.Windows.Forms.Button();
            this.btnRefreshFiles = new System.Windows.Forms.Button();
            this.btnMultipleEdit = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1132, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Visible = false;
            // 
            // stripLabel
            // 
            this.stripLabel.Name = "stripLabel";
            this.stripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // listFiles
            // 
            this.listFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listFiles.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listFiles.AllowDrop = true;
            this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listFiles.BackColor = System.Drawing.Color.Gainsboro;
            this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.resolution,
            this.tags,
            this.folder});
            this.listFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.FullRowSelect = true;
            this.listFiles.GridLines = true;
            this.listFiles.HideSelection = false;
            this.listFiles.Location = new System.Drawing.Point(0, 163);
            this.listFiles.MultiSelect = false;
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(1132, 310);
            this.listFiles.TabIndex = 2;
            this.listFiles.UseCompatibleStateImageBehavior = false;
            this.listFiles.View = System.Windows.Forms.View.Details;
            this.listFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listFiles_ItemDrag);
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            this.listFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.listFiles_DragOver);
            this.listFiles.DoubleClick += new System.EventHandler(this.listFiles_DoubleClick);
            this.listFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFiles_MouseClick);
            this.listFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listFiles_MouseDown);
            // 
            // fileName
            // 
            this.fileName.Text = "Name";
            this.fileName.Width = 500;
            // 
            // resolution
            // 
            this.resolution.Text = "FHeight";
            // 
            // tags
            // 
            this.tags.Text = "Tags";
            this.tags.Width = 400;
            // 
            // folder
            // 
            this.folder.Text = "Folder";
            this.folder.Width = 476;
            // 
            // listTagPicker
            // 
            this.listTagPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listTagPicker.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listTagPicker.CheckBoxes = true;
            this.listTagPicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTagPicker.LabelWrap = false;
            this.listTagPicker.Location = new System.Drawing.Point(0, 479);
            this.listTagPicker.MultiSelect = false;
            this.listTagPicker.Name = "listTagPicker";
            this.listTagPicker.Size = new System.Drawing.Size(1131, 89);
            this.listTagPicker.TabIndex = 3;
            this.listTagPicker.UseCompatibleStateImageBehavior = false;
            this.listTagPicker.View = System.Windows.Forms.View.List;
            this.listTagPicker.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listTagPicker_ItemChecked);
            this.listTagPicker.Click += new System.EventHandler(this.listTagPicker_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnAddTags);
            this.panel1.Controls.Add(this.btnRefreshFiles);
            this.panel1.Controls.Add(this.labelEditFilter);
            this.panel1.Controls.Add(this.btnMultipleEdit);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 79);
            this.panel1.TabIndex = 4;
            // 
            // labelEditFilter
            // 
            this.labelEditFilter.AutoSize = true;
            this.labelEditFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEditFilter.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.labelEditFilter.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelEditFilter.Location = new System.Drawing.Point(1006, 0);
            this.labelEditFilter.Name = "labelEditFilter";
            this.labelEditFilter.Size = new System.Drawing.Size(126, 46);
            this.labelEditFilter.TabIndex = 2;
            this.labelEditFilter.Text = "FILTER";
            this.labelEditFilter.Visible = false;
            // 
            // tagsEdit
            // 
            this.tagsEdit.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.tagsEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tagsEdit.CheckBoxes = true;
            this.tagsEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsEdit.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.tagsEdit.LabelWrap = false;
            this.tagsEdit.Location = new System.Drawing.Point(374, 226);
            this.tagsEdit.Name = "tagsEdit";
            this.tagsEdit.Size = new System.Drawing.Size(51, 35);
            this.tagsEdit.TabIndex = 22;
            this.tagsEdit.UseCompatibleStateImageBehavior = false;
            this.tagsEdit.View = System.Windows.Forms.View.List;
            this.tagsEdit.Visible = false;
            this.tagsEdit.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.tagsEdit_ItemChecked);
            // 
            // txtSearchFile
            // 
            this.txtSearchFile.AllowDrop = true;
            this.txtSearchFile.Location = new System.Drawing.Point(72, 3);
            this.txtSearchFile.Name = "txtSearchFile";
            this.txtSearchFile.Size = new System.Drawing.Size(985, 21);
            this.txtSearchFile.TabIndex = 5;
            this.txtSearchFile.TextChanged += new System.EventHandler(this.txtSearchFile_TextChanged);
            // 
            // chkBlankInclude
            // 
            this.chkBlankInclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBlankInclude.AutoSize = true;
            this.chkBlankInclude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chkBlankInclude.Location = new System.Drawing.Point(107, 15);
            this.chkBlankInclude.Name = "chkBlankInclude";
            this.chkBlankInclude.Size = new System.Drawing.Size(125, 19);
            this.chkBlankInclude.TabIndex = 6;
            this.chkBlankInclude.Text = "Include Blank Tags";
            this.chkBlankInclude.UseVisualStyleBackColor = true;
            this.chkBlankInclude.CheckedChanged += new System.EventHandler(this.chkBlankInclude_CheckedChanged);
            // 
            // chkBlankOnly
            // 
            this.chkBlankOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBlankOnly.AutoSize = true;
            this.chkBlankOnly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chkBlankOnly.Location = new System.Drawing.Point(238, 15);
            this.chkBlankOnly.Name = "chkBlankOnly";
            this.chkBlankOnly.Size = new System.Drawing.Size(111, 19);
            this.chkBlankOnly.TabIndex = 7;
            this.chkBlankOnly.Text = "Blank Tags Only";
            this.chkBlankOnly.UseVisualStyleBackColor = true;
            this.chkBlankOnly.CheckedChanged += new System.EventHandler(this.chkBlankOnly_CheckedChanged);
            // 
            // chkShowAll
            // 
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.Checked = true;
            this.chkShowAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chkShowAll.Location = new System.Drawing.Point(3, 15);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(98, 19);
            this.chkShowAll.TabIndex = 8;
            this.chkShowAll.Text = "Show All Files";
            this.chkShowAll.UseVisualStyleBackColor = true;
            this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Tags";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchTags
            // 
            this.txtSearchTags.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearchTags.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTags.Location = new System.Drawing.Point(140, 3);
            this.txtSearchTags.Name = "txtSearchTags";
            this.txtSearchTags.Size = new System.Drawing.Size(168, 23);
            this.txtSearchTags.TabIndex = 10;
            this.txtSearchTags.TextChanged += new System.EventHandler(this.txtSearchTags_TextChanged);
            // 
            // btnClrSearchFile
            // 
            this.btnClrSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClrSearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClrSearchFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClrSearchFile.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClrSearchFile.Location = new System.Drawing.Point(1063, 3);
            this.btnClrSearchFile.Name = "btnClrSearchFile";
            this.btnClrSearchFile.Size = new System.Drawing.Size(58, 27);
            this.btnClrSearchFile.TabIndex = 11;
            this.btnClrSearchFile.Text = "Clear";
            this.btnClrSearchFile.UseVisualStyleBackColor = true;
            this.btnClrSearchFile.Click += new System.EventHandler(this.btnClrSearchFile_Click);
            // 
            // btnClrSearchTags
            // 
            this.btnClrSearchTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClrSearchTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClrSearchTags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClrSearchTags.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClrSearchTags.Location = new System.Drawing.Point(314, 3);
            this.btnClrSearchTags.Name = "btnClrSearchTags";
            this.btnClrSearchTags.Size = new System.Drawing.Size(57, 31);
            this.btnClrSearchTags.TabIndex = 12;
            this.btnClrSearchTags.Text = "Clear";
            this.btnClrSearchTags.UseVisualStyleBackColor = true;
            this.btnClrSearchTags.Click += new System.EventHandler(this.btnClrSearchTags_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.radioSortHeight);
            this.panel2.Controls.Add(this.radioSortFolder);
            this.panel2.Controls.Add(this.radioSortName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 26);
            this.panel2.TabIndex = 13;
            // 
            // radioSortHeight
            // 
            this.radioSortHeight.AutoSize = true;
            this.radioSortHeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioSortHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioSortHeight.Location = new System.Drawing.Point(195, 0);
            this.radioSortHeight.Name = "radioSortHeight";
            this.radioSortHeight.Size = new System.Drawing.Size(107, 26);
            this.radioSortHeight.TabIndex = 2;
            this.radioSortHeight.Text = "Sort by FHeight";
            this.radioSortHeight.UseVisualStyleBackColor = true;
            this.radioSortHeight.CheckedChanged += new System.EventHandler(this.checkRadioButtons);
            this.radioSortHeight.Click += new System.EventHandler(this.checkRadioButtons);
            // 
            // radioSortFolder
            // 
            this.radioSortFolder.AutoSize = true;
            this.radioSortFolder.Checked = true;
            this.radioSortFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioSortFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioSortFolder.Location = new System.Drawing.Point(97, 0);
            this.radioSortFolder.Name = "radioSortFolder";
            this.radioSortFolder.Size = new System.Drawing.Size(98, 26);
            this.radioSortFolder.TabIndex = 1;
            this.radioSortFolder.TabStop = true;
            this.radioSortFolder.Text = "Sort by Folder";
            this.radioSortFolder.UseVisualStyleBackColor = true;
            this.radioSortFolder.CheckedChanged += new System.EventHandler(this.checkRadioButtons);
            this.radioSortFolder.Click += new System.EventHandler(this.checkRadioButtons);
            // 
            // radioSortName
            // 
            this.radioSortName.AutoSize = true;
            this.radioSortName.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioSortName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioSortName.Location = new System.Drawing.Point(0, 0);
            this.radioSortName.Name = "radioSortName";
            this.radioSortName.Size = new System.Drawing.Size(97, 26);
            this.radioSortName.TabIndex = 0;
            this.radioSortName.Text = "Sort by Name";
            this.radioSortName.UseVisualStyleBackColor = true;
            this.radioSortName.CheckedChanged += new System.EventHandler(this.checkRadioButtons);
            this.radioSortName.Click += new System.EventHandler(this.checkRadioButtons);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.radioDesc);
            this.panel3.Controls.Add(this.radioAsc);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(344, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 26);
            this.panel3.TabIndex = 14;
            // 
            // radioDesc
            // 
            this.radioDesc.AutoSize = true;
            this.radioDesc.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioDesc.Location = new System.Drawing.Point(81, 0);
            this.radioDesc.Name = "radioDesc";
            this.radioDesc.Size = new System.Drawing.Size(87, 26);
            this.radioDesc.TabIndex = 1;
            this.radioDesc.Text = "Descending";
            this.radioDesc.UseVisualStyleBackColor = true;
            this.radioDesc.CheckedChanged += new System.EventHandler(this.checkRadioButtons);
            this.radioDesc.Click += new System.EventHandler(this.checkRadioButtons);
            // 
            // radioAsc
            // 
            this.radioAsc.AutoSize = true;
            this.radioAsc.Checked = true;
            this.radioAsc.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioAsc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioAsc.Location = new System.Drawing.Point(0, 0);
            this.radioAsc.Name = "radioAsc";
            this.radioAsc.Size = new System.Drawing.Size(81, 26);
            this.radioAsc.TabIndex = 0;
            this.radioAsc.TabStop = true;
            this.radioAsc.Text = "Ascending";
            this.radioAsc.UseVisualStyleBackColor = true;
            this.radioAsc.CheckedChanged += new System.EventHandler(this.checkRadioButtons);
            this.radioAsc.Click += new System.EventHandler(this.checkRadioButtons);
            // 
            // btnRandom
            // 
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRandom.Location = new System.Drawing.Point(542, 3);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(71, 24);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 611);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1132, 22);
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Visible = false;
            // 
            // btnRemoveTags
            // 
            this.btnRemoveTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTags.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnRemoveTags.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemoveTags.Location = new System.Drawing.Point(116, 3);
            this.btnRemoveTags.Name = "btnRemoveTags";
            this.btnRemoveTags.Size = new System.Drawing.Size(97, 25);
            this.btnRemoveTags.TabIndex = 23;
            this.btnRemoveTags.Text = "Remove Tags";
            this.btnRemoveTags.UseVisualStyleBackColor = true;
            this.btnRemoveTags.Click += new System.EventHandler(this.btnRemoveTags_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUndo.Location = new System.Drawing.Point(219, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(97, 25);
            this.btnUndo.TabIndex = 24;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search File";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.btnRandom);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(779, 34);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "|";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtSearchFile);
            this.flowLayoutPanel2.Controls.Add(this.btnClrSearchFile);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 79);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1132, 33);
            this.flowLayoutPanel2.TabIndex = 27;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.btnUndo);
            this.flowLayoutPanel3.Controls.Add(this.btnRemoveTags);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(813, 115);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(319, 34);
            this.flowLayoutPanel3.TabIndex = 28;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel4.Controls.Add(this.chkShowAll);
            this.flowLayoutPanel4.Controls.Add(this.chkBlankInclude);
            this.flowLayoutPanel4.Controls.Add(this.chkBlankOnly);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 574);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(663, 37);
            this.flowLayoutPanel4.TabIndex = 29;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.btnClrSearchTags);
            this.flowLayoutPanel5.Controls.Add(this.txtSearchTags);
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(758, 574);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(374, 37);
            this.flowLayoutPanel5.TabIndex = 30;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Image = global::TagExplorer.Properties.Resources._1474_Tape_48x48;
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenFile.Location = new System.Drawing.Point(552, 0);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(92, 79);
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnAddTags
            // 
            this.btnAddTags.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddTags.FlatAppearance.BorderSize = 0;
            this.btnAddTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTags.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTags.Image = global::TagExplorer.Properties.Resources._112_Plus_Green_48x48_72;
            this.btnAddTags.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTags.Location = new System.Drawing.Point(460, 0);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Size = new System.Drawing.Size(92, 79);
            this.btnAddTags.TabIndex = 8;
            this.btnAddTags.Text = "Add Tags";
            this.btnAddTags.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTags.UseVisualStyleBackColor = true;
            this.btnAddTags.Click += new System.EventHandler(this.btnAddTags_Click);
            // 
            // btnRefreshFiles
            // 
            this.btnRefreshFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshFiles.FlatAppearance.BorderSize = 0;
            this.btnRefreshFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshFiles.Image = global::TagExplorer.Properties.Resources._112_RefreshArrow_Blue_48x48_72;
            this.btnRefreshFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshFiles.Location = new System.Drawing.Point(368, 0);
            this.btnRefreshFiles.Name = "btnRefreshFiles";
            this.btnRefreshFiles.Size = new System.Drawing.Size(92, 79);
            this.btnRefreshFiles.TabIndex = 7;
            this.btnRefreshFiles.Text = "Reload Files";
            this.btnRefreshFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshFiles.UseVisualStyleBackColor = true;
            this.btnRefreshFiles.Click += new System.EventHandler(this.btnRefreshFiles_Click);
            // 
            // btnMultipleEdit
            // 
            this.btnMultipleEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMultipleEdit.FlatAppearance.BorderSize = 0;
            this.btnMultipleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultipleEdit.Image = global::TagExplorer.Properties.Resources._1462_Pencil_48x48;
            this.btnMultipleEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMultipleEdit.Location = new System.Drawing.Point(276, 0);
            this.btnMultipleEdit.Name = "btnMultipleEdit";
            this.btnMultipleEdit.Size = new System.Drawing.Size(92, 79);
            this.btnMultipleEdit.TabIndex = 6;
            this.btnMultipleEdit.Text = "Multi Edit";
            this.btnMultipleEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMultipleEdit.UseVisualStyleBackColor = true;
            this.btnMultipleEdit.Click += new System.EventHandler(this.btnMultipleEdit_Click);
            // 
            // btnRename
            // 
            this.btnRename.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRename.FlatAppearance.BorderSize = 0;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Image = global::TagExplorer.Properties.Resources.Rename;
            this.btnRename.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRename.Location = new System.Drawing.Point(184, 0);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(92, 79);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "Rename";
            this.btnRename.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::TagExplorer.Properties.Resources.FloppyDisk;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(92, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 79);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Image = global::TagExplorer.Properties.Resources.settings_48;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSettings.Location = new System.Drawing.Point(0, 0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(92, 79);
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1132, 633);
            this.Controls.Add(this.tagsEdit);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listTagPicker);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TagExplorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragLeave += new System.EventHandler(this.Form1_DragLeave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ListView listFiles;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader tags;
        private System.Windows.Forms.ColumnHeader folder;
        private System.Windows.Forms.ListView listTagPicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label labelEditFilter;
        private System.Windows.Forms.TextBox txtSearchFile;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.CheckBox chkBlankInclude;
        private System.Windows.Forms.CheckBox chkBlankOnly;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTags;
        private System.Windows.Forms.Button btnClrSearchFile;
        private System.Windows.Forms.Button btnClrSearchTags;
        private System.Windows.Forms.ToolStripStatusLabel stripLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioSortFolder;
        private System.Windows.Forms.RadioButton radioSortName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioDesc;
        private System.Windows.Forms.RadioButton radioAsc;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ColumnHeader resolution;
        private System.Windows.Forms.RadioButton radioSortHeight;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView tagsEdit;
        private System.Windows.Forms.Button btnRemoveTags;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMultipleEdit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button btnRefreshFiles;
        private System.Windows.Forms.Button btnAddTags;
        private System.Windows.Forms.Button btnOpenFile;

    }
}

