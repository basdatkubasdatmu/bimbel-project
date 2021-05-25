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
        public bool isEditSiswa = false;

<<<<<<< HEAD
        public string nosiswa;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditSiswa)
            {
                da.updateDataSiswa(txtNoSiswa.Text, txtNamaSiswa.Text, rbLakiLaki.Text, rdPerempuan.Text, txtKodeKelas.Text, txtNohpSiswa.Text, txtEmailSiswa, txtAsalSiswa);
            }
            else
            {
                da.insertDataSiswa(txtNoSiswa.Text, txtNamaSiswa.Text, rbLakiLaki.Text, rdPerempuan.Text, txtKodeKelas.Text, txtNohpSiswa.Text, txtEmailSiswa, txtAsalSiswa);
            }

            this.Close();
        }
        private void formInputSiswa_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditSiswa)
            {
                lblDataSiswa.Text = "Edit Siswa";
                txtNoSiswa.ReadOnly = true;

                DataTable dt = da.getSiswaByID(nosiswa);

                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtNamaSiswa.Text = dt.Rows[0]["nama"].ToString();
                rbLakiLaki.Text = dt.Rows[0]["lakilaki"].ToString();
                rdPerempuan.Text = dt.Rows[0]["perempuan"].ToString();
                txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                txtNohpSiswa.Text = dt.Rows[0]["nohp"].ToString();
                txtEmailSiswa.Text = dt.Rows[0]["email"].ToString();
                txtAsalSiswa.Text = dt.Rows[0]["asaldaerah"].ToString();
            }
        }
        private void lblEmailSiswa_Click(object sender, EventArgs e)
=======
        private void btnBatal_Click(object sender, EventArgs e)
>>>>>>> 6f37bfe48afca39be443d9a006c1bcdbe3f0c340
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
