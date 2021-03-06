
namespace bimbel
{
    partial class FormJadwalPengajar
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
            this.dgvJadwalPengajar = new System.Windows.Forms.DataGridView();
            this.kodeJadwalPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeZoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDaftarJadwalPengajar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPengajar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJadwalPengajar
            // 
            this.dgvJadwalPengajar.AllowUserToAddRows = false;
            this.dgvJadwalPengajar.AllowUserToDeleteRows = false;
            this.dgvJadwalPengajar.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJadwalPengajar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJadwalPengajar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalPengajar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeJadwalPengajar,
            this.kodeKelas,
            this.noPengajar,
            this.kodePelajaran,
            this.tanggal,
            this.jamMulai,
            this.durasi,
            this.kodeZoom});
            this.dgvJadwalPengajar.Location = new System.Drawing.Point(17, 49);
            this.dgvJadwalPengajar.Name = "dgvJadwalPengajar";
            this.dgvJadwalPengajar.RowTemplate.Height = 25;
            this.dgvJadwalPengajar.Size = new System.Drawing.Size(717, 288);
            this.dgvJadwalPengajar.TabIndex = 14;
            // 
            // kodeJadwalPengajar
            // 
            this.kodeJadwalPengajar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeJadwalPengajar.DataPropertyName = "kodeJadwalPengajar";
            this.kodeJadwalPengajar.HeaderText = "Kode Jadwal";
            this.kodeJadwalPengajar.Name = "kodeJadwalPengajar";
            this.kodeJadwalPengajar.Width = 110;
            // 
            // kodeKelas
            // 
            this.kodeKelas.DataPropertyName = "kodeKelas";
            this.kodeKelas.HeaderText = "Kode Kelas";
            this.kodeKelas.Name = "kodeKelas";
            // 
            // noPengajar
            // 
            this.noPengajar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noPengajar.DataPropertyName = "noPengajar";
            this.noPengajar.HeaderText = "No. Pengajar";
            this.noPengajar.Name = "noPengajar";
            this.noPengajar.Width = 111;
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.DataPropertyName = "kodePelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.Name = "kodePelajaran";
            // 
            // tanggal
            // 
            this.tanggal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tanggal.DataPropertyName = "tanggal";
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.Name = "tanggal";
            this.tanggal.Width = 88;
            // 
            // jamMulai
            // 
            this.jamMulai.DataPropertyName = "jamMulai";
            this.jamMulai.HeaderText = "Jam Mulai";
            this.jamMulai.Name = "jamMulai";
            // 
            // durasi
            // 
            this.durasi.DataPropertyName = "durasi";
            this.durasi.HeaderText = "Durasi";
            this.durasi.Name = "durasi";
            // 
            // kodeZoom
            // 
            this.kodeZoom.DataPropertyName = "kodeZoom";
            this.kodeZoom.HeaderText = "Kode Zoom";
            this.kodeZoom.Name = "kodeZoom";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Info;
            this.btnTambah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(568, 346);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(80, 44);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(654, 346);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 44);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(396, 346);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 44);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(482, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 44);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDaftarJadwalPengajar
            // 
            this.lblDaftarJadwalPengajar.AutoSize = true;
            this.lblDaftarJadwalPengajar.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDaftarJadwalPengajar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDaftarJadwalPengajar.Location = new System.Drawing.Point(12, 9);
            this.lblDaftarJadwalPengajar.Name = "lblDaftarJadwalPengajar";
            this.lblDaftarJadwalPengajar.Size = new System.Drawing.Size(282, 33);
            this.lblDaftarJadwalPengajar.TabIndex = 9;
            this.lblDaftarJadwalPengajar.Text = "Daftar Jadwal Pengajar";
            // 
            // FormJadwalPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(755, 403);
            this.Controls.Add(this.dgvJadwalPengajar);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDaftarJadwalPengajar);
            this.MaximizeBox = false;
            this.Name = "FormJadwalPengajar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal Pengajar";
            this.Load += new System.EventHandler(this.FormJadwalPengajar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPengajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJadwalPengajar;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDaftarJadwalPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeJadwalPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeZoom;
    }
}