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
                da.updateDataJadwalUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, maskedTextBox1.Text, maskedTextBox3.Text, maskedTextBox2.Text);
            }
            else
            {
                da.insertDataUjian(txtKodeUjian.Text, txtNamaUjian.Text, txtKodePelajaran.Text, maskedTextBox1.Text, maskedTextBox3.Text, maskedTextBox2.Text);
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

                DataTable dt = da.getJadwalUjianByID(kodeujian);

                if (dt.Rows.Count > 0)
                {
                    txtKodeUjian.Text = dt.Rows[0]["kodeujian"].ToString();
                    txtNamaUjian.Text = dt.Rows[0]["nama"].ToString();
                    txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                    maskedTextBox1.Text = dt.Rows[0]["tanggal"].ToString();
                    maskedTextBox3.Text = dt.Rows[0]["jammulai"].ToString();
                    maskedTextBox2.Text = dt.Rows[0]["durasi"].ToString();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            this.txtKodeUjian.BackColor = Color.AliceBlue;
            this.txtNamaUjian.BackColor = Color.AliceBlue;
            this.txtKodePelajaran.BackColor = Color.AliceBlue;
            this.maskedTextBox1.BackColor = Color.AliceBlue;
            this.maskedTextBox3.BackColor = Color.AliceBlue;
            this.maskedTextBox2.BackColor = Color.AliceBlue;

        }
    }
}
