using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class formInputPengajar : Form
    {
        public bool isEditPengajar = false; 

        public formInputPengajar()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPengajar)
            {
                da.updateDataPengajar(txtNoPengajar.Text, txtKodePelajaran.Text, txtNoPegawai.Text);
            } else
            {
                da.insertDataPengajar(txtNoPengajar.Text, txtKodePelajaran.Text, txtNoPegawai.Text);
            }
        }
    }
}
