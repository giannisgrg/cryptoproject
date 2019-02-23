namespace project123
{
    partial class formforinput
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
            this.origin_txtbx = new System.Windows.Forms.TextBox();
            this.accname_txtbx = new System.Windows.Forms.TextBox();
            this.pass_txtbx = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // origin_txtbx
            // 
            this.origin_txtbx.Location = new System.Drawing.Point(219, 102);
            this.origin_txtbx.Name = "origin_txtbx";
            this.origin_txtbx.Size = new System.Drawing.Size(100, 20);
            this.origin_txtbx.TabIndex = 0;
            // 
            // accname_txtbx
            // 
            this.accname_txtbx.Location = new System.Drawing.Point(219, 152);
            this.accname_txtbx.Name = "accname_txtbx";
            this.accname_txtbx.Size = new System.Drawing.Size(100, 20);
            this.accname_txtbx.TabIndex = 1;
            // 
            // pass_txtbx
            // 
            this.pass_txtbx.Location = new System.Drawing.Point(219, 209);
            this.pass_txtbx.Name = "pass_txtbx";
            this.pass_txtbx.Size = new System.Drawing.Size(100, 20);
            this.pass_txtbx.TabIndex = 2;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(388, 102);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(121, 127);
            this.submit_btn.TabIndex = 3;
            this.submit_btn.Text = "submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(583, 298);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "origin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "account name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "password";
            // 
            // formforinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.pass_txtbx);
            this.Controls.Add(this.accname_txtbx);
            this.Controls.Add(this.origin_txtbx);
            this.Name = "formforinput";
            this.Text = "formforinput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox origin_txtbx;
        private System.Windows.Forms.TextBox accname_txtbx;
        private System.Windows.Forms.TextBox pass_txtbx;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}