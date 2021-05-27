
namespace bimbel
{
    partial class ParentForm
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
            this.mnAplikasi = new System.Windows.Forms.MenuStrip();
            this.siswa = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.presensiSiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalsiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.pengajar = new System.Windows.Forms.ToolStripMenuItem();
            this.mndataPengajar = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalPengajar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPegawai = new System.Windows.Forms.ToolStripMenuItem();
            this.ujian = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalujian = new System.Windows.Forms.ToolStripMenuItem();
            this.nilai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKasir = new System.Windows.Forms.ToolStripMenuItem();
            this.fasilitas = new System.Windows.Forms.ToolStripMenuItem();
            this.kelas = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.matpel = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAplikasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnAplikasi
            // 
            this.mnAplikasi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnAplikasi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnAplikasi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnAplikasi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siswa,
            this.pengajar,
            this.mnPegawai,
            this.ujian,
            this.mnKasir,
            this.fasilitas,
            this.logout});
            this.mnAplikasi.Location = new System.Drawing.Point(0, 0);
            this.mnAplikasi.Name = "mnAplikasi";
            this.mnAplikasi.Size = new System.Drawing.Size(800, 27);
            this.mnAplikasi.TabIndex = 0;
            this.mnAplikasi.Text = "menuStrip1";
            this.mnAplikasi.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // siswa
            // 
            this.siswa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSiswa,
            this.presensiSiswa,
            this.jadwalsiswa});
            this.siswa.Name = "siswa";
            this.siswa.Size = new System.Drawing.Size(59, 23);
            this.siswa.Text = "Siswa";
            // 
            // dataSiswa
            // 
            this.dataSiswa.Name = "dataSiswa";
            this.dataSiswa.Size = new System.Drawing.Size(135, 24);
            this.dataSiswa.Text = "Data Diri";
            this.dataSiswa.Click += new System.EventHandler(this.datasiswa_Click);
            // 
            // presensiSiswa
            // 
            this.presensiSiswa.Name = "presensiSiswa";
            this.presensiSiswa.Size = new System.Drawing.Size(135, 24);
            this.presensiSiswa.Text = "Presensi";
            this.presensiSiswa.Click += new System.EventHandler(this.presensi_Click);
            // 
            // jadwalsiswa
            // 
            this.jadwalsiswa.Name = "jadwalsiswa";
            this.jadwalsiswa.Size = new System.Drawing.Size(135, 24);
            this.jadwalsiswa.Text = "Jadwal";
            this.jadwalsiswa.Click += new System.EventHandler(this.jadwalsiswa_Click);
            // 
            // pengajar
            // 
            this.pengajar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mndataPengajar,
            this.jadwalPengajar});
            this.pengajar.Name = "pengajar";
            this.pengajar.Size = new System.Drawing.Size(81, 23);
            this.pengajar.Text = "Pengajar";
            // 
            // mndataPengajar
            // 
            this.mndataPengajar.Name = "mndataPengajar";
            this.mndataPengajar.Size = new System.Drawing.Size(135, 24);
            this.mndataPengajar.Text = "Data Diri";
            this.mndataPengajar.Click += new System.EventHandler(this.datapengajara_Click);
            // 
            // jadwalPengajar
            // 
            this.jadwalPengajar.Name = "jadwalPengajar";
            this.jadwalPengajar.Size = new System.Drawing.Size(135, 24);
            this.jadwalPengajar.Text = "Jadwal";
            this.jadwalPengajar.Click += new System.EventHandler(this.jadwal_Click);
            // 
            // mnPegawai
            // 
            this.mnPegawai.Name = "mnPegawai";
            this.mnPegawai.Size = new System.Drawing.Size(78, 23);
            this.mnPegawai.Text = "Pegawai";
            this.mnPegawai.Click += new System.EventHandler(this.pegawai_Click);
            // 
            // ujian
            // 
            this.ujian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jadwalujian,
            this.nilai});
            this.ujian.Name = "ujian";
            this.ujian.Size = new System.Drawing.Size(55, 23);
            this.ujian.Text = "Ujian";
            // 
            // jadwalujian
            // 
            this.jadwalujian.Name = "jadwalujian";
            this.jadwalujian.Size = new System.Drawing.Size(148, 24);
            this.jadwalujian.Text = "Jadwal";
            this.jadwalujian.Click += new System.EventHandler(this.jadwalujian_Click);
            // 
            // nilai
            // 
            this.nilai.Name = "nilai";
            this.nilai.Size = new System.Drawing.Size(148, 24);
            this.nilai.Text = "Nilai Siswa";
            this.nilai.Click += new System.EventHandler(this.nilai_Click);
            // 
            // mnKasir
            // 
            this.mnKasir.Name = "mnKasir";
            this.mnKasir.Size = new System.Drawing.Size(54, 23);
            this.mnKasir.Text = "Kasir";
            this.mnKasir.Click += new System.EventHandler(this.kasir_Click);
            // 
            // fasilitas
            // 
            this.fasilitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelas,
            this.zoom,
            this.matpel});
            this.fasilitas.Name = "fasilitas";
            this.fasilitas.Size = new System.Drawing.Size(75, 23);
            this.fasilitas.Text = "Fasilitas";
            // 
            // kelas
            // 
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(226, 24);
            this.kelas.Text = "Daftar Kelas";
            this.kelas.Click += new System.EventHandler(this.kelas_Click);
            // 
            // zoom
            // 
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(226, 24);
            this.zoom.Text = "Ruang Zoom";
            this.zoom.Click += new System.EventHandler(this.zoom_Click);
            // 
            // matpel
            // 
            this.matpel.Name = "matpel";
            this.matpel.Size = new System.Drawing.Size(226, 24);
            this.matpel.Text = "Daftar Mata Pelajaran";
            this.matpel.Click += new System.EventHandler(this.matpel_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(76, 23);
            this.logout.Text = "Log Out";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnAplikasi);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnAplikasi;
            this.MaximizeBox = false;
            this.Name = "ParentForm";
            this.Text = "BIMBEL DARING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.mnAplikasi.ResumeLayout(false);
            this.mnAplikasi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnAplikasi;
        private System.Windows.Forms.ToolStripMenuItem siswa;
        private System.Windows.Forms.ToolStripMenuItem dataSiswa;
        private System.Windows.Forms.ToolStripMenuItem presensiSiswa;
        private System.Windows.Forms.ToolStripMenuItem jadwalSiswa;
        private System.Windows.Forms.ToolStripMenuItem mnPengajar;
        private System.Windows.Forms.ToolStripMenuItem mndataPengajar;
        private System.Windows.Forms.ToolStripMenuItem jadwal;
        private System.Windows.Forms.ToolStripMenuItem pegawai;
        private System.Windows.Forms.ToolStripMenuItem ujian;
        private System.Windows.Forms.ToolStripMenuItem jadwalujian;
        private System.Windows.Forms.ToolStripMenuItem nilai;
        private System.Windows.Forms.ToolStripMenuItem mnKasir;
        private System.Windows.Forms.ToolStripMenuItem jadwalPengajar;
        private System.Windows.Forms.ToolStripMenuItem fasilitas;
        private System.Windows.Forms.ToolStripMenuItem kelas;
        private System.Windows.Forms.ToolStripMenuItem zoom;
        private System.Windows.Forms.ToolStripMenuItem matpel;
        private System.Windows.Forms.ToolStripMenuItem presensi;
        private System.Windows.Forms.ToolStripMenuItem jadwalsiswa;
        private System.Windows.Forms.ToolStripMenuItem pengajar;
        private System.Windows.Forms.ToolStripMenuItem dataPengajar;
        private System.Windows.Forms.ToolStripMenuItem mnPegawai;
        private System.Windows.Forms.ToolStripMenuItem kasir;
        private System.Windows.Forms.ToolStripMenuItem logout;
    }
}