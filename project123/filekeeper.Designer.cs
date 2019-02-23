namespace project123
{
    partial class filekeeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filekeeper));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.refresh_btn = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.enc_btn = new System.Windows.Forms.Button();
            this.checkbox_savelocal = new System.Windows.Forms.CheckBox();
            this.checkBox_savedb = new System.Windows.Forms.CheckBox();
            this.dec_btn = new System.Windows.Forms.Button();
            this.dec_fromdb_radio = new System.Windows.Forms.RadioButton();
            this.dec_file_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn,
            this.filedateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.myfileBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(800, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "File_name";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "File_name";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // filedateDataGridViewTextBoxColumn
            // 
            this.filedateDataGridViewTextBoxColumn.DataPropertyName = "File_date";
            this.filedateDataGridViewTextBoxColumn.HeaderText = "File_date";
            this.filedateDataGridViewTextBoxColumn.Name = "filedateDataGridViewTextBoxColumn";
            // 
            // myfileBindingSource
            // 
            this.myfileBindingSource.DataSource = typeof(project123.filekeeper.myfile);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(47, 22);
            this.refresh_btn.Text = "refresh";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.refresh_btn});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(181, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(384, 42);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = " Below are your saved files!";
            // 
            // enc_btn
            // 
            this.enc_btn.Enabled = false;
            this.enc_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enc_btn.Location = new System.Drawing.Point(40, 314);
            this.enc_btn.Name = "enc_btn";
            this.enc_btn.Size = new System.Drawing.Size(140, 50);
            this.enc_btn.TabIndex = 3;
            this.enc_btn.Text = "ENCRYPT";
            this.enc_btn.UseVisualStyleBackColor = true;
            this.enc_btn.Click += new System.EventHandler(this.enc_btn_Click_1);
            // 
            // checkbox_savelocal
            // 
            this.checkbox_savelocal.AutoSize = true;
            this.checkbox_savelocal.Location = new System.Drawing.Point(216, 314);
            this.checkbox_savelocal.Name = "checkbox_savelocal";
            this.checkbox_savelocal.Size = new System.Drawing.Size(87, 17);
            this.checkbox_savelocal.TabIndex = 4;
            this.checkbox_savelocal.Text = "Save Locally";
            this.checkbox_savelocal.UseVisualStyleBackColor = true;
            this.checkbox_savelocal.CheckStateChanged += new System.EventHandler(this.checkbox_savelocal_CheckStateChanged);
            // 
            // checkBox_savedb
            // 
            this.checkBox_savedb.AutoSize = true;
            this.checkBox_savedb.Location = new System.Drawing.Point(216, 346);
            this.checkBox_savedb.Name = "checkBox_savedb";
            this.checkBox_savedb.Size = new System.Drawing.Size(109, 17);
            this.checkBox_savedb.TabIndex = 5;
            this.checkBox_savedb.Text = "Save in database";
            this.checkBox_savedb.UseVisualStyleBackColor = true;
            this.checkBox_savedb.CheckStateChanged += new System.EventHandler(this.checkBox_savedb_CheckStateChanged);
            // 
            // dec_btn
            // 
            this.dec_btn.Enabled = false;
            this.dec_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_btn.Location = new System.Drawing.Point(474, 314);
            this.dec_btn.Name = "dec_btn";
            this.dec_btn.Size = new System.Drawing.Size(126, 49);
            this.dec_btn.TabIndex = 6;
            this.dec_btn.Text = "DECRYPT";
            this.dec_btn.UseVisualStyleBackColor = true;
            this.dec_btn.Click += new System.EventHandler(this.dec_btn_Click_1);
            // 
            // dec_fromdb_radio
            // 
            this.dec_fromdb_radio.AutoSize = true;
            this.dec_fromdb_radio.Location = new System.Drawing.Point(625, 347);
            this.dec_fromdb_radio.Name = "dec_fromdb_radio";
            this.dec_fromdb_radio.Size = new System.Drawing.Size(175, 17);
            this.dec_fromdb_radio.TabIndex = 7;
            this.dec_fromdb_radio.TabStop = true;
            this.dec_fromdb_radio.Text = "Decrypt selected from database";
            this.dec_fromdb_radio.UseVisualStyleBackColor = true;
            this.dec_fromdb_radio.CheckedChanged += new System.EventHandler(this.dec_fromdb_radio_CheckedChanged);
            // 
            // dec_file_radio
            // 
            this.dec_file_radio.AutoSize = true;
            this.dec_file_radio.Location = new System.Drawing.Point(625, 313);
            this.dec_file_radio.Name = "dec_file_radio";
            this.dec_file_radio.Size = new System.Drawing.Size(118, 17);
            this.dec_file_radio.TabIndex = 8;
            this.dec_file_radio.TabStop = true;
            this.dec_file_radio.Text = "Decrypt external file";
            this.dec_file_radio.UseVisualStyleBackColor = true;
            this.dec_file_radio.CheckedChanged += new System.EventHandler(this.dec_file_radio_CheckedChanged);
            // 
            // filekeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dec_file_radio);
            this.Controls.Add(this.dec_fromdb_radio);
            this.Controls.Add(this.dec_btn);
            this.Controls.Add(this.checkBox_savedb);
            this.Controls.Add(this.checkbox_savelocal);
            this.Controls.Add(this.enc_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "filekeeper";
            this.Text = "filekeeper";
            this.Load += new System.EventHandler(this.filekeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
  
        private System.Windows.Forms.BindingSource filekeeperdbBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton refresh_btn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource myfileBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button enc_btn;
        private System.Windows.Forms.CheckBox checkbox_savelocal;
        private System.Windows.Forms.CheckBox checkBox_savedb;
        private System.Windows.Forms.Button dec_btn;
        private System.Windows.Forms.RadioButton dec_fromdb_radio;
        private System.Windows.Forms.RadioButton dec_file_radio;
    }
}