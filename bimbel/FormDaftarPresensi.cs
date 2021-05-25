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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
