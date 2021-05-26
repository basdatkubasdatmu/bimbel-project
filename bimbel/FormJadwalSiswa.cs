using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormJadwalSiswa : Form
    {
        public FormJadwalSiswa()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalSiswa.DataSource = da.getAllJadwalSiswa();
        }

        private void FormJadwalSiswa_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvJadwalSiswa.AutoGenerateColumns = false;
            dgvJadwalSiswa.DataSource = dtacc.getAllJadwalSiswa();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputJadwalSiswa frm = new FormInputJadwalSiswa();
            frm.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvJadwalSiswa.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodejadwalsiswa = dgvJadwalSiswa.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalSiswa(Selectedkodejadwalsiswa);

                dgvJadwalSiswa.DataSource = da.getAllJadwalSiswa();

                MessageBox.Show("Data " + Selectedkodejadwalsiswa + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvJadwalSiswa.SelectedRows.Count > 0)
            {
                string selectedkodejadwalsiswa = dgvJadwalSiswa.SelectedRows[0].Cells[0].Value.ToString();
                FormInputJadwalSiswa frm = new FormInputJadwalSiswa();
                frm.isEditJadwalSiswa = true;
                frm.kodejadwalsiswa = selectedkodejadwalsiswa;
                frm.Show();
            }
        }
    }
}
