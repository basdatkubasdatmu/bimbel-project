using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormJadwalUjian : Form
    {
        public FormJadwalUjian()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalUjian.DataSource = da.getAllUjian();
        }

        private void FormJadwalUjian_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dgvJadwalUjian.AutoGenerateColumns = false;
            dgvJadwalUjian.DataSource = dtacc.getAllUjian();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvJadwalUjian.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodeujian = dgvJadwalUjian.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataJadwalUjian(Selectedkodeujian);

                dgvJadwalUjian.DataSource = da.getAllUjian();

                MessageBox.Show("Data " + Selectedkodeujian + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
