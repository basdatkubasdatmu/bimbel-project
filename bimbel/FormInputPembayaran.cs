using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputPembayaran : Form
    {
        public FormInputPembayaran()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormInputPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void textNoSiswa_TextChanged(object sender, EventArgs e)
        {
            if (textNoSiswa.Text != "")
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.getAllSiswa();

                if (dt.Rows.Count > 0)
                {
                    textNamaSiswa.Text = dt.Rows[0]["namaSiswa"].ToString();
                }
            }
        }
    }
}
