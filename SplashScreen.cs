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
using System.Threading;

namespace TagExplorer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            

            //for (int i = 1; i <= 100; i++)
            //{
            //    // Wait 100 milliseconds.
            //    Thread.Sleep(100);
            //    // Report progress.
            //    //backgroundWorker1.ReportProgress(i);
            //}

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
