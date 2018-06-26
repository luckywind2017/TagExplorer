using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TagExplorer
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void RenameForm_Load(object sender, EventArgs e)
        {
            txtFileOriginal.Text = Globals.currFile.filename;

            List<string> tagArr = new List<string>();
            List<string> tagArrSpecial = new List<string>();
            Regex containsSpecialChar = new Regex("[\\@#!$%^&;]");
            foreach (Tag tagItem in Globals.currFile.tags)
            {
                if (containsSpecialChar.IsMatch(tagItem.text.Substring(0, 1)))
                {
                    tagArrSpecial.Add(tagItem.text);
                }
                else
                {
                    tagArr.Add(tagItem.text);
                }
            }
            if (tagArrSpecial.Count > 0)
            {
                txtFileTags.Text = String.Join("",tagArrSpecial.ToArray()) + " " + String.Join(" ", tagArr.ToArray());
            } else
            {
                txtFileTags.Text = String.Join(" ", tagArr.ToArray());
            }
            updateResult();

        }

        private void btnRenameCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenameOk_Click(object sender, EventArgs e)
        {
            if (!Globals.isValidFileName(txtFileResult.Text)){
                MessageBox.Show("Filename can not contains < > : \" / \\ | ? *","Invalid Filename",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            System.IO.File.Move(Globals.currFile.folder.path + "\\" + Globals.currFile.filename, Globals.currFile.folder.path + "\\" + txtFileResult.Text);
            Globals.currFile.filename = txtFileResult.Text;

            Form1 frm = (Form1)Application.OpenForms["Form1"];
            frm.updateNewFilename();

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtFileTags.Text = "";
        }

        private void txtFileOriginal_TextChanged(object sender, EventArgs e)
        {
            updateResult();
        }

        private void txtFileTags_TextChanged(object sender, EventArgs e)
        {
            updateResult();

        }

        private void updateResult()
        {
            if (txtFileTags.Text != "")
            {
                txtFileResult.Text = txtFileTags.Text + " " + txtFileOriginal.Text;
            }
            else
            {
                txtFileResult.Text = txtFileOriginal.Text;
            }

        }
    }
}
