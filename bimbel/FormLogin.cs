using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormLogin : Form
    {
        

        public FormLogin()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void siswa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string noSiswaLogin;

        public Boolean isSiswa;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                DataAccess da = new DataAccess();
                DataTable dataSiswa = da.getSiswaByID(txtUsername.Text); //Msalkan loginnya pakai ID pegawai (bisa juga buat kolom username sendiri di database)

                if (dataSiswa.Rows.Count == 0)
                {
                    MessageBox.Show("Pegawai tersebut tidak terdaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Jika ada pegawai tersebut di tabel pegawai
                    //Cek apakah password-nya benar
                    if (txtPassword.Text == dataSiswa.Rows[0]["nohp"].ToString()) //Misalnya passwordnya pakai nohp (bisa buat kolom password sendiri)
                    {
                        this.noSiswaLogin = txtUsername.Text;
                        this.DialogResult = DialogResult.OK;
                        this.isSiswa = true;
                    }
                    else
                    {
                        MessageBox.Show("Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            else
            {
                MessageBox.Show("Silakan masukan username dan password terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string noPegawaiLogin;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsernamePgw.Text != "" && txtPasswordPgw.Text != "")
            {
                DataAccess da = new DataAccess();
                DataTable dataPgw = da.getDataPegawaiByID(txtUsernamePgw.Text); //Msalkan loginnya pakai ID pegawai (bisa juga buat kolom username sendiri di database)

                if (dataPgw.Rows.Count == 0)
                {
                    MessageBox.Show("Pegawai tersebut tidak terdaftar", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Jika ada pegawai tersebut di tabel pegawai
                    //Cek apakah password-nya benar
                    if (txtPasswordPgw.Text == dataPgw.Rows[0]["nohp"].ToString()) //Misalnya passwordnya pakai nohp (bisa buat kolom password sendiri)
                    {
                        this.noPegawaiLogin = txtUsernamePgw.Text;
                        this.DialogResult = DialogResult.OK;
                        this.isSiswa = false;
                    }
                    else
                    {
                        MessageBox.Show("Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            else
            {
                MessageBox.Show("Silakan masukan username dan password terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
