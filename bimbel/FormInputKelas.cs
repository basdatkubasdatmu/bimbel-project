﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputKelas : Form
    {
        public FormInputKelas()
        {
            InitializeComponent();
        }
        public bool isEditKelas = false;

        public string kodekelas;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (isEditKelas)
            {
                da.updateDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, clbFasilitas.Text);
            }
            else
            {
                da.insertDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, clbFasilitas.Text);
            }

            this.Close();
        }
        private void FormInputKelas_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditKelas)
            {
                lbJudulInputKelas.Text = "Edit Kelas";
                tbNomorKelas.ReadOnly = true;

                DataTable dt = da.getKelasByID(kodekelas);

                tbNomorKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                tbNamaKelas.Text = dt.Rows[0]["nama"].ToString();
                tbBiayaKelas.Text = dt.Rows[0]["biaya"].ToString();
                tbKuotaKelas.Text = dt.Rows[0]["kuota"].ToString();
                clbFasilitas.Text = dt.Rows[0]["fasilitas"].ToString();
               
            }
        }
    }
}
