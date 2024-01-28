﻿namespace POSWindowsFormsAppWithFramework.UserControls
{
    partial class LoginUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_invalidPassword = new System.Windows.Forms.Label();
            this.lbl_invalidUsername = new System.Windows.Forms.Label();
            this.lbl_textView_Hello = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_invalidPassword
            // 
            this.lbl_invalidPassword.AutoSize = true;
            this.lbl_invalidPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalidPassword.Location = new System.Drawing.Point(605, 385);
            this.lbl_invalidPassword.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_invalidPassword.Name = "lbl_invalidPassword";
            this.lbl_invalidPassword.Size = new System.Drawing.Size(168, 25);
            this.lbl_invalidPassword.TabIndex = 13;
            this.lbl_invalidPassword.Text = "Wrong Password!";
            this.lbl_invalidPassword.Visible = false;
            // 
            // lbl_invalidUsername
            // 
            this.lbl_invalidUsername.AutoSize = true;
            this.lbl_invalidUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invalidUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalidUsername.Location = new System.Drawing.Point(605, 314);
            this.lbl_invalidUsername.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.lbl_invalidUsername.Name = "lbl_invalidUsername";
            this.lbl_invalidUsername.Size = new System.Drawing.Size(174, 25);
            this.lbl_invalidUsername.TabIndex = 12;
            this.lbl_invalidUsername.Text = "Invalid Username !";
            this.lbl_invalidUsername.Visible = false;
            // 
            // lbl_textView_Hello
            // 
            this.lbl_textView_Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textView_Hello.Location = new System.Drawing.Point(216, 135);
            this.lbl_textView_Hello.Name = "lbl_textView_Hello";
            this.lbl_textView_Hello.Size = new System.Drawing.Size(437, 135);
            this.lbl_textView_Hello.TabIndex = 11;
            this.lbl_textView_Hello.Text = "Login";
            this.lbl_textView_Hello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(376, 378);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(223, 30);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(376, 310);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 30);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(261, 313);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(102, 25);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(500, 455);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(376, 455);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Red;
            this.txtResult.Location = new System.Drawing.Point(385, 506);
            this.txtResult.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(84, 20);
            this.txtResult.TabIndex = 16;
            this.txtResult.Text = "txtResult";
            this.txtResult.Visible = false;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbl_invalidPassword);
            this.Controls.Add(this.lbl_invalidUsername);
            this.Controls.Add(this.lbl_textView_Hello);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(875, 599);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_invalidPassword;
        private System.Windows.Forms.Label lbl_invalidUsername;
        private System.Windows.Forms.Label lbl_textView_Hello;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label txtResult;
    }
}
