namespace project123
{
    partial class mainform
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
            this.header_label = new System.Windows.Forms.RichTextBox();
            this.passkeeper_btn = new System.Windows.Forms.Button();
            this.filekeeper_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header_label
            // 
            this.header_label.BackColor = System.Drawing.Color.Silver;
            this.header_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(170, 63);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(331, 30);
            this.header_label.TabIndex = 1;
            this.header_label.Text = "Welcome To Your Safe Box!!!";
            // 
            // passkeeper_btn
            // 
            this.passkeeper_btn.Location = new System.Drawing.Point(68, 132);
            this.passkeeper_btn.Name = "passkeeper_btn";
            this.passkeeper_btn.Size = new System.Drawing.Size(118, 102);
            this.passkeeper_btn.TabIndex = 2;
            this.passkeeper_btn.Text = "Password Keeper";
            this.passkeeper_btn.UseVisualStyleBackColor = true;
            this.passkeeper_btn.Click += new System.EventHandler(this.passkeeper_btn_Click);
            // 
            // filekeeper_btn
            // 
            this.filekeeper_btn.Location = new System.Drawing.Point(508, 132);
            this.filekeeper_btn.Name = "filekeeper_btn";
            this.filekeeper_btn.Size = new System.Drawing.Size(114, 102);
            this.filekeeper_btn.TabIndex = 3;
            this.filekeeper_btn.Text = "File Keeper";
            this.filekeeper_btn.UseVisualStyleBackColor = true;
            this.filekeeper_btn.Click += new System.EventHandler(this.filekeeper_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(306, 277);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 32);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 372);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.filekeeper_btn);
            this.Controls.Add(this.passkeeper_btn);
            this.Controls.Add(this.header_label);
            this.Name = "mainform";
            this.Text = "mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox header_label;
        private System.Windows.Forms.Button passkeeper_btn;
        private System.Windows.Forms.Button filekeeper_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}

