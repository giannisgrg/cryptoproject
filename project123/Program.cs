using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project123
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
            loginfrm loginfrm = new loginfrm();
            if (loginfrm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new mainform());
            }
            else
            {
               Application.Exit();
            }
        }
    }
}
