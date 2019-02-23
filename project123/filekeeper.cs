using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project123
{
    public partial class filekeeper : Form
    {
        public filekeeper()
        {
            InitializeComponent();
         

        }
        private static readonly byte[] SALT = new byte[] { 0x26, 0xdc, 0xff, 0x00, 0xad, 0xed, 0x7a, 0xee, 0xc5, 0xfe, 0x07, 0xaf, 0x4d, 0x08, 0x22, 0x3c };

        public byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }
            return data;
        }

        public class myfile
        {
            public int Id { get; set; }
            public string File_name { get; set; }
            public string File_date { get; set; }
            public byte[] File_data { get; set; }
            public byte[] salt { get; set; }

        }


        public static myfile Createfile(int id, string file_name, string file_date)
        {
            return new myfile() { Id = id, File_name = file_name, File_date = file_date };
        }

        public static myfile Createfile(int id, string file_name, string file_date, byte[] file_data)
        {
            return new myfile() { Id = id, File_name = file_name, File_date = file_date, File_data = file_data };
        }

        public static myfile Createfile(string file_name, string file_date, byte[] file_data)
        {
            return new myfile() { File_name = file_name, File_date = file_date, File_data = file_data };
        }



        private void filekeeper_Load(object sender, EventArgs e)
        {

            DBConnect conn = new DBConnect();
            List<myfile> lista = conn.fillFilekeeper();

            dataGridView2.DataSource = lista;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            List<myfile> lista = conn.fillFilekeeper();

            dataGridView2.DataSource = lista;
        }

     
     

        private void dec_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
              //  byte[] salt = new byte[32];

                FileStream fsCrypt = new FileStream(openFileDialog2.FileName, FileMode.Open);
           //     fsCrypt.Read(salt, 0, salt.Length);
                fsCrypt.Dispose();
                myfile enc_loc_file = new myfile();
                enc_loc_file.File_name = openFileDialog2.SafeFileName;
                enc_loc_file.File_date = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
                
                enc_loc_file.File_data = File.ReadAllBytes(openFileDialog2.FileName);

                crypto cryptit = new crypto();
                byte[] decrypted = cryptit.Decrypt(enc_loc_file.File_data,"asdf",SALT);

                SaveFileDialog sf1 = new SaveFileDialog();
                sf1.ShowDialog();
                FileStream fsOut = new FileStream(sf1.FileName, FileMode.Create);
                fsOut.Write(decrypted,0,decrypted.Length);
                fsOut.Close();
            }
        }

        private void checkbox_savelocal_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkbox_savelocal.Checked == true)
            {
                enc_btn.Enabled = true;
                checkBox_savedb.Checked = false;
            }
            else
            {
                if(checkBox_savedb.Checked == false )
                {
                    enc_btn.Enabled = false;
                }
            }

        }

        private void checkBox_savedb_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox_savedb.Checked == true)
            {
                enc_btn.Enabled = true;
                checkbox_savelocal.Checked = false;
            }
            else
            {
                if(checkbox_savelocal.Checked == false)
                {
                    enc_btn.Enabled = false;
                }
            }
        }

        private void enc_btn_Click_1(object sender, EventArgs e)
        {
            if (checkbox_savelocal.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string password = "asdf";
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    Encryptions.AESEncryptFile(openFileDialog1.FileName, passwordBytes);

                    Array.Clear(passwordBytes, 0, passwordBytes.Length); 
                    Array.Resize(ref passwordBytes, 1); 
                    passwordBytes = null;
                }
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string password = "asdf";
                    byte[] salt = Encryptions.RandomByteArray(16);
                    myfile loc_file = new myfile();
                    loc_file.File_name = openFileDialog1.SafeFileName;
                    loc_file.File_date = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:sszzz");
                    loc_file.salt = salt;
                    byte[] temporary_fileData= File.ReadAllBytes(openFileDialog1.FileName);
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                  
                    loc_file.File_data = Encryptions.AESEncryptBytes(temporary_fileData, passwordBytes,salt);
                    DBConnect conn = new DBConnect();
                    conn.InsertFile(loc_file);

                }
            } 
        }

        private void dec_fromdb_radio_CheckedChanged(object sender, EventArgs e)
        {
            dec_btn.Enabled = true;
        }

        private void dec_file_radio_CheckedChanged(object sender, EventArgs e)
        {
            dec_btn.Enabled = true;
        }

        private void dec_btn_Click_1(object sender, EventArgs e)
        {
          

            if (dec_file_radio.Checked == true)
                
            {
                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {

                    string password = "asdf";
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    Encryptions.AESDecryptFile(openFileDialog2.FileName,passwordBytes);
                }
            }
            else
            {
                int id = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);

                DBConnect conn = new DBConnect();

                myfile loc_enc_file = new myfile();
                loc_enc_file = conn.getFile(id);

                string password = "asdf";
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                myfile unenc_file = loc_enc_file;
               unenc_file.File_data =  Encryptions.AESDecryptBytes(loc_enc_file.File_data,passwordBytes,loc_enc_file.salt);
                SaveFileDialog sf = new SaveFileDialog();
               if( sf.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(sf.FileName,FileMode.Create);
                    fs.Write(unenc_file.File_data,0,unenc_file.File_data.Length);
                    fs.Close();
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }

    // save an encrypted file

    /* public void saveFile(myfile encrypted_loc_file, byte[] iv)
         {

             if (saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 // FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew);
                 File.WriteAllBytes(saveFileDialog1.FileName, encrypted_loc_file.File_data);
                 DBConnect conn = new DBConnect();
                 conn.InsertFile(encrypted_loc_file, iv);

             }
         }
         */


}

