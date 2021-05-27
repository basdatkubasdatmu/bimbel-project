using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormRuangZoom : Form
    {
        public FormRuangZoom()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvRuang.DataSource = da.getAllZoom();
        }

        private void FormRuangZoom_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvRuang.AutoGenerateColumns = false;
            dgvRuang.DataSource = dtacc.getAllZoom();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvRuang.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodezoom = dgvRuang.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataRuangZoom(Selectedkodezoom);

                dgvRuang.DataSource = da.getAllZoom();

                MessageBox.Show("Data " + Selectedkodezoom + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputZoom frm = new FormInputZoom();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRuang.SelectedRows.Count > 0)
            {
                string selectedkodezoom = dgvRuang.SelectedRows[0].Cells[0].Value.ToString();
                FormInputZoom frm = new FormInputZoom();
                frm.isEditZoom = true;
                frm.kodezoom = selectedkodezoom;
                frm.Show();
            }
        }
    }
}
