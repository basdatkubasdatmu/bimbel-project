
namespace bimbel
{
    partial class FormInputJadwalUjian
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
            this.lblInputJadwalUjian = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtKodeUjian = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblKodeUjian = new System.Windows.Forms.Label();
            this.lblNamaUjian = new System.Windows.Forms.Label();
            this.lblKodePelajaran = new System.Windows.Forms.Label();
            this.lblTanggalUjian = new System.Windows.Forms.Label();
            this.lblJamMulai = new System.Windows.Forms.Label();
            this.lblDurasi = new System.Windows.Forms.Label();
            this.txtNamaUjian = new System.Windows.Forms.TextBox();
            this.txtKodePelajaran = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblInputJadwalUjian
            // 
            this.lblInputJadwalUjian.AutoSize = true;
            this.lblInputJadwalUjian.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputJadwalUjian.Location = new System.Drawing.Point(13, 9);
            this.lblInputJadwalUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputJadwalUjian.Name = "lblInputJadwalUjian";
            this.lblInputJadwalUjian.Size = new System.Drawing.Size(230, 33);
            this.lblInputJadwalUjian.TabIndex = 1;
            this.lblInputJadwalUjian.Text = "Input Jadwal Ujian";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Info;
            this.btnSimpan.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(309, 307);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 38);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            this.btnSimpan.MouseHover += new System.EventHandler(this.btnSimpan_MouseHover);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.Info;
            this.btnBatal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(225, 307);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 38);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtKodeUjian
            // 
            this.txtKodeUjian.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKodeUjian.Location = new System.Drawing.Point(160, 60);
            this.txtKodeUjian.Margin = new System.Windows.Forms.Padding(4);
            this.txtKodeUjian.MaxLength = 5;
            this.txtKodeUjian.Name = "txtKodeUjian";
            this.txtKodeUjian.Size = new System.Drawing.Size(224, 27);
            this.txtKodeUjian.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(160, 180);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(224, 27);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblKodeUjian
            // 
            this.lblKodeUjian.AutoSize = true;
            this.lblKodeUjian.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKodeUjian.Location = new System.Drawing.Point(15, 63);
            this.lblKodeUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodeUjian.Name = "lblKodeUjian";
            this.lblKodeUjian.Size = new System.Drawing.Size(81, 19);
            this.lblKodeUjian.TabIndex = 6;
            this.lblKodeUjian.Text = "Kode Ujian";
            // 
            // lblNamaUjian
            // 
            this.lblNamaUjian.AutoSize = true;
            this.lblNamaUjian.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNamaUjian.Location = new System.Drawing.Point(15, 103);
            this.lblNamaUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaUjian.Name = "lblNamaUjian";
            this.lblNamaUjian.Size = new System.Drawing.Size(86, 19);
            this.lblNamaUjian.TabIndex = 7;
            this.lblNamaUjian.Text = "Nama Ujian";
            // 
            // lblKodePelajaran
            // 
            this.lblKodePelajaran.AutoSize = true;
            this.lblKodePelajaran.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKodePelajaran.Location = new System.Drawing.Point(15, 143);
            this.lblKodePelajaran.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKodePelajaran.Name = "lblKodePelajaran";
            this.lblKodePelajaran.Size = new System.Drawing.Size(110, 19);
            this.lblKodePelajaran.TabIndex = 8;
            this.lblKodePelajaran.Text = "Kode Pelajaran";
            // 
            // lblTanggalUjian
            // 
            this.lblTanggalUjian.AutoSize = true;
            this.lblTanggalUjian.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTanggalUjian.Location = new System.Drawing.Point(15, 183);
            this.lblTanggalUjian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggalUjian.Name = "lblTanggalUjian";
            this.lblTanggalUjian.Size = new System.Drawing.Size(100, 19);
            this.lblTanggalUjian.TabIndex = 9;
            this.lblTanggalUjian.Text = "Tanggal Ujian";
            // 
            // lblJamMulai
            // 
            this.lblJamMulai.AutoSize = true;
            this.lblJamMulai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJamMulai.Location = new System.Drawing.Point(15, 223);
            this.lblJamMulai.Name = "lblJamMulai";
            this.lblJamMulai.Size = new System.Drawing.Size(78, 19);
            this.lblJamMulai.TabIndex = 10;
            this.lblJamMulai.Text = "Jam Mulai";
            // 
            // lblDurasi
            // 
            this.lblDurasi.AutoSize = true;
            this.lblDurasi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDurasi.Location = new System.Drawing.Point(15, 263);
            this.lblDurasi.Name = "lblDurasi";
            this.lblDurasi.Size = new System.Drawing.Size(52, 19);
            this.lblDurasi.TabIndex = 11;
            this.lblDurasi.Text = "Durasi";
            // 
            // txtNamaUjian
            // 
            this.txtNamaUjian.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNamaUjian.Location = new System.Drawing.Point(160, 99);
            this.txtNamaUjian.MaxLength = 10;
            this.txtNamaUjian.Name = "txtNamaUjian";
            this.txtNamaUjian.Size = new System.Drawing.Size(224, 27);
            this.txtNamaUjian.TabIndex = 12;
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKodePelajaran.Location = new System.Drawing.Point(160, 140);
            this.txtKodePelajaran.MaxLength = 5;
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(224, 27);
            this.txtKodePelajaran.TabIndex = 13;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox2.Location = new System.Drawing.Point(160, 260);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(140, 27);
            this.maskedTextBox2.TabIndex = 14;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "menit";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox3.Location = new System.Drawing.Point(160, 220);
            this.maskedTextBox3.Mask = "90:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(224, 27);
            this.maskedTextBox3.TabIndex = 37;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // FormInputJadwalUjian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(414, 358);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.txtKodePelajaran);
            this.Controls.Add(this.txtNamaUjian);
            this.Controls.Add(this.lblDurasi);
            this.Controls.Add(this.lblJamMulai);
            this.Controls.Add(this.lblTanggalUjian);
            this.Controls.Add(this.lblKodePelajaran);
            this.Controls.Add(this.lblNamaUjian);
            this.Controls.Add(this.lblKodeUjian);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtKodeUjian);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblInputJadwalUjian);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "FormInputJadwalUjian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal Ujian";
            this.Load += new System.EventHandler(this.FormInputJadwalUjian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputJadwalUjian;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtKodeUjian;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblKodeUjian;
        private System.Windows.Forms.Label lblNamaUjian;
        private System.Windows.Forms.Label lblKodePelajaran;
        private System.Windows.Forms.Label lblTanggalUjian;
        private System.Windows.Forms.Label lblJamMulai;
        private System.Windows.Forms.Label lblDurasi;
        private System.Windows.Forms.TextBox txtNamaUjian;
        private System.Windows.Forms.TextBox txtKodePelajaran;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}