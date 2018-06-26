namespace TagExplorer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnResetDefault = new System.Windows.Forms.Button();
            this.RadioBFolder = new System.Windows.Forms.RadioButton();
            this.RadioBTags = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PanelTags = new System.Windows.Forms.Panel();
            this.btnRemTagAll = new System.Windows.Forms.Button();
            this.btnBringLast = new System.Windows.Forms.Button();
            this.btnBringDown = new System.Windows.Forms.Button();
            this.btnBringUp = new System.Windows.Forms.Button();
            this.btnBringFirst = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.listTags = new System.Windows.Forms.ListView();
            this.ColTax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddTags = new System.Windows.Forms.Button();
            this.BtnRemoveTags = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelFolder = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.ListFolder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PanelTags.SuspendLayout();
            this.PanelFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.splitContainer1.Panel1.Controls.Add(this.btnResetDefault);
            this.splitContainer1.Panel1.Controls.Add(this.RadioBFolder);
            this.splitContainer1.Panel1.Controls.Add(this.RadioBTags);
            this.splitContainer1.Panel1.Controls.Add(this.BtnSave);
            this.splitContainer1.Panel1.Controls.Add(this.BtnExit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splitContainer1.Panel2.Controls.Add(this.PanelTags);
            this.splitContainer1.Panel2.Controls.Add(this.PanelFolder);
            this.splitContainer1.Size = new System.Drawing.Size(818, 448);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnResetDefault
            // 
            this.btnResetDefault.BackColor = System.Drawing.Color.LightCoral;
            this.btnResetDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetDefault.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnResetDefault.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnResetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDefault.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetDefault.Location = new System.Drawing.Point(0, 379);
            this.btnResetDefault.Name = "btnResetDefault";
            this.btnResetDefault.Size = new System.Drawing.Size(126, 23);
            this.btnResetDefault.TabIndex = 6;
            this.btnResetDefault.Text = "Reset Default";
            this.btnResetDefault.UseVisualStyleBackColor = false;
            this.btnResetDefault.Click += new System.EventHandler(this.btnResetDefault_Click);
            // 
            // RadioBFolder
            // 
            this.RadioBFolder.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioBFolder.AutoSize = true;
            this.RadioBFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.RadioBFolder.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.RadioBFolder.FlatAppearance.BorderSize = 0;
            this.RadioBFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioBFolder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RadioBFolder.Location = new System.Drawing.Point(0, 29);
            this.RadioBFolder.Name = "RadioBFolder";
            this.RadioBFolder.Size = new System.Drawing.Size(126, 29);
            this.RadioBFolder.TabIndex = 5;
            this.RadioBFolder.Text = "Folder Location";
            this.RadioBFolder.UseVisualStyleBackColor = true;
            this.RadioBFolder.CheckedChanged += new System.EventHandler(this.RadioBFolder_CheckedChanged);
            // 
            // RadioBTags
            // 
            this.RadioBTags.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioBTags.AutoSize = true;
            this.RadioBTags.Checked = true;
            this.RadioBTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.RadioBTags.FlatAppearance.BorderSize = 0;
            this.RadioBTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadioBTags.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.RadioBTags.Location = new System.Drawing.Point(0, 0);
            this.RadioBTags.Name = "RadioBTags";
            this.RadioBTags.Size = new System.Drawing.Size(126, 29);
            this.RadioBTags.TabIndex = 4;
            this.RadioBTags.TabStop = true;
            this.RadioBTags.Text = "Tags";
            this.RadioBTags.UseVisualStyleBackColor = true;
            this.RadioBTags.CheckedChanged += new System.EventHandler(this.RadioBTags_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSave.Location = new System.Drawing.Point(0, 402);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save And Exit";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.Location = new System.Drawing.Point(0, 425);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(126, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelTags
            // 
            this.PanelTags.Controls.Add(this.btnRemTagAll);
            this.PanelTags.Controls.Add(this.btnBringLast);
            this.PanelTags.Controls.Add(this.btnBringDown);
            this.PanelTags.Controls.Add(this.btnBringUp);
            this.PanelTags.Controls.Add(this.btnBringFirst);
            this.PanelTags.Controls.Add(this.label3);
            this.PanelTags.Controls.Add(this.txtTag);
            this.PanelTags.Controls.Add(this.listTags);
            this.PanelTags.Controls.Add(this.btnAddTags);
            this.PanelTags.Controls.Add(this.BtnRemoveTags);
            this.PanelTags.Controls.Add(this.label2);
            this.PanelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTags.Location = new System.Drawing.Point(0, 0);
            this.PanelTags.Name = "PanelTags";
            this.PanelTags.Size = new System.Drawing.Size(691, 448);
            this.PanelTags.TabIndex = 7;
            // 
            // btnRemTagAll
            // 
            this.btnRemTagAll.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRemTagAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemTagAll.Location = new System.Drawing.Point(604, 392);
            this.btnRemTagAll.Name = "btnRemTagAll";
            this.btnRemTagAll.Size = new System.Drawing.Size(75, 43);
            this.btnRemTagAll.TabIndex = 18;
            this.btnRemTagAll.Text = "Remove All";
            this.btnRemTagAll.UseVisualStyleBackColor = false;
            this.btnRemTagAll.Click += new System.EventHandler(this.btnRemTagAll_Click);
            // 
            // btnBringLast
            // 
            this.btnBringLast.Enabled = false;
            this.btnBringLast.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBringLast.Location = new System.Drawing.Point(604, 213);
            this.btnBringLast.Name = "btnBringLast";
            this.btnBringLast.Size = new System.Drawing.Size(38, 50);
            this.btnBringLast.TabIndex = 17;
            this.btnBringLast.Text = "v  v";
            this.btnBringLast.UseVisualStyleBackColor = true;
            this.btnBringLast.Visible = false;
            this.btnBringLast.Click += new System.EventHandler(this.btnBringLast_Click);
            // 
            // btnBringDown
            // 
            this.btnBringDown.Enabled = false;
            this.btnBringDown.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBringDown.Location = new System.Drawing.Point(604, 157);
            this.btnBringDown.Name = "btnBringDown";
            this.btnBringDown.Size = new System.Drawing.Size(38, 50);
            this.btnBringDown.TabIndex = 16;
            this.btnBringDown.Text = "v";
            this.btnBringDown.UseVisualStyleBackColor = true;
            this.btnBringDown.Visible = false;
            this.btnBringDown.Click += new System.EventHandler(this.btnBringDown_Click);
            // 
            // btnBringUp
            // 
            this.btnBringUp.Enabled = false;
            this.btnBringUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBringUp.Location = new System.Drawing.Point(604, 101);
            this.btnBringUp.Name = "btnBringUp";
            this.btnBringUp.Size = new System.Drawing.Size(38, 50);
            this.btnBringUp.TabIndex = 15;
            this.btnBringUp.Text = "^";
            this.btnBringUp.UseVisualStyleBackColor = true;
            this.btnBringUp.Visible = false;
            this.btnBringUp.Click += new System.EventHandler(this.brnBringUp_Click);
            // 
            // btnBringFirst
            // 
            this.btnBringFirst.Enabled = false;
            this.btnBringFirst.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBringFirst.Location = new System.Drawing.Point(604, 45);
            this.btnBringFirst.Name = "btnBringFirst";
            this.btnBringFirst.Size = new System.Drawing.Size(38, 50);
            this.btnBringFirst.TabIndex = 14;
            this.btnBringFirst.Text = "^^";
            this.btnBringFirst.UseVisualStyleBackColor = true;
            this.btnBringFirst.Visible = false;
            this.btnBringFirst.Click += new System.EventHandler(this.btnBringFirst_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tag:";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(37, 59);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(165, 23);
            this.txtTag.TabIndex = 9;
            this.txtTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTag_KeyDown);
            // 
            // listTags
            // 
            this.listTags.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listTags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColTax});
            this.listTags.FullRowSelect = true;
            this.listTags.GridLines = true;
            this.listTags.HideSelection = false;
            this.listTags.Location = new System.Drawing.Point(277, 45);
            this.listTags.MultiSelect = false;
            this.listTags.Name = "listTags";
            this.listTags.Size = new System.Drawing.Size(321, 391);
            this.listTags.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listTags.TabIndex = 7;
            this.listTags.UseCompatibleStateImageBehavior = false;
            this.listTags.View = System.Windows.Forms.View.Details;
            this.listTags.SelectedIndexChanged += new System.EventHandler(this.listTags_SelectedIndexChanged);
            // 
            // ColTax
            // 
            this.ColTax.Text = "Tags";
            // 
            // btnAddTags
            // 
            this.btnAddTags.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTags.Location = new System.Drawing.Point(76, 88);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Size = new System.Drawing.Size(75, 23);
            this.btnAddTags.TabIndex = 6;
            this.btnAddTags.Text = "Add";
            this.btnAddTags.UseVisualStyleBackColor = false;
            this.btnAddTags.Click += new System.EventHandler(this.btnAddTags_Click);
            // 
            // BtnRemoveTags
            // 
            this.BtnRemoveTags.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRemoveTags.Enabled = false;
            this.BtnRemoveTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveTags.Location = new System.Drawing.Point(604, 363);
            this.BtnRemoveTags.Name = "BtnRemoveTags";
            this.BtnRemoveTags.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveTags.TabIndex = 5;
            this.BtnRemoveTags.Text = "Remove";
            this.BtnRemoveTags.UseVisualStyleBackColor = false;
            this.BtnRemoveTags.Click += new System.EventHandler(this.BtnRemoveTags_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(634, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAGS";
            // 
            // PanelFolder
            // 
            this.PanelFolder.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PanelFolder.Controls.Add(this.btnBrowse);
            this.PanelFolder.Controls.Add(this.txtPath);
            this.PanelFolder.Controls.Add(this.BtnAdd);
            this.PanelFolder.Controls.Add(this.BtnRemove);
            this.PanelFolder.Controls.Add(this.ListFolder);
            this.PanelFolder.Controls.Add(this.label1);
            this.PanelFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PanelFolder.Location = new System.Drawing.Point(0, 0);
            this.PanelFolder.Name = "PanelFolder";
            this.PanelFolder.Size = new System.Drawing.Size(691, 448);
            this.PanelFolder.TabIndex = 0;
            this.PanelFolder.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(488, 383);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 384);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(466, 23);
            this.txtPath.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(523, 384);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRemove.Enabled = false;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Location = new System.Drawing.Point(604, 384);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // ListFolder
            // 
            this.ListFolder.FormattingEnabled = true;
            this.ListFolder.ItemHeight = 15;
            this.ListFolder.Location = new System.Drawing.Point(16, 59);
            this.ListFolder.Name = "ListFolder";
            this.ListFolder.Size = new System.Drawing.Size(663, 319);
            this.ListFolder.TabIndex = 1;
            this.ListFolder.SelectedIndexChanged += new System.EventHandler(this.ListFolder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(544, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOLDER LOCATION";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 448);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PanelTags.ResumeLayout(false);
            this.PanelTags.PerformLayout();
            this.PanelFolder.ResumeLayout(false);
            this.PanelFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PanelFolder;
        private System.Windows.Forms.RadioButton RadioBFolder;
        private System.Windows.Forms.RadioButton RadioBTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListFolder;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel PanelTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTags;
        private System.Windows.Forms.Button BtnRemoveTags;
        private System.Windows.Forms.ListView listTags;
        private System.Windows.Forms.ColumnHeader ColTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btnBringFirst;
        private System.Windows.Forms.Button btnBringLast;
        private System.Windows.Forms.Button btnBringDown;
        private System.Windows.Forms.Button btnBringUp;
        private System.Windows.Forms.Button btnResetDefault;
        private System.Windows.Forms.Button btnRemTagAll;
    }
}