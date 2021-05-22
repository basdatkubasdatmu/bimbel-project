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
    }
}
