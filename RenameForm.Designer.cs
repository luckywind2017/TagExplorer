namespace TagExplorer
{
    partial class RenameForm
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
            this.txtFileOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileTags = new System.Windows.Forms.TextBox();
            this.btnRenameOk = new System.Windows.Forms.Button();
            this.btnRenameCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileOriginal
            // 
            this.txtFileOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileOriginal.Location = new System.Drawing.Point(5, 26);
            this.txtFileOriginal.Name = "txtFileOriginal";
            this.txtFileOriginal.Size = new System.Drawing.Size(830, 25);
            this.txtFileOriginal.TabIndex = 0;
            this.txtFileOriginal.TextChanged += new System.EventHandler(this.txtFileOriginal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results";
            // 
            // txtFileResult
            // 
            this.txtFileResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileResult.Location = new System.Drawing.Point(1, 141);
            this.txtFileResult.Name = "txtFileResult";
            this.txtFileResult.ReadOnly = true;
            this.txtFileResult.Size = new System.Drawing.Size(830, 25);
            this.txtFileResult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tags";
            // 
            // txtFileTags
            // 
            this.txtFileTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileTags.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileTags.Location = new System.Drawing.Point(1, 83);
            this.txtFileTags.Name = "txtFileTags";
            this.txtFileTags.ReadOnly = true;
            this.txtFileTags.Size = new System.Drawing.Size(830, 25);
            this.txtFileTags.TabIndex = 4;
            this.txtFileTags.TextChanged += new System.EventHandler(this.txtFileTags_TextChanged);
            // 
            // btnRenameOk
            // 
            this.btnRenameOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenameOk.Location = new System.Drawing.Point(649, 177);
            this.btnRenameOk.Name = "btnRenameOk";
            this.btnRenameOk.Size = new System.Drawing.Size(90, 49);
            this.btnRenameOk.TabIndex = 6;
            this.btnRenameOk.Text = "Rename";
            this.btnRenameOk.UseVisualStyleBackColor = true;
            this.btnRenameOk.Click += new System.EventHandler(this.btnRenameOk_Click);
            // 
            // btnRenameCancel
            // 
            this.btnRenameCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenameCancel.Location = new System.Drawing.Point(745, 177);
            this.btnRenameCancel.Name = "btnRenameCancel";
            this.btnRenameCancel.Size = new System.Drawing.Size(90, 49);
            this.btnRenameCancel.TabIndex = 7;
            this.btnRenameCancel.Text = "Cancel";
            this.btnRenameCancel.UseVisualStyleBackColor = true;
            this.btnRenameCancel.Click += new System.EventHandler(this.btnRenameCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(35, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clear";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(843, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRenameCancel);
            this.Controls.Add(this.btnRenameOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileOriginal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 276);
            this.MinimizeBox = false;
            this.Name = "RenameForm";
            this.ShowIcon = false;
            this.Text = "Rename File with Tags";
            this.Load += new System.EventHandler(this.RenameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileTags;
        private System.Windows.Forms.Button btnRenameOk;
        private System.Windows.Forms.Button btnRenameCancel;
        private System.Windows.Forms.Label label4;
    }
}