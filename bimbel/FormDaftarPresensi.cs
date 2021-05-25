using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormDaftarPresensi : Form
    {
        public FormDaftarPresensi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPresensi.DataSource = da.getAllPresensi();
        }

        private void FormDaftarPresensi_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvPresensi.AutoGenerateColumns = false;
            dgvPresensi.DataSource = dtacc.getAllPresensi();
        }

        private void dgvPresensi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< HEAD
        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvPresensi.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodejadwalsiswa = dgvPresensi.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPresensi(Selectedkodejadwalsiswa);

                dgvPresensi.DataSource = da.getAllPresensi();

                MessageBox.Show("Data " + Selectedkodejadwalsiswa + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
=======
        private void button1_Click(object sender, EventArgs e)
        {

>>>>>>> 05401cc8076c9bed8fc5bc7e63fbaa34a9398336
        }
    }
}
