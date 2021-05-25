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
        public bool isEditPresensi = false;

        public FormInputPresensi()
        {
            InitializeComponent();
        }

        private void dtpPresensi_ValueChanged(object sender, EventArgs e)
        {
            DateTime iDate;
            iDate = dtpPresensi.Value;
            dtpPresensi.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpPresensi.Format = DateTimePickerFormat.Custom;
        }

        private void FormInputPresensi_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            DateTime iDate;
            iDate = dtpPresensi.Value;
            dtpPresensi.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            dtpPresensi.Format = DateTimePickerFormat.Custom;

            if (isEditPresensi)
            {
                da.updateDataPresensi(txtkodeJadwalSiswa.Text, txtNoSiswa.Text, iDate.ToString());
            }
            else
            {
                da.insertDataPresensi(txtkodeJadwalSiswa.Text, txtNoSiswa.Text, iDate.ToString());
            }

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
