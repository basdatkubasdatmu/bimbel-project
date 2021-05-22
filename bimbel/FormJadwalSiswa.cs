using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormJadwalSiswa : Form
    {
        public FormJadwalSiswa()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvJadwalSiswa.DataSource = da.getAllJadwalSiswa();
        }
    }
}
