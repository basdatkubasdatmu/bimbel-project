﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputMataPelajaran : Form
    {
        public FormInputMataPelajaran()
        {
            InitializeComponent();
        }

        public string kodepelajaran;

        public bool isEditMatPel = false;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditMatPel)
            {
                da.updateDataMatPel(txtKodeMapel.Text, textNamaMapel.Text);
            }
            else
            {
                da.insertDataMapel(txtKodeMapel.Text, textNamaMapel.Text);
            }

            this.Close();
        }

        private void FormInputMataPelajaran_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditMatPel)
            {
                label1.Text = "Edit Mata Pelajaran";
                txtKodeMapel.ReadOnly = true;

                DataTable dt = da.getMatPelByID(kodepelajaran);

                txtKodeMapel.Text = dt.Rows[0]["kodepelajaran"].ToString();
                textNamaMapel.Text = dt.Rows[0]["pelajaran"].ToString();
                
            }
        }
    }
}