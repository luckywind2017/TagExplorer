using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TagExplorer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Type.GetType("Form1_beta") != null && Globals.betaMode)
            {
                Application.Run(new Form1_beta());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
