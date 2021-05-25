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
    }
}
