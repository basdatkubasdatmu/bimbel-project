
namespace bimbel
{
    partial class FormInputPresensi
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
            this.lblInputPresensiSiswa = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPresensi = new System.Windows.Forms.DateTimePicker();
            this.txtkodeJadwalSiswa = new System.Windows.Forms.TextBox();
            this.txtNamaSiswa = new System.Windows.Forms.TextBox();
            this.txtNoSiswa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInputPresensiSiswa
            // 
            this.lblInputPresensiSiswa.AutoSize = true;

            this.lblInputPresensiSiswa.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputPresensiSiswa.Location = new System.Drawing.Point(37, 9);
            this.lblInputPresensiSiswa.Name = "lblInputPresensiSiswa";
            this.lblInputPresensiSiswa.Size = new System.Drawing.Size(223, 29);

            this.lblInputPresensiSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputPresensiSiswa.Location = new System.Drawing.Point(37, 9);
            this.lblInputPresensiSiswa.Name = "lblInputPresensiSiswa";
            this.lblInputPresensiSiswa.Size = new System.Drawing.Size(257, 29);
            this.lblInputPresensiSiswa.TabIndex = 1;
            this.lblInputPresensiSiswa.Text = "Input Presensi Siswa";
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBatal.Location = new System.Drawing.Point(136, 300);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(74, 39);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(225, 300);
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimpan.Location = new System.Drawing.Point(216, 301);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(83, 39);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode Jadwal Siswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Siswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama Siswa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Waktu Kehadiran";
            // 
            // dtpPresensi
            // 
            this.dtpPresensi.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPresensi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpPresensi.Location = new System.Drawing.Point(37, 259);
            this.dtpPresensi.Name = "dtpPresensi";
            this.dtpPresensi.Size = new System.Drawing.Size(262, 27);
            this.dtpPresensi.TabIndex = 10;
            this.dtpPresensi.Value = new System.DateTime(2021, 5, 17, 20, 44, 13, 0);
            this.dtpPresensi.ValueChanged += new System.EventHandler(this.dtpPresensi_ValueChanged);
            // 
            // txtkodeJadwalSiswa
            // 
            this.txtkodeJadwalSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtkodeJadwalSiswa.Location = new System.Drawing.Point(37, 76);
            this.txtkodeJadwalSiswa.Name = "txtkodeJadwalSiswa";
            this.txtkodeJadwalSiswa.Size = new System.Drawing.Size(262, 26);
            this.txtkodeJadwalSiswa.TabIndex = 11;
            // 
            // txtNamaSiswa
            // 
            this.txtNamaSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNamaSiswa.Location = new System.Drawing.Point(37, 198);
            this.txtNamaSiswa.Name = "txtNamaSiswa";
            this.txtNamaSiswa.Size = new System.Drawing.Size(262, 26);
            this.txtNamaSiswa.TabIndex = 12;
            // 
            // txtNoSiswa
            // 
            this.txtNoSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNoSiswa.Location = new System.Drawing.Point(37, 137);
            this.txtNoSiswa.Name = "txtNoSiswa";
            this.txtNoSiswa.Size = new System.Drawing.Size(262, 26);
            this.txtNoSiswa.TabIndex = 13;
            // 
            // FormInputPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 352);
            this.Controls.Add(this.txtNoSiswa);
            this.Controls.Add(this.txtNamaSiswa);
            this.Controls.Add(this.txtkodeJadwalSiswa);
            this.Controls.Add(this.dtpPresensi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblInputPresensiSiswa);
            this.MaximizeBox = false;
            this.Name = "FormInputPresensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Presensi";
            this.Load += new System.EventHandler(this.FormInputPresensi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputPresensiSiswa;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPresensi;
        private System.Windows.Forms.TextBox txtkodeJadwalSiswa;
        private System.Windows.Forms.TextBox txtNamaSiswa;
        private System.Windows.Forms.TextBox txtNoSiswa;
    }
}