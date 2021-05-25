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
        public FormInputPegawai()
        {
            InitializeComponent();
        }
        public bool isEditPegawai = false;

        public string nopegawai;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPegawai)
            {
                da.updateDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, rbLakiLaki, rbPerempuan, tbNoHpPegawai.Text, tbEmailPegawai.Text, tbPosisiPegawai.Text);
            }
            else
            {
                da.insertDataPegawai(tbKodePegawai.Text, tbNamaPegawai.Text, rbLakiLaki, rbPerempuan, tbNoHpPegawai.Text, tbEmailPegawai.Text, tbPosisiPegawai.Text);
            }

            this.Close();
        }
        private void FormInputPegawai_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditPegawai)
            {
                lbJudulInputPegawai.Text = "Edit Pegawai";
                tbKodePegawai.ReadOnly = true;

                DataTable dt = da.getDataPegawaiByID(nopegawai);

                tbKodePegawai.Text = dt.Rows[0]["nopegawai"].ToString();
                tbNamaPegawai.Text = dt.Rows[0]["nama"].ToString();
                rbLakiLaki.Text = dt.Rows[0]["lakilaki"].ToString();
                rbPerempuan.Text = dt.Rows[0]["perempuan"].ToString();
                tbNoHpPegawai.Text = dt.Rows[0]["noHP"].ToString();
                tbEmailPegawai.Text = dt.Rows[0]["email"].ToString();
                tbPosisiPegawai.Text = dt.Rows[0]["posisi"].ToString();
            }
        }
    }
}
