﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class formInputPengajar : Form
    { 

        public formInputPengajar()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        public string nopengajar;

=======

        public bool isEditPengajar = false;

        public string nopengajar;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPengajar)
            {
                da.updateDataPengajar(txtNoPengajar.Text, txtNoPegawai.Text, txtKodePelajaran.Text);
            }
            else
            {
                da.insertDataPengajar(txtNoPengajar.Text, txtNoPegawai.Text, txtKodePelajaran.Text);
            }

            this.Close();
        }

>>>>>>> 4c1760c3f3ad0b35c4001639007e159353efbb3c
        private void formInputPengajar_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditPengajar)
            {
                lblDataPengajar.Text = "Edit Pengajar";
                txtNoPengajar.ReadOnly = true;

                DataTable dt = da.getPengajarByID(nopengajar);

                txtNoPengajar.Text = dt.Rows[0]["nopengajar"].ToString();
                txtNoPegawai.Text = dt.Rows[0]["nopegawai"].ToString();
                txtKodePelajaran.Text = dt.Rows[0]["kodepelajaran"].ToString();
<<<<<<< HEAD
            }
=======
            } 
>>>>>>> 4c1760c3f3ad0b35c4001639007e159353efbb3c
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

<<<<<<< HEAD
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditPengajar)
            {
                da.updateDataPengajar(txtNoPengajar.Text, txtKodePelajaran.Text, txtNoPegawai.Text);
            } else
            {
                da.insertDataPengajar(txtNoPengajar.Text, txtKodePelajaran.Text, txtNoPegawai.Text);
            }
        }
=======
>>>>>>> 4c1760c3f3ad0b35c4001639007e159353efbb3c
    }
}
