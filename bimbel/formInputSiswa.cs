using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class formInputSiswa : Form
    {
        public string noSiswa;
        public bool isEditSiswa;

        public formInputSiswa()
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

            string jenisKelamin = " ";
            if (rbLakiLaki.Checked)
            {
                jenisKelamin = "Laki-laki";
            }
            else if (rdPerempuan.Checked)
            {
                jenisKelamin = "Perempuan";
            }

            if (isEditSiswa)
            {
                da.updateDataSiswa(txtNoSiswa.Text, txtNamaSiswa.Text, jenisKelamin, txtKodeKelas.Text, txtNohpSiswa.Text, txtEmailSiswa.Text, txtAsalSiswa.Text);
            }
            else
            {
                da.insertDataSiswa(txtNoSiswa.Text, txtNamaSiswa.Text, jenisKelamin, txtKodeKelas.Text, txtNohpSiswa.Text, txtEmailSiswa.Text, txtAsalSiswa.Text);
            }
        }
    }
}
