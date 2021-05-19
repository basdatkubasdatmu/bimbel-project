
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pwLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.mtxPassword = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(22, 50);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(83, 20);
            this.userName.TabIndex = 7;
            this.userName.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(142, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(208, 23);
            this.txtUsername.TabIndex = 8;
            // 
            // pwLogin
            // 
            this.pwLogin.AutoSize = true;
            this.pwLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwLogin.Location = new System.Drawing.Point(22, 91);
            this.pwLogin.Name = "pwLogin";
            this.pwLogin.Size = new System.Drawing.Size(78, 20);
            this.pwLogin.TabIndex = 9;
            this.pwLogin.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Peran/Tipe";
            // 
            // cbLogin
            // 
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(142, 129);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(208, 23);
            this.cbLogin.TabIndex = 12;
            this.cbLogin.SelectedIndexChanged += new System.EventHandler(this.cbLogin_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(262, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 30);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // mtxPassword
            // 
            this.mtxPassword.Location = new System.Drawing.Point(142, 91);
            this.mtxPassword.Name = "mtxPassword";
            this.mtxPassword.Size = new System.Drawing.Size(208, 23);
            this.mtxPassword.TabIndex = 14;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(388, 211);
            this.Controls.Add(this.mtxPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label pwLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox mtxPassword;
    }
}