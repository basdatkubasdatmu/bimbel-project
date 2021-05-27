
namespace bimbel
{
    partial class FormLogin
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
            this.btnLoginSiswa = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.userName = new System.Windows.Forms.Label();
            this.pwLogin = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginPegawai = new System.Windows.Forms.Button();
            this.txtPasswordPgw = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsernamePgw = new System.Windows.Forms.TextBox();
            this.login.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginSiswa
            // 
            this.btnLoginSiswa.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoginSiswa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoginSiswa.Location = new System.Drawing.Point(270, 212);
            this.btnLoginSiswa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginSiswa.Name = "btnLoginSiswa";
            this.btnLoginSiswa.Size = new System.Drawing.Size(101, 45);
            this.btnLoginSiswa.TabIndex = 13;
            this.btnLoginSiswa.Text = "Login";
            this.btnLoginSiswa.UseVisualStyleBackColor = false;
            this.btnLoginSiswa.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // login
            // 
            this.login.AccessibleName = "Siswa";
            this.login.Controls.Add(this.tabPage1);
            this.login.Controls.Add(this.tabPage2);
            this.login.Location = new System.Drawing.Point(1, -1);
            this.login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.Name = "login";
            this.login.SelectedIndex = 0;
            this.login.Size = new System.Drawing.Size(422, 321);
            this.login.TabIndex = 15;
            this.login.Tag = "";
            this.login.SelectedIndexChanged += new System.EventHandler(this.siswa_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnLoginSiswa);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.userName);
            this.tabPage1.Controls.Add(this.pwLogin);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(414, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Siswa";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(133, 145);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 32);
            this.txtPassword.TabIndex = 14;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(39, 87);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(96, 24);
            this.userName.TabIndex = 7;
            this.userName.Text = "Username";
            // 
            // pwLogin
            // 
            this.pwLogin.AutoSize = true;
            this.pwLogin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwLogin.Location = new System.Drawing.Point(39, 149);
            this.pwLogin.Name = "pwLogin";
            this.pwLogin.Size = new System.Drawing.Size(91, 24);
            this.pwLogin.TabIndex = 9;
            this.pwLogin.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(133, 83);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(237, 32);
            this.txtUsername.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Lavender;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnLoginPegawai);
            this.tabPage2.Controls.Add(this.txtPasswordPgw);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtUsernamePgw);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(414, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pegawai/Pengajar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "Login";
            // 
            // btnLoginPegawai
            // 
            this.btnLoginPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoginPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginPegawai.Location = new System.Drawing.Point(273, 217);
            this.btnLoginPegawai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoginPegawai.Name = "btnLoginPegawai";
            this.btnLoginPegawai.Size = new System.Drawing.Size(101, 40);
            this.btnLoginPegawai.TabIndex = 19;
            this.btnLoginPegawai.Text = "Login";
            this.btnLoginPegawai.UseVisualStyleBackColor = false;
            this.btnLoginPegawai.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPasswordPgw
            // 
            this.txtPasswordPgw.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordPgw.Location = new System.Drawing.Point(136, 145);
            this.txtPasswordPgw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordPgw.Name = "txtPasswordPgw";
            this.txtPasswordPgw.Size = new System.Drawing.Size(237, 32);
            this.txtPasswordPgw.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // txtUsernamePgw
            // 
            this.txtUsernamePgw.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsernamePgw.Location = new System.Drawing.Point(136, 83);
            this.txtUsernamePgw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsernamePgw.Name = "txtUsernamePgw";
            this.txtUsernamePgw.Size = new System.Drawing.Size(237, 32);
            this.txtUsernamePgw.TabIndex = 17;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(422, 319);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.login.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoginSiswa;
        private System.Windows.Forms.TabControl login;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label pwLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoginPegawai;
        private System.Windows.Forms.MaskedTextBox txtPasswordPgw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsernamePgw;
    }
}