using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormPegawai : Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void btRefreshPegawai_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPegawai.DataSource = da.getAllPegawai();
        }

        private void btTambahPegawai_Click(object sender, EventArgs e)
        {
            FormInputPegawai frm = new FormInputPegawai();
            frm.Show();
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvPegawai.AutoGenerateColumns = false;
            dgvPegawai.DataSource = dtacc.getAllPegawai();
        }

        private void btHapusPegawai_Click(object sender, EventArgs e)
        {
            if (dgvPegawai.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectednopegawai = dgvPegawai.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPegawai(Selectednopegawai);

                dgvPegawai.DataSource = da.getAllPegawai();

                MessageBox.Show("Data " + Selectednopegawai + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
