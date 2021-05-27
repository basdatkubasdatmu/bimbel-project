using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormInputZoom : Form
    {
        public FormInputZoom()
        {
            InitializeComponent();
        }

        public bool isEditZoom = false;
        public string kodezoom;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditZoom)
            {
                lblinput.Text = "Edit Ruang Zoom";
                txtkode.ReadOnly = true;

                DataTable dt = da.getRuangZoomByID(kodezoom);

                txtkode.Text = dt.Rows[0]["kodezoom"].ToString();
                txtlink.Text = dt.Rows[0]["link"].ToString();
                txtid.Text = dt.Rows[0]["meetingid"].ToString();
                txtpass.Text = dt.Rows[0]["passcode"].ToString();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
