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
        public bool isEditSiswa= false;
        public string jenisKelamin;

        public formInputSiswa()
        {
            InitializeComponent();
        }

        private void formInputSiswa_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditSiswa)
            {
                lblDataSiswa.Text = "Edit Siswa";
                txtNoSiswa.ReadOnly = true;

                DataTable dt = da.getSiswaByID(noSiswa);
                if (dt.Rows.Count > 0)
                {
                    txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                    txtNamaSiswa.Text = dt.Rows[0]["nama"].ToString();
                    rbLakiLaki.Text = dt.Rows[0]["jeniskelamin"].ToString();
                    rdPerempuan.Text = dt.Rows[0]["jeniskelamin"].ToString();
                    txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                    txtNohpSiswa.Text = dt.Rows[0]["nohp"].ToString();
                    txtEmailSiswa.Text = dt.Rows[0]["email"].ToString();
                    txtAsalSiswa.Text = dt.Rows[0]["asaldaerah"].ToString();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            jenisKelamin = " ";
            if (rbLakiLaki.Checked)
            {
                jenisKelamin = "L";
            }
            else if (rdPerempuan.Checked)
            {
                jenisKelamin = "P";
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

        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            this.txtNoSiswa.BackColor = Color.AliceBlue;
            this.txtNamaSiswa.BackColor = Color.AliceBlue;
            this.txtKodeKelas.BackColor = Color.AliceBlue;
            this.txtNohpSiswa.BackColor = Color.AliceBlue;
            this.txtEmailSiswa.BackColor = Color.AliceBlue;
            this.txtAsalSiswa.BackColor = Color.AliceBlue;
        }
    }
}
