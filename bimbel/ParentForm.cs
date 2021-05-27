using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class ParentForm : Form
    {
        

        public ParentForm()
        {
            InitializeComponent();
        }

        private void datasiswa_Click(object sender, System.EventArgs e)
        {
            formDatasiswa frmsiswa = new formDatasiswa();
            frmsiswa.MdiParent = this;
            frmsiswa.Show();
        }
        private void jadwalsiswa_Click(object sender, System.EventArgs e)
        {
            FormJadwalSiswa frmjadwalsiswa = new FormJadwalSiswa();
            frmjadwalsiswa.MdiParent = this;
            frmjadwalsiswa.Show();
        }

        private void presensi_Click(object sender, System.EventArgs e)
        {
            FormDaftarPresensi frmpresensi= new FormDaftarPresensi();
            frmpresensi.MdiParent = this;
            frmpresensi.Show();
        }

        private void datapengajara_Click(object sender, System.EventArgs e)
        {
            formDataPengajar frmpengajar = new formDataPengajar();
            frmpengajar.MdiParent = this;
            frmpengajar.Show();
        }

        private void jadwal_Click(object sender, System.EventArgs e)
        {
            FormJadwalPengajar frmjadwalpengajar = new FormJadwalPengajar();
            frmjadwalpengajar.MdiParent = this;
            frmjadwalpengajar.Show();
        }

        private void pegawai_Click(object sender, System.EventArgs e)
        {
            FormPegawai frmpegawai = new FormPegawai();
            frmpegawai.MdiParent = this;
            frmpegawai.Show();
        }

        private void jadwalujian_Click(object sender, System.EventArgs e)
        {
            FormJadwalUjian frmjadwalujian = new FormJadwalUjian();
            frmjadwalujian.MdiParent = this;
            frmjadwalujian.Show();
        }

        private void nilai_Click(object sender, System.EventArgs e)
        {
            FormNilai frmnilai = new FormNilai();
            frmnilai.MdiParent = this;
            frmnilai.Show();
        }

        private void kelas_Click(object sender, System.EventArgs e)
        {
            FormKelas frmkelas = new FormKelas();
            frmkelas.MdiParent = this;
            frmkelas.Show();
        }

        private void matpel_Click(object sender, System.EventArgs e)
        {
            FormMatPel frmmatpel = new FormMatPel();
            frmmatpel.MdiParent = this;
            frmmatpel.Show();
        }

        private void zoom_Click(object sender, System.EventArgs e)
        {
            FormRuangZoom frmzoom = new FormRuangZoom();
            frmzoom.MdiParent = this;
            frmzoom.Show();
        }

        private void kasir_Click(object sender, System.EventArgs e)
        {
            FormPembayaran frmbayar = new FormPembayaran();
            frmbayar.MdiParent = this;
            frmbayar.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.LoginAplikasi();
        }

        private void logout_Click(object sender, System.EventArgs e)
        {
            this.LoginAplikasi();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        public string noPegawaiLogin;

        public string noSiswaLogin;

        private void LoginAplikasi()
        {
            //kita hide menu2-nya kalo belum login
            mnAplikasi.Visible = false;

            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                mnAplikasi.Visible = true;
                if (frmLogin.isSiswa == true)
                {
                    dataSiswa.Visible = false;
                    presensiSiswa.Visible = false;
                    jadwalPengajar.Visible = false;
                    mnPegawai.Visible = false;
                    mnKasir.Visible = false;
                    noSiswaLogin = frmLogin.noSiswaLogin;
                }
                else
                {
                    noPegawaiLogin = frmLogin.noPegawaiLogin;
                }
            }
        }
    }
}

