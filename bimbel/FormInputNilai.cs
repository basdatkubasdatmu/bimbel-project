﻿using System;
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
        public string nosiswa;

        private void txtNoPengajar_Click(object sender, EventArgs e)
        { 
        
        }

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
        }

        private void FormInputNilai_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditNilai)
            {
                InputNilai.Text = "Edit Nilai";
                txtKodeUjian.ReadOnly = true;
                DataTable dt = da.getSiswaByID(nosiswa);

                txtKodeUjian.Text = dt.Rows[0]["kodekelas"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nama"].ToString();
                txtNoPengajar.Text = dt.Rows[0]["biaya"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kuota"].ToString();
                txtNilai.Text = dt.Rows[0]["fasilitas"].ToString();

            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
