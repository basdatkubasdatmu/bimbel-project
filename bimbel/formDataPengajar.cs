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

<<<<<<< HEAD
        private void formDataPengajar_Load(object sender, EventArgs e)
        {

=======
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dgvPengajar.DataSource = da.getAllPengajar();
>>>>>>> 973cdf51a2aaa0177a79251782cbb74bda4259e9
        }
    }
}
