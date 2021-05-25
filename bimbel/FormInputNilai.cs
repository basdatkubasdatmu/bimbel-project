using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputNilai : Form
    {
        public FormInputNilai()
        {
            InitializeComponent();
        }
        public bool isEditNilai = false;

        public string kodeujian;
<<<<<<< HEAD
       
        private void txtNoPengajar_Click(object sender, EventArgs e)
        {
=======

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditNilai)
            {
                da.updateDataNilai(txtKodeUjian.Text, txtNoSiswa.Text, txtNoPengajar.Text, txtKodePelajaran.Text, txtNilai.Text);
            }
            else
            {
                da.insertDataNilai(txtKodeUjian.Text, txtNoSiswa.Text, txtNoPengajar.Text, txtKodePelajaran.Text, txtNilai.Text);
            }
>>>>>>> 59f0f22c0669a27ec9a86448c3a61fa9e8b5070b

        }

<<<<<<< HEAD
        private void FormInputNilai_Load(object sender, EventArgs e)
=======
        private void FormInputKelas_Load(object sender, EventArgs e)
>>>>>>> 59f0f22c0669a27ec9a86448c3a61fa9e8b5070b
        {
            DataAccess da = new DataAccess();
            if (isEditNilai)
            {
                InputNilai.Text = "Edit Nilai";
                txtKodeUjian.ReadOnly = true;

                DataTable dt = da.getNilaiByID(noSiswa);

<<<<<<< HEAD
                tbNomorKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                tbNamaKelas.Text = dt.Rows[0]["nama"].ToString();
                tbBiayaKelas.Text = dt.Rows[0]["biaya"].ToString();
                tbKuotaKelas.Text = dt.Rows[0]["kuota"].ToString();
                clbFasilitas.Text = dt.Rows[0]["fasilitas"].ToString();
=======
                txtKodeUjian.Text = dt.Rows[0]["kodekelas"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nama"].ToString();
                txtNoPengajar.Text = dt.Rows[0]["biaya"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kuota"].ToString();
                txtNilai.Text = dt.Rows[0]["fasilitas"].ToString();

>>>>>>> 59f0f22c0669a27ec9a86448c3a61fa9e8b5070b
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditNilai)
            {
                da.updateDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, clbFasilitas.Text);
            }
            else
            {
                da.insertDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, clbFasilitas.Text);
            }

            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
