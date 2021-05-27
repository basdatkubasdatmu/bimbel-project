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
        public string kodejadwalsiswa;

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
            DataAccess da = new DataAccess();
            if (isEditPresensi)
            {
                lblInputPresensiSiswa.Text = "Edit Presensi";
                txtkodeJadwalSiswa.ReadOnly = true;

                DataTable dt = da.getPresensiByID(kodejadwalsiswa);

                if (dt.Rows.Count > 0)
                {
                    txtkodeJadwalSiswa.Text = dt.Rows[0]["kodejadwalsiswa"].ToString();
                    txtNoSiswa.Text = dt.Rows[0]["nosiswa"].ToString();
                    dtpPresensi.Text = dt.Rows[0]["waktupresensi"].ToString();
                }
            }
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

        private void btnSimpan_MouseHover(object sender, EventArgs e)
        {
            this.txtkodeJadwalSiswa.BackColor = Color.AliceBlue;
            this.txtNoSiswa.BackColor = Color.AliceBlue;
            this.txtNamaSiswa.BackColor = Color.AliceBlue;
            this.dtpPresensi.BackColor = Color.AliceBlue;
        }
    }
}
