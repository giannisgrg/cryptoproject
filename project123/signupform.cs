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
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (((string.IsNullOrWhiteSpace(username_txtbx.Text)) || ((string.IsNullOrWhiteSpace(password_txtbx.Text)))))
            {
                MessageBox.Show("One of the fields is empty");
               
            }
            else
            {

                crypto cryptit = new crypto();
                string salt = cryptit.GetSalt(16);
               // cryptit.HashIt(password_txtbx.Text, salt);
                DBConnect conn = new DBConnect();
                conn.signup(username_txtbx.Text, cryptit.HashIt(password_txtbx.Text, salt), salt);
            }
        }
    }
}
