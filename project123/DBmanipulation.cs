using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static project123.passkeeper;
using static project123.filekeeper;

namespace project123 {

    class DBConnect 
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

            

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "projectdb";
            uid = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Check credentials
        public bool checklogin(string loc_user, string loc_pass)
        {
            int x = 0;
            string query = "SELECT * FROM accounts WHERE username = '" + loc_user + "' AND password = '" + loc_pass + "'";
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows) x = 1;


                //Execute command


                //close connection
                this.CloseConnection();

            }
            if (x == 0)
            {
                return false;
            }
            return true;
        }

        // fill a list with database
        public List<_accountsofuser> fillListFromDB()
        {

            string query = "SELECT * FROM passkeeper_db";
            List<_accountsofuser> loc_lista = new List<_accountsofuser>();

            if (this.OpenConnection() == true)
            {


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    loc_lista.Add(createaccount(dataReader.GetInt32("idpasskeeper_db"),
                                            dataReader.GetString("account_name"),
                                            dataReader.GetString("account_origin"),
                                            dataReader.GetString("account_password")));
                }
                CloseConnection();
                return loc_lista;

            }
            else
                return loc_lista;
        }

        //fill filekeeper list
        public List<myfile> fillFilekeeper()
        {
            string query = "SELECT * FROM filekeeper_db";
            List<myfile> loc_lista = new List<myfile>();

            if (this.OpenConnection() == true)
            {


                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    loc_lista.Add(Createfile(dataReader.GetInt32("idfilekeeper_db"),
                                            dataReader.GetString("file_name"),
                                            dataReader.GetString("date_saved")));

                }
                CloseConnection();
                return loc_lista;

            }
            else
                return loc_lista;
        }
        //getsalt
        public string Getsalt(string loc_user)
        {
            string salt = null;
            string query = "SELECT salt FROM accounts WHERE username = '" + loc_user + "'";
            if (this.OpenConnection() == true)
            {
                
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    salt = rd["salt"].ToString();
                }
                this.CloseConnection();

            }
            return salt;
        }

        //get stored hash
        public string GetHash(string loc_user)
        {
            string hash = null;
            string query = "SELECT password FROM accounts WHERE username =@username";
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", loc_user);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    hash = rd["password"].ToString();
                }
                this.CloseConnection();

            }
            return hash;
        }


        // signup new user
        public void signup(string username, string pass, string salt)
        {
            
            string query = "INSERT INTO accounts (username, password, salt) VALUES(@username,@password,@salt)";


            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("@salt", salt);
                //Execute command
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created");
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //close connection
                this.CloseConnection();
            }
        }

        // insert file in db
        public void InsertFile(myfile enc_file)
        {
            string query = "INSERT INTO filekeeper_db (file_name,file_data, date_saved, salt) VALUES(@file_name,@file_data,@date_saved, @salt)";
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);                
                cmd.Parameters.AddWithValue("@file_name", enc_file.File_name);
                cmd.Parameters.AddWithValue("@date_saved", enc_file.File_date);
               
                cmd.Parameters.AddWithValue("@file_data", enc_file.File_data);
                cmd.Parameters.AddWithValue("@salt", enc_file.salt);


                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Insert account in passkeeper statement
        public void Insert(string loc_origin,string loc_name,string loc_pass)
        {
            string query = "INSERT INTO passkeeper_db (account_name,account_origin,account_password) VALUES(@name,@origin,@password)";


            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", loc_name);
                cmd.Parameters.AddWithValue("@origin", loc_origin);
                cmd.Parameters.AddWithValue("@password", loc_pass);
                //Execute command
                try
                {
                    cmd.ExecuteNonQuery();
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //close connection
                this.CloseConnection();
            }
        }

        // get file from db
        public myfile getFile(int loc_id)
        {
            myfile loc_file = new myfile();
     
            string query = "SELECT * FROM filekeeper_db WHERE idfilekeeper_db = @id";
           
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", loc_id);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    loc_file.File_name = rd.GetString("file_name");
                    loc_file.salt =  (byte[])rd["salt"];
                    loc_file.File_date = rd.GetString("date_saved");
                    loc_file.File_data = (byte[])rd["file_data"];
             

                }
                this.CloseConnection();
                return loc_file;
            }
            return loc_file;
        }
        //Update statement
        public void dbUpdate()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement for passkeeper records
        public void DeleteRecordPasskeeper(int id)
        {
            string query = "DELETE FROM passkeeper_db WHERE (idpasskeeper_db=@id) ";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("okok");
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] dbSelect()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!\n"+ex);
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!"+ex);
            }
        }
    }
}