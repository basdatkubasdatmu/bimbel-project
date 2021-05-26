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

        public formInputPengajar()
        {
            InitializeComponent();
        }

        public bool isEditPengajar = false;

        public string nopengajar;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPengajar)
            {
                da.updateDataPengajar(txtNoPengajar.Text, txtNoPegawai.Text, txtKodePelajaran.Text);
            }
            else
            {
                da.insertDataPengajar(txtNoPengajar.Text, txtNoPegawai.Text, txtKodePelajaran.Text);
            }

            this.Close();
        }

<<<<<<< HEAD

=======
>>>>>>> 56cb60d8261ef4cb4f096cea3d09cc16feec88df
        private void formInputPengajar_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditPengajar)
            {
                lblDataPengajar.Text = "Edit Pengajar";
                txtNoPengajar.ReadOnly = true;

                DataTable dt = da.getPengajarByID(nopengajar);

                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtNoPegawai.Text = dt.Rows[0]["nopegawai"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
<<<<<<< HEAD
            }
=======

            }

>>>>>>> 56cb60d8261ef4cb4f096cea3d09cc16feec88df
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
<<<<<<< HEAD
=======

>>>>>>> 56cb60d8261ef4cb4f096cea3d09cc16feec88df
    }
}
