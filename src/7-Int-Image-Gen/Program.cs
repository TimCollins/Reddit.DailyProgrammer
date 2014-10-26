using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// See http://www.reddit.com/r/dailyprogrammer/comments/pr265/2152012_challenge_7_intermediate/
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
