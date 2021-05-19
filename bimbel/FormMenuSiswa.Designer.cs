
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
            this.datadiri = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwal = new System.Windows.Forms.ToolStripMenuItem();
            this.Nilai = new System.Windows.Forms.ToolStripMenuItem();
            this.Presensi = new System.Windows.Forms.ToolStripMenuItem();
            this.RuangZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Ujian = new System.Windows.Forms.ToolStripMenuItem();
            this.Kelas = new System.Windows.Forms.ToolStripMenuItem();
            this.Pengajar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datadiri,
            this.jadwal,
            this.Nilai,
            this.Presensi,
            this.RuangZoom,
            this.Pengajar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datadiri
            // 
            this.datadiri.Name = "datadiri";
            this.datadiri.Size = new System.Drawing.Size(81, 24);
            this.datadiri.Text = "Data Diri";
            // 
            // jadwal
            // 
            this.jadwal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ujian,
            this.Kelas});
            this.jadwal.Name = "jadwal";
            this.jadwal.Size = new System.Drawing.Size(66, 24);
            this.jadwal.Text = "Jadwal";
            // 
            // Nilai
            // 
            this.Nilai.Name = "Nilai";
            this.Nilai.Size = new System.Drawing.Size(52, 24);
            this.Nilai.Text = "Nilai";
            // 
            // Presensi
            // 
            this.Presensi.Name = "Presensi";
            this.Presensi.Size = new System.Drawing.Size(74, 24);
            this.Presensi.Text = "Presensi";
            // 
            // RuangZoom
            // 
            this.RuangZoom.Name = "RuangZoom";
            this.RuangZoom.Size = new System.Drawing.Size(107, 24);
            this.RuangZoom.Text = "Ruang Zoom";
            // 
            // Ujian
            // 
            this.Ujian.Name = "Ujian";
            this.Ujian.Size = new System.Drawing.Size(113, 24);
            this.Ujian.Text = "Ujian";
            // 
            // Kelas
            // 
            this.Kelas.Name = "Kelas";
            this.Kelas.Size = new System.Drawing.Size(113, 24);
            this.Kelas.Text = "Kelas";
            // 
            // Pengajar
            // 
            this.Pengajar.Name = "Pengajar";
            this.Pengajar.Size = new System.Drawing.Size(78, 24);
            this.Pengajar.Text = "Pengajar";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datadiri;
        private System.Windows.Forms.ToolStripMenuItem jadwal;
        private System.Windows.Forms.ToolStripMenuItem Ujian;
        private System.Windows.Forms.ToolStripMenuItem Kelas;
        private System.Windows.Forms.ToolStripMenuItem Nilai;
        private System.Windows.Forms.ToolStripMenuItem Presensi;
        private System.Windows.Forms.ToolStripMenuItem RuangZoom;
        private System.Windows.Forms.ToolStripMenuItem Pengajar;
    }
}