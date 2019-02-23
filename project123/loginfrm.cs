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
    public partial class loginfrm : Form
    {
        public loginfrm()
        {
            InitializeComponent();
        }

        // login button 
        private void login_btn_Click(object sender, EventArgs e)
        {

            DBConnect conn = new DBConnect();
            crypto cryptit = new crypto();

            string mysalt = conn.Getsalt(user_txtbx.Text);
            string hash = conn.GetHash(user_txtbx.Text);
            string passgiven1 = pwd_txtbx.Text + mysalt; 
            
            if (hash != null)
            {
                if (cryptit.verify(hash, passgiven1))
                {
                    MessageBox.Show("PASS OK");
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Wrong pass");

                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            
            signupform newform = new signupform();

            newform.ShowDialog();
        }
    }
}
