using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class formDatasiswa : Form
    {
        public formDatasiswa()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvSiswa.DataSource = da.getAllSiswa();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            formInputSiswa frm = new formInputSiswa();
            frm.Show();
        }

        private void formDatasiswa_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvSiswa.AutoGenerateColumns = false;
            dgvSiswa.DataSource = dtacc.getAllSiswa();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvSiswa.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectednosiswa = dgvSiswa.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataSiswa(Selectednosiswa);

                dgvSiswa.DataSource = da.getAllSiswa();

                MessageBox.Show("Data " + Selectednosiswa + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSiswa.SelectedRows.Count > 0)
            {
                string selectednosiswa = dgvSiswa.SelectedRows[0].Cells[0].Value.ToString();
                formInputSiswa frm = new formInputSiswa();
                frm.isEditSiswa = true;
                frm.noSiswa = selectednosiswa;
                frm.Show();
            }
        }
    }
}
