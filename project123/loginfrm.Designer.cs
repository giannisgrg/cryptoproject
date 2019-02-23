namespace project123
{
    partial class loginfrm
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
            this.user_txtbx = new System.Windows.Forms.TextBox();
            this.pwd_txtbx = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.sign_up_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_txtbx
            // 
            this.user_txtbx.Location = new System.Drawing.Point(192, 97);
            this.user_txtbx.Name = "user_txtbx";
            this.user_txtbx.Size = new System.Drawing.Size(198, 20);
            this.user_txtbx.TabIndex = 0;
            // 
            // pwd_txtbx
            // 
            this.pwd_txtbx.Location = new System.Drawing.Point(192, 134);
            this.pwd_txtbx.Name = "pwd_txtbx";
            this.pwd_txtbx.Size = new System.Drawing.Size(198, 20);
            this.pwd_txtbx.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(439, 97);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(112, 57);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(530, 300);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // sign_up_btn
            // 
            this.sign_up_btn.Location = new System.Drawing.Point(224, 196);
            this.sign_up_btn.Name = "sign_up_btn";
            this.sign_up_btn.Size = new System.Drawing.Size(106, 53);
            this.sign_up_btn.TabIndex = 4;
            this.sign_up_btn.Text = "Sign Up";
            this.sign_up_btn.UseVisualStyleBackColor = true;
            this.sign_up_btn.Click += new System.EventHandler(this.sign_up_btn_Click);
            // 
            // loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 335);
            this.Controls.Add(this.sign_up_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwd_txtbx);
            this.Controls.Add(this.user_txtbx);
            this.Name = "loginfrm";
            this.Text = "loginfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_txtbx;
        private System.Windows.Forms.TextBox pwd_txtbx;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button sign_up_btn;
    }
}