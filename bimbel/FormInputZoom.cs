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
                da.updateDataRuangZoom(txtkode.Text, txtlink.Text, txtid.Text, txtpass.Text);
            }
            else
            {
                da.insertDataRuang(txtkode.Text, txtlink.Text, txtid.Text, txtpass.Text);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputZoom_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (isEditZoom)
            {
                lblinput.Text = "Edit Ruang Zoom";
                txtkode.ReadOnly = true;

                DataTable dt = da.getRuangZoomByID(txtkode.Text);
                
                if (dt.Rows.Count > 0)
                {
                    txtlink.Text = dt.Rows[0]["link"].ToString();
                    txtid.Text = dt.Rows[0]["meetingid"].ToString();
                    txtpass.Text = dt.Rows[0]["passcode"].ToString();
                }
            }
        }
    }
}
