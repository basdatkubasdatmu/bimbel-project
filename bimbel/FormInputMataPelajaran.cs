using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputMataPelajaran : Form
    {
        public FormInputMataPelajaran()
        {
            InitializeComponent();
        }

        public string kodepelajaran;

        public bool isEditMatPel = false;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditMatPel)
            {
                da.updateDataMatPel(txtKodeMapel.Text, textNamaMapel.Text);
            }
            else
            {
                da.insertDataMapel(txtKodeMapel.Text, textNamaMapel.Text);
            }

            this.Close();
        }

        private void FormInputMataPelajaran_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditMatPel)
            {
                label1.Text = "Edit Mata Pelajaran";
                txtKodeMapel.ReadOnly = true;

                DataTable dt = da.getMatPelByID(kodepelajaran);

                txtKodeMapel.Text = dt.Rows[0]["kodepelajaran"].ToString();
                textNamaMapel.Text = dt.Rows[0]["pelajaran"].ToString();
                
            }
        }

<<<<<<< HEAD
        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            this.txtKodeMapel.BackColor = Color.AliceBlue;
            this.textNamaMapel.BackColor = Color.AliceBlue;
=======
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
>>>>>>> 18e187e3ac2e5d30b4940d2d1290be62609fc40f
        }
    }
}
