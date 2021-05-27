using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputPembayaran : Form
    {
        public FormInputPembayaran()
        {
            InitializeComponent();
        }

        public bool isEditPembayaran = false;
        public string kodepembayaran;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormInputPembayaran_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditPembayaran)
            {
                lblinput.Text = "Edit Pembayaran";
                txtKodeBayar.ReadOnly = true;

                DataTable dt = da.getJadwalUjianByID(kodepembayaran);

                txtKodeBayar.Text = dt.Rows[0]["kodepembayaran"].ToString();
                textNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtKodeKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["tanggalpembayaran"].ToString();
                txtStatus.Text = dt.Rows[0]["status"].ToString();
                txtJumlahBayar.Text = dt.Rows[0]["jumlah"].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNamaSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNoSiswa_TextChanged(object sender, EventArgs e)
        {
            if (textNoSiswa.Text != "")
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.getSiswaByID(textNoSiswa.Text);

                if (dt.Rows.Count > 0)
                {
                    textNamaSiswa.Text = dt.Rows[0]["namaSiswa"].ToString();
                }
                else
                {
                    textNamaSiswa.Text = "Tidak Ditemukan";
                }

                textNamaSiswa.ReadOnly = true;
            }
        }

        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            this.txtKodeBayar.BackColor = Color.AliceBlue;
            this.textNoSiswa.BackColor = Color.AliceBlue;
            this.textNamaSiswa.BackColor = Color.AliceBlue;
            this.txtKodeKelas.BackColor = Color.AliceBlue;
            this.txtStatus.BackColor = Color.AliceBlue;
            this.txtJumlahBayar.BackColor = Color.AliceBlue;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPembayaran)
            {
                da.updateDataPembayaran(txtKodeBayar.Text, textNoSiswa.Text, txtKodeKelas.Text, maskedTextBox1.Text, txtStatus.Text, txtJumlahBayar.Text);
            }
            else
            {
                da.insertDataPembayaran(txtKodeBayar.Text, textNoSiswa.Text, txtKodeKelas.Text, maskedTextBox1.Text, txtStatus.Text, txtJumlahBayar.Text);
            }

            this.Close();
        }
    }
}
