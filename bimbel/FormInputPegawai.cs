using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputPegawai : Form
    {
        public bool isEditPegawai = false;
        public string noPegawai;

        public FormInputPegawai()
        {
            InitializeComponent();
        }

        private void btSimpanPegawai_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            string jnsKelamin = " ";
            if (rbLakiLaki.Checked)
            {
                jnsKelamin = "Laki-laki";
            }
            else if (rbPerempuan.Checked)
            {
                jnsKelamin = "Perempuan";
            }

            if (isEditPegawai)
            {
                da.updateDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, jnsKelamin, tbPosisiPegawai.Text, tbEmailPegawai.Text, tbNoHpPegawai.Text);
            }
            else
            {
                da.insertDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, jnsKelamin, tbPosisiPegawai.Text, tbEmailPegawai.Text, tbNoHpPegawai.Text);
            }

            this.Close();
        }
        private void btBatalPegawai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputPegawai_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditPegawai)
            {
                lbJudulInputPegawai.Text = "Edit Pegawai";
                tbKodePegawai.ReadOnly = true;

                DataTable dt = da.getDataPegawaiByID(noPegawai);

                tbKodePegawai.Text = dt.Rows[0]["nopegawai"].ToString();
                tbNamaPegawai.Text = dt.Rows[0]["nama"].ToString();
                tbNoHpPegawai.Text = dt.Rows[0]["noHP"].ToString();
                tbEmailPegawai.Text = dt.Rows[0]["email"].ToString();
                tbPosisiPegawai.Text = dt.Rows[0]["posisi"].ToString();
                string jnsKelamin = dt.Rows[0]["jenisKelamin"].ToString();

                if (jnsKelamin == "Laki-laki")
                {
                    rbLakiLaki.Checked = true;
                }
                else if (jnsKelamin == "Perempuan")
                {
                    rbPerempuan.Checked = true;
                }
            }
            else
            {
                tbKodePegawai.ReadOnly = true;
            }
        }

      

        private void btBatalPegawai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSimpanPegawai_MouseHover(object sender, EventArgs e)
        {
            this.tbKodePegawai.BackColor = Color.AliceBlue;
            this.tbNamaPegawai.BackColor = Color.AliceBlue;
            this.tbNoHpPegawai.BackColor = Color.AliceBlue;
            this.tbEmailPegawai.BackColor = Color.AliceBlue;
            this.tbPosisiPegawai.BackColor = Color.AliceBlue;
        }
    }
}
