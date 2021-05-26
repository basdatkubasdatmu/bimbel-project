
namespace bimbel
{
    partial class formDatasiswa
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
            this.dgvSiswa = new System.Windows.Forms.DataGridView();
            this.lblDatasiswa = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.noSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalDaerah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiswa
            // 
            this.dgvSiswa.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noSiswa,
            this.nama,
            this.jenisKelamin,
            this.kodeKelas,
            this.noHP,
            this.email,
            this.asalDaerah});
            this.dgvSiswa.Location = new System.Drawing.Point(21, 48);
            this.dgvSiswa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.RowTemplate.Height = 25;
            this.dgvSiswa.Size = new System.Drawing.Size(671, 334);
            this.dgvSiswa.TabIndex = 0;
            // 
            // lblDatasiswa
            // 
            this.lblDatasiswa.AutoSize = true;
            this.lblDatasiswa.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatasiswa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDatasiswa.Location = new System.Drawing.Point(15, 11);
            this.lblDatasiswa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatasiswa.Name = "lblDatasiswa";
            this.lblDatasiswa.Size = new System.Drawing.Size(81, 33);
            this.lblDatasiswa.TabIndex = 1;
            this.lblDatasiswa.Text = "Siswa";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Info;
            this.btnTambah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(520, 390);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(82, 43);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(610, 390);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(82, 43);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(340, 390);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 43);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(430, 390);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(82, 43);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // noSiswa
            // 
            this.noSiswa.DataPropertyName = "noSiswa";
            this.noSiswa.HeaderText = "Nomor Siswa";
            this.noSiswa.Name = "noSiswa";
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Siswa";
            this.nama.Name = "nama";
            // 
            // jenisKelamin
            // 
            this.jenisKelamin.DataPropertyName = "jenisKelamin";
            this.jenisKelamin.HeaderText = "Jenis Kelamin";
            this.jenisKelamin.Name = "jenisKelamin";
            // 
            // kodeKelas
            // 
            this.kodeKelas.DataPropertyName = "kodeKelas";
            this.kodeKelas.HeaderText = "Kode Kelas";
            this.kodeKelas.Name = "kodeKelas";
            // 
            // noHP
            // 
            this.noHP.DataPropertyName = "noHP";
            this.noHP.HeaderText = "No HP";
            this.noHP.Name = "noHP";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // asalDaerah
            // 
            this.asalDaerah.DataPropertyName = "asalDaerah";
            this.asalDaerah.HeaderText = "Asal Daerah";
            this.asalDaerah.Name = "asalDaerah";
            // 
            // formDatasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(708, 446);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDatasiswa);
            this.Controls.Add(this.dgvSiswa);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "formDatasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siswa";
            this.Load += new System.EventHandler(this.formDatasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiswa;
        private System.Windows.Forms.Label lblDatasiswa;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalDaerah;
    }
}