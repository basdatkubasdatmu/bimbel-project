using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputJadwalUjian : Form
    {
        public FormInputJadwalUjian()
        {
            InitializeComponent();
        }

        public bool isEditJadwalUjian = false;

        public string kodeujian;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditJadwalUjian)
            {
                da.updateDataJadwalUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text);
            }
            else
            {
                da.insertDataUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text);
            }

            this.Close();
        }

        private void FormInputJadwalUjian_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditJadwalUjian)
            {
                lblInputJadwalUjian.Text = "Edit Jadwal Ujian";
                txtKodeUjian.ReadOnly = true;

                DataTable dt = da.getJadwaUjianByID(kodeujian);

                txtKodeUjian.Text = dt.Rows[0]["kodeujian"].ToString();
                txtNamaUjian.Text = dt.Rows[0]["nama"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["tanggal"].ToString();
                txtJamMulai.Text = dt.Rows[0]["jammulai"].ToString();
                maskedTextBox2.Text = dt.Rows[0]["durasi"].ToString();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
