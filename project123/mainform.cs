using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project123
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
       


        private void passkeeper_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            passkeeper passkeeperform = new passkeeper();
            passkeeperform.Show();
            passkeeperform.FormClosing += passkeeperform_closing;
            
        }
        private void passkeeperform_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void filekeeper_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            filekeeper filekeeperform = new filekeeper();
            filekeeperform.Show();
            filekeeperform.FormClosing += filekeeperform_closing;
        }

        private void filekeeperform_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
