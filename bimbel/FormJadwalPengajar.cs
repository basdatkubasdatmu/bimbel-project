using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormJadwalPengajar : Form
    {
        public FormJadwalPengajar()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();
        }

        private void FormJadwalPengajar_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvJadwalPengajar.AutoGenerateColumns = false;
            dgvJadwalPengajar.DataSource = dtacc.getAllJadwalPengajar();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputJadwalPengajar frm = new FormInputJadwalPengajar();
            frm.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvJadwalPengajar.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodejadwalpengajar = dgvJadwalPengajar.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalPengajar(Selectedkodejadwalpengajar);
                
                dgvJadwalPengajar.DataSource = da.getAllJadwalPengajar();

                MessageBox.Show("Data " + Selectedkodejadwalpengajar + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
