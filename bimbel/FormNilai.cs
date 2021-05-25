using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormNilai : Form
    {
        public FormNilai()
        {
            InitializeComponent();
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvNilai.AutoGenerateColumns = false;
            dgvNilai.DataSource = dtacc.getAllNilai();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvNilai.DataSource = da.getAllNilai();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputNilai frm = new FormInputNilai();
            frm.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvNilai.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodeujian = dgvNilai.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataNilai(Selectedkodeujian);

                dgvNilai.DataSource = da.getAllNilai();

                MessageBox.Show("Data " + Selectedkodeujian + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNilai.SelectedRows.Count > 0)
            {
                string selectedkodeujian = dgvNilai.SelectedRows[0].Cells[0].Value.ToString();
                FormInputNilai frm = new FormInputNilai();
                frm.isEditNilai = true;
                frm.nosiswa = selectedkodeujian;
                frm.Show();
            }
        }
    }
}
