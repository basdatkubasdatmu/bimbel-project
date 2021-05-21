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
    }
}
