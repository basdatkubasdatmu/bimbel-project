using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormKelas : Form
    {
        public FormKelas()
        {
            InitializeComponent();
        }

        private void btRefreshKelas_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvKelas.DataSource = da.getAllKelas();
        }

        private void FormKelas_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvKelas.AutoGenerateColumns = false;
            dgvKelas.DataSource = dtacc.getAllKelas();
        }

        private void btTambahKelas_Click(object sender, EventArgs e)
        {
            FormInputKelas frm = new FormInputKelas();
            frm.Show();
        }

        private void btHapusKelas_Click(object sender, EventArgs e)
        {
            if (dgvKelas.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodekelas = dgvKelas.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataKelas(Selectedkodekelas);

                dgvKelas.DataSource = da.getAllKelas();

                MessageBox.Show("Data " + Selectedkodekelas + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btEditKelas_Click(object sender, EventArgs e)
        {
            if (dgvKelas.SelectedRows.Count > 0)
            {
                string selectedkodekelas = dgvKelas.SelectedRows[0].Cells[0].Value.ToString();
                FormInputKelas frm = new FormInputKelas();
                frm.isEditKelas = true;
                frm.kodekelas = selectedkodekelas;
                frm.Show();
            }
        }
    }
}
