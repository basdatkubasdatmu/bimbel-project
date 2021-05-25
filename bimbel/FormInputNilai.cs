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
<<<<<<< HEAD
                DataTable dt = da.getDataNilaiByID(kodeujian);
=======
                DataTable dt = da.getSiswaByID(nosiswa);
>>>>>>> 4c1760c3f3ad0b35c4001639007e159353efbb3c

                txtKodeUjian.Text = dt.Rows[0]["kodeujian"].ToString();
                txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
                txtNilai.Text = dt.Rows[0]["nilai"].ToString();

            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
