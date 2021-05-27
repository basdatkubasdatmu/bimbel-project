using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputJadwalSiswa : Form
    {
        public FormInputJadwalSiswa()
        {
            InitializeComponent();
        }
        public bool isEditJadwalSiswa = false;

        public string kodejadwalsiswa;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditJadwalSiswa)
            {
                da.updateDataJadwalSiswa(txtKodeJadwalSiswa.Text, txtNoSiswa.Text, txtKodeJadwalPengajar.Text);
            }
            else
            {
                da.insertDataJadwalSiswa(txtKodeJadwalSiswa.Text, txtNoSiswa.Text, txtKodeJadwalPengajar.Text);
            }

            this.Close();
        }

        private void FormInputJadwalSiswa_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditJadwalSiswa)
            {
                lblInputJadwalSiswa.Text = "Edit Jadwal Siswa";
                txtKodeJadwalSiswa.ReadOnly = true;

                DataTable dt = da.getJadwalSiswaByID(kodejadwalsiswa);

                if (dt.Rows.Count > 0)
                {
                    txtKodeJadwalSiswa.Text = dt.Rows[0]["kodejadwalsiswa"].ToString();
                    txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                    txtKodeJadwalPengajar.Text = dt.Rows[0]["kodejadwalpengajar"].ToString();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            this.txtKodeJadwalSiswa.BackColor = Color.AliceBlue;
            this.txtNoSiswa.BackColor = Color.AliceBlue;
            this.txtKodeJadwalPengajar.BackColor = Color.AliceBlue;
        }
    }
}
