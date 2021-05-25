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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
