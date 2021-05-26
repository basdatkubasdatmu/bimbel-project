
namespace bimbel
{
    partial class FormInputPembayaran
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
            this.lblKode = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtKodeBayar = new System.Windows.Forms.TextBox();
            this.txtKodeKelas = new System.Windows.Forms.TextBox();
            this.textNoSiswa = new System.Windows.Forms.TextBox();
            this.txtJumlahBayar = new System.Windows.Forms.TextBox();
            this.lblinput = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.textNamaSiswa = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lbltgl = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKode.Location = new System.Drawing.Point(33, 61);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(85, 19);
            this.lblKode.TabIndex = 0;
            this.lblKode.Text = "Kode Bayar";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNo.Location = new System.Drawing.Point(33, 101);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(98, 19);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "Nomor Siswa";
            // 
            // txtKodeBayar
            // 
            this.txtKodeBayar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKodeBayar.Location = new System.Drawing.Point(146, 58);
            this.txtKodeBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeBayar.Name = "txtKodeBayar";
            this.txtKodeBayar.Size = new System.Drawing.Size(316, 27);
            this.txtKodeBayar.TabIndex = 6;
            // 
            // txtKodeKelas
            // 
            this.txtKodeKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKodeKelas.Location = new System.Drawing.Point(146, 180);
            this.txtKodeKelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKodeKelas.Name = "txtKodeKelas";
            this.txtKodeKelas.Size = new System.Drawing.Size(316, 27);
            this.txtKodeKelas.TabIndex = 8;
            // 
            // textNoSiswa
            // 
            this.textNoSiswa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNoSiswa.Location = new System.Drawing.Point(146, 98);
            this.textNoSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNoSiswa.Name = "textNoSiswa";
            this.textNoSiswa.Size = new System.Drawing.Size(316, 27);
            this.textNoSiswa.TabIndex = 10;
            this.textNoSiswa.TextChanged += new System.EventHandler(this.textNoSiswa_TextChanged);
            // 
            // txtJumlahBayar
            // 
            this.txtJumlahBayar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJumlahBayar.Location = new System.Drawing.Point(146, 306);
            this.txtJumlahBayar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlahBayar.Name = "txtJumlahBayar";
            this.txtJumlahBayar.Size = new System.Drawing.Size(316, 27);
            this.txtJumlahBayar.TabIndex = 11;
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblinput.Location = new System.Drawing.Point(20, 16);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(201, 29);
            this.lblinput.TabIndex = 12;
            this.lblinput.Text = "Input Pembayaran";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Info;
            this.btnSimpan.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(279, 348);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(88, 41);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.Info;
            this.btnBatal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(373, 348);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(89, 41);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // textNamaSiswa
            // 
            this.textNamaSiswa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNamaSiswa.Location = new System.Drawing.Point(146, 138);
            this.textNamaSiswa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNamaSiswa.Name = "textNamaSiswa";
            this.textNamaSiswa.ReadOnly = true;
            this.textNamaSiswa.Size = new System.Drawing.Size(316, 27);
            this.textNamaSiswa.TabIndex = 9;
            this.textNamaSiswa.TextChanged += new System.EventHandler(this.textNamaSiswa_TextChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstatus.Location = new System.Drawing.Point(33, 268);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(53, 19);
            this.lblstatus.TabIndex = 18;
            this.lblstatus.Text = "Status";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJumlah.Location = new System.Drawing.Point(33, 309);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(100, 19);
            this.lblJumlah.TabIndex = 17;
            this.lblJumlah.Text = "Jumlah Bayar";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKelas.Location = new System.Drawing.Point(33, 183);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(83, 19);
            this.lblKelas.TabIndex = 16;
            this.lblKelas.Text = "Kode Kelas";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNama.Location = new System.Drawing.Point(33, 141);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(90, 19);
            this.lblNama.TabIndex = 15;
            this.lblNama.Text = "Nama Siswa";
            // 
            // lbltgl
            // 
            this.lbltgl.AutoSize = true;
            this.lbltgl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltgl.Location = new System.Drawing.Point(33, 225);
            this.lbltgl.Name = "lbltgl";
            this.lbltgl.Size = new System.Drawing.Size(63, 19);
            this.lbltgl.TabIndex = 20;
            this.lbltgl.Text = "Tanggal";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.Location = new System.Drawing.Point(146, 265);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(316, 27);
            this.txtStatus.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(146, 222);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(316, 27);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // FormInputPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(486, 400);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbltgl);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.txtJumlahBayar);
            this.Controls.Add(this.textNoSiswa);
            this.Controls.Add(this.textNamaSiswa);
            this.Controls.Add(this.txtKodeKelas);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtKodeBayar);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblKode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInputPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jumlah Bayar";
            this.Load += new System.EventHandler(this.FormInputPembayaran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtKodeBayar;
        private System.Windows.Forms.TextBox txtKodeKelas;
        private System.Windows.Forms.TextBox textNoSiswa;
        private System.Windows.Forms.TextBox txtJumlahBayar;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox textNamaSiswa;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lbltgl;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}