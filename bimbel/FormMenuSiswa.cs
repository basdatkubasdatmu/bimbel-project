using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void datasiswa_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            formDatasiswa frmsiswa = new formDatasiswa();
            frmsiswa.MdiParent = this;
            frmsiswa.Show();
        }
        private void jadwalsiswa_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormJadwalSiswa frmjadwalsiswa = new FormJadwalSiswa();
            frmjadwalsiswa.MdiParent = this;
            frmjadwalsiswa.Show();
        }

        private void presensi_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormDaftarPresensi frmpresensi= new FormDaftarPresensi();
            frmpresensi.MdiParent = this;
            frmpresensi.Show();
        }

        private void datapengajara_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            formDataPengajar frmpengajar = new formDataPengajar();
            frmpengajar.MdiParent = this;
            frmpengajar.Show();
        }

        private void jadwal_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormJadwalPengajar frmjadwalpengajar = new FormJadwalPengajar();
            frmjadwalpengajar.MdiParent = this;
            frmjadwalpengajar.Show();
        }

        private void pegawai_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void jadwalujian_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormJadwalUjian frmjadwalujian = new FormJadwalUjian();
            frmjadwalujian.MdiParent = this;
            frmjadwalujian.Show();
        }

        private void nilai_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormNilai frmnilai = new FormNilai();
            frmnilai.MdiParent = this;
            frmnilai.Show();
        }

        private void kasir_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void kelas_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void matpel_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormMatPel frmmatpel = new FormMatPel();
            frmmatpel.MdiParent = this;
            frmmatpel.Show();
        }

        private void zoom_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            FormRuangZoom frmzoom = new FormRuangZoom();
            frmzoom.MdiParent = this;
            frmzoom.Show();
        }
    }
}

