using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputPresensi : Form
    {
        public FormInputPresensi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormInputPresensi_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DataAccess da = new DataAccess();

        //    da.insertDataPresensi(txtkodeJadwalSiswa.Text, txtNoSiswa.Text, txtNamaSiswa.Text, dtpPresensi.Text);
        //}
    }
}
