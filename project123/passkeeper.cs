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
    public partial class passkeeper : Form
    {
        public passkeeper()
        {
            InitializeComponent();
        }

        public class _accountsofuser 
        {
            public int _id { get; set; }
            public string _accountname { get; set; }
            public string _password { get; set; }
            public string _account_origin { get; set; }

        }
        public static _accountsofuser createaccount(int id, string acc_name, string acc_origin, string acc_pass)
        {
            return new _accountsofuser() { _id = id, _accountname = acc_name, _account_origin = acc_origin, _password = acc_pass };
        }

        

        private void passkeeper_Load(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            List<_accountsofuser> lista = conn.fillListFromDB();

            dataGridView1.DataSource = lista;
           
           

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            List<_accountsofuser> lista = conn.fillListFromDB();
            dataGridView1.DataSource = lista;
          
        }

        private void addacc_btn_Click(object sender, EventArgs e)
        {
            formforinput newform = new formforinput();
            newform.ShowDialog();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int loc_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DBConnect conn = new DBConnect();
            conn.DeleteRecordPasskeeper(loc_id);
        }
    }
}
