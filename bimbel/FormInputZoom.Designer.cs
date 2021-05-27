
namespace bimbel
{
    partial class FormInputZoom
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
            this.lblinput = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblKode = new System.Windows.Forms.Label();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.lblpasscode = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblinput.Location = new System.Drawing.Point(12, 9);
            this.lblinput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(230, 33);
            this.lblinput.TabIndex = 34;
            this.lblinput.Text = "Input Ruang Zoom";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(32, 157);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 19);
            this.lblID.TabIndex = 49;
            this.lblID.Text = "Meeting ID";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtid.Location = new System.Drawing.Point(195, 154);
            this.txtid.Margin = new System.Windows.Forms.Padding(5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(243, 27);
            this.txtid.TabIndex = 48;
            // 
            // txtlink
            // 
            this.txtlink.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtlink.Location = new System.Drawing.Point(195, 106);
            this.txtlink.Margin = new System.Windows.Forms.Padding(4);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(243, 27);
            this.txtlink.TabIndex = 47;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLink.Location = new System.Drawing.Point(32, 109);
            this.lblLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(37, 19);
            this.lblLink.TabIndex = 46;
            this.lblLink.Text = "Link";
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKode.Location = new System.Drawing.Point(32, 62);
            this.lblKode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(86, 19);
            this.lblKode.TabIndex = 45;
            this.lblKode.Text = "Kode Zoom";
            // 
            // txtkode
            // 
            this.txtkode.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtkode.Location = new System.Drawing.Point(195, 59);
            this.txtkode.Margin = new System.Windows.Forms.Padding(5);
            this.txtkode.MaxLength = 5;
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(243, 27);
            this.txtkode.TabIndex = 44;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.Info;
            this.btnBatal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(240, 253);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 46);
            this.btnBatal.TabIndex = 43;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Info;
            this.btnSimpan.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(344, 253);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(94, 46);
            this.btnSimpan.TabIndex = 42;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // lblpasscode
            // 
            this.lblpasscode.AutoSize = true;
            this.lblpasscode.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblpasscode.Location = new System.Drawing.Point(32, 208);
            this.lblpasscode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblpasscode.Name = "lblpasscode";
            this.lblpasscode.Size = new System.Drawing.Size(73, 19);
            this.lblpasscode.TabIndex = 51;
            this.lblpasscode.Text = "Passcode";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpass.Location = new System.Drawing.Point(195, 205);
            this.txtpass.Margin = new System.Windows.Forms.Padding(5);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(243, 27);
            this.txtpass.TabIndex = 50;
            // 
            // FormInputZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(475, 318);
            this.Controls.Add(this.lblpasscode);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblKode);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblinput);
            this.Name = "FormInputZoom";
            this.Text = "FormInputZoom";
            this.Load += new System.EventHandler(this.FormInputZoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label lblpasscode;
        private System.Windows.Forms.TextBox txtpass;
    }
}