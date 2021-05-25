using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormMatPel : Form
    {
        public FormMatPel()
        {
            InitializeComponent();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvMatpel.DataSource = da.getAllMatpel();
        }

        private void FormMatPel_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvMatpel.AutoGenerateColumns = false;
            dgvMatpel.DataSource = dtacc.getAllMatpel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvMatpel.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodepelajaran = dgvMatpel.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataMatpel(Selectedkodepelajaran);

                dgvMatpel.DataSource = da.getAllMatpel();

                MessageBox.Show("Data " + Selectedkodepelajaran + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
