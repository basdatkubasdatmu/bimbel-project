using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class formDataPengajar : Form
    {
        public formDataPengajar()
        {
            InitializeComponent();
        }

        private void formDataPengajar_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvPengajar.AutoGenerateColumns = false;
            dgvPengajar.DataSource = dtacc.getAllPengajar();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPengajar.DataSource = da.getAllPengajar();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            formInputPengajar frm = new formInputPengajar();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPengajar.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectednopengajar = dgvPengajar.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPengajar(Selectednopengajar);

                dgvPengajar.DataSource = da.getAllPengajar();

                MessageBox.Show("Data " + Selectednopengajar + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
