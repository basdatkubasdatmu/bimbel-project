﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siswa = new System.Windows.Forms.ToolStripMenuItem();
            this.datasiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.presensi = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalsiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.pengajar = new System.Windows.Forms.ToolStripMenuItem();
            this.datapengajar = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwal = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawai = new System.Windows.Forms.ToolStripMenuItem();
            this.ujian = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalujian = new System.Windows.Forms.ToolStripMenuItem();
            this.nilai = new System.Windows.Forms.ToolStripMenuItem();
            this.Kasir = new System.Windows.Forms.ToolStripMenuItem();
            this.fasilitas = new System.Windows.Forms.ToolStripMenuItem();
            this.kelas = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.matpel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siswa,
            this.pengajar,
            this.pegawai,
            this.ujian,
            this.Kasir,
            this.fasilitas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // siswa
            // 
            this.siswa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datasiswa,
            this.presensi,
            this.jadwalsiswa});
            this.siswa.Name = "siswa";
            this.siswa.Size = new System.Drawing.Size(59, 23);
            this.siswa.Text = "Siswa";
            // 
            // datasiswa
            // 
            this.datasiswa.Name = "datasiswa";
            this.datasiswa.Size = new System.Drawing.Size(167, 24);
            this.datasiswa.Text = "Data Diri";
            this.datasiswa.Click += new System.EventHandler(this.datasiswa_Click);
            // 
            // presensi
            // 
            this.presensi.Name = "presensi";
            this.presensi.Size = new System.Drawing.Size(167, 24);
            this.presensi.Text = "Jadwal Siswa";
            this.presensi.Click += new System.EventHandler(this.presensi_Click);
            // 
            // jadwalsiswa
            // 
            this.jadwalsiswa.Name = "jadwalsiswa";
            this.jadwalsiswa.Size = new System.Drawing.Size(167, 24);
            this.jadwalsiswa.Text = "Jadwal";
            this.jadwalsiswa.Click += new System.EventHandler(this.jadwalsiswa_Click);
            // 
            // pengajar
            // 
            this.pengajar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datapengajar,
            this.jadwal});
            this.pengajar.Name = "pengajar";
            this.pengajar.Size = new System.Drawing.Size(81, 23);
            this.pengajar.Text = "Pengajar";
            // 
            // datapengajar
            // 
            this.datapengajar.Name = "datapengajar";
            this.datapengajar.Size = new System.Drawing.Size(135, 24);
            this.datapengajar.Text = "Data Diri";
            this.datapengajar.Click += new System.EventHandler(this.datapengajara_Click);
            // 
            // jadwal
            // 
            this.jadwal.Name = "jadwal";
            this.jadwal.Size = new System.Drawing.Size(135, 24);
            this.jadwal.Text = "Jadwal";
            this.jadwal.Click += new System.EventHandler(this.jadwal_Click);
            // 
            // pegawai
            // 
            this.pegawai.Name = "pegawai";
            this.pegawai.Size = new System.Drawing.Size(78, 23);
            this.pegawai.Text = "Pegawai";
            this.pegawai.Click += new System.EventHandler(this.pegawai_Click);
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
            // Kasir
            // 
            this.Kasir.Name = "Kasir";
            this.Kasir.Size = new System.Drawing.Size(54, 23);
            this.Kasir.Text = "Kasir";
            this.Kasir.Click += new System.EventHandler(this.kasir_Click);
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
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ParentForm";
            this.Text = "BIMBEL DARING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siswa;
        private System.Windows.Forms.ToolStripMenuItem datasiswa;
        private System.Windows.Forms.ToolStripMenuItem presensi;
        private System.Windows.Forms.ToolStripMenuItem jadwalsiswa;
        private System.Windows.Forms.ToolStripMenuItem pengajar;
        private System.Windows.Forms.ToolStripMenuItem datapengajar;
        private System.Windows.Forms.ToolStripMenuItem jadwal;
        private System.Windows.Forms.ToolStripMenuItem pegawai;
        private System.Windows.Forms.ToolStripMenuItem ujian;
        private System.Windows.Forms.ToolStripMenuItem jadwalujian;
        private System.Windows.Forms.ToolStripMenuItem nilai;
        private System.Windows.Forms.ToolStripMenuItem Kasir;
        private System.Windows.Forms.ToolStripMenuItem fasilitas;
        private System.Windows.Forms.ToolStripMenuItem kelas;
        private System.Windows.Forms.ToolStripMenuItem zoom;
        private System.Windows.Forms.ToolStripMenuItem matpel;
    }
}