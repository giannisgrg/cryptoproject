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
    public partial class formforinput : Form
    {
        public formforinput()
        {
            InitializeComponent();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            
            if ((string.IsNullOrWhiteSpace(origin_txtbx.Text)) || (string.IsNullOrWhiteSpace(accname_txtbx.Text)) || (string.IsNullOrWhiteSpace(pass_txtbx.Text)))
            {
                MessageBox.Show("One of the fields is empty");
            }
            else
            {
                DBConnect conn = new DBConnect();
                conn.Insert(origin_txtbx.Text, accname_txtbx.Text, pass_txtbx.Text);
                MessageBox.Show("Account added succesfully");
                this.Close();
                DialogResult = DialogResult.OK;
            }
            
        }
    }
}
