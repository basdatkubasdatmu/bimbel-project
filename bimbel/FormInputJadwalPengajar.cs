using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputJadwalPengajar : Form
    {
        public FormInputJadwalPengajar()
        {
            InitializeComponent();
        }
        public bool isEditJadwalPengajar = false;

        public string kodejadwalpengajar;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditJadwalPengajar)
            {
                da.updateDataJadwalPengajar(txtKodeJadwalPengajar.Text, txtKodeKelas.Text, txtNoPengajar.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text, txtKodeZoom.Text);
            }
            else
            {
                da.insertDataJadwalPengajar(txtKodeJadwalPengajar.Text, txtKodeKelas.Text, txtNoPengajar.Text, txtKodePelajaran.Text, maskedTextBox1.Text, txtJamMulai.Text, maskedTextBox2.Text, txtKodeZoom.Text);
            }

            this.Close();
        }
        private void FormInputJadwalPengajar_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditJadwalPengajar)
            {
                lblInputJadwalPengajar.Text = "Edit Jadwal Pengajar";
                txtKodeJadwalPengajar.ReadOnly = true;

                DataTable dt = da.getJadwalPengajarByID(kodejadwalpengajar);

                txtKodeJadwalPengajar.Text = dt.Rows[0]["kodejadwalpengajar"].ToString();
                txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["tanggal"].ToString();
                txtJamMulai.Text = dt.Rows[0]["jammulai"].ToString();
                maskedTextBox2.Text = dt.Rows[0]["durasi"].ToString();
                txtKodeZoom.Text = dt.Rows[0]["kodezoom"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblKodeJadwalPengajar_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.txtKodeJadwalPengajar.BackColor = Color.AliceBlue;
            this.txtKodeKelas.BackColor = Color.AliceBlue;
            this.txtNoPengajar.BackColor = Color.AliceBlue;
            this.txtKodePelajaran.BackColor = Color.AliceBlue;
            this.maskedTextBox1.BackColor = Color.AliceBlue;
            this.txtJamMulai.BackColor = Color.AliceBlue;
            this.maskedTextBox2.BackColor = Color.AliceBlue;
            this.txtKodeZoom.BackColor = Color.AliceBlue;

        }
    }
}
