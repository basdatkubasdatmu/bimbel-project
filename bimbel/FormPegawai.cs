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
    }
}
