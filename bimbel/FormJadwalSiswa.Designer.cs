
namespace bimbel
{
    partial class FormJadwalSiswa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvJadwalSiswa = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDaftarJadwalSiswa = new System.Windows.Forms.Label();
            this.kodeJadwalSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeJadwalPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJadwalSiswa
            // 
            this.dgvJadwalSiswa.AllowUserToAddRows = false;
            this.dgvJadwalSiswa.AllowUserToDeleteRows = false;
            this.dgvJadwalSiswa.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwalSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJadwalSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalSiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeJadwalSiswa,
            this.namaSiswa,
            this.kodeJadwalPengajar});
            this.dgvJadwalSiswa.Location = new System.Drawing.Point(18, 46);
            this.dgvJadwalSiswa.Name = "dgvJadwalSiswa";
            this.dgvJadwalSiswa.RowTemplate.Height = 25;
            this.dgvJadwalSiswa.Size = new System.Drawing.Size(507, 324);
            this.dgvJadwalSiswa.TabIndex = 20;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Info;
            this.btnTambah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(359, 376);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(80, 44);
            this.btnTambah.TabIndex = 19;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(445, 376);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 44);
            this.btnHapus.TabIndex = 18;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(187, 376);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 44);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(273, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 44);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDaftarJadwalSiswa
            // 
            this.lblDaftarJadwalSiswa.AutoSize = true;
            this.lblDaftarJadwalSiswa.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDaftarJadwalSiswa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDaftarJadwalSiswa.Location = new System.Drawing.Point(12, 9);
            this.lblDaftarJadwalSiswa.Name = "lblDaftarJadwalSiswa";
            this.lblDaftarJadwalSiswa.Size = new System.Drawing.Size(246, 33);
            this.lblDaftarJadwalSiswa.TabIndex = 15;
            this.lblDaftarJadwalSiswa.Text = "Daftar Jadwal Siswa";
            // 
            // kodeJadwalSiswa
            // 
            this.kodeJadwalSiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeJadwalSiswa.DataPropertyName = "kodeJadwalSiswa";
            this.kodeJadwalSiswa.HeaderText = "Kode Jadwal Siswa";
            this.kodeJadwalSiswa.Name = "kodeJadwalSiswa";
            this.kodeJadwalSiswa.Width = 147;
            // 
            // namaSiswa
            // 
            this.namaSiswa.DataPropertyName = "namaSiswa";
            this.namaSiswa.HeaderText = "Nama Siswa";
            this.namaSiswa.Name = "namaSiswa";
            // 
            // kodeJadwalPengajar
            // 
            this.kodeJadwalPengajar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeJadwalPengajar.DataPropertyName = "kodeJadwalPengajar";
            this.kodeJadwalPengajar.HeaderText = "Kode Jadwal Pengajar";
            this.kodeJadwalPengajar.Name = "kodeJadwalPengajar";
            this.kodeJadwalPengajar.Width = 167;
            // 
            // FormJadwalSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(543, 430);
            this.Controls.Add(this.dgvJadwalSiswa);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDaftarJadwalSiswa);
            this.MaximizeBox = false;
            this.Name = "FormJadwalSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal Siswa";
            this.Load += new System.EventHandler(this.FormJadwalSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJadwalSiswa;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDaftarJadwalSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeJadwalSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeJadwalPengajar;
    }
}