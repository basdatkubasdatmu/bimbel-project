using System;
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
        public string fasilitas;

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (clbFasilitas.CheckedItems.Count != 0)
            {
                for (int x = 0; x < clbFasilitas.CheckedItems.Count; x++)
                {
                    if (x == 0)
                    {
                        fasilitas = clbFasilitas.CheckedItems[x].ToString();
                    }
                    else
                    {
                        fasilitas = fasilitas + ", " + clbFasilitas.CheckedItems[x].ToString();
                    }
                }
            }

            if (isEditKelas)
            {
                da.updateDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, fasilitas);
            }
            else
            {
                da.insertDataKelas(tbNomorKelas.Text, tbNamaKelas.Text, tbBiayaKelas.Text, tbKuotaKelas.Text, fasilitas);
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

                DataTable dt = da.getJadwalKelasByID(kodekelas);

                if (dt.Rows.Count > 0)
                {
                    tbNomorKelas.Text = dt.Rows[0]["kodekelas"].ToString();
                    tbNamaKelas.Text = dt.Rows[0]["nama"].ToString();
                    tbBiayaKelas.Text = dt.Rows[0]["biaya"].ToString();
                    tbKuotaKelas.Text = dt.Rows[0]["kuota"].ToString();
                    clbFasilitas.Text = dt.Rows[0]["fasilitas"].ToString();
                }
            }
        }

        private void btBatalKelas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSimpanKelas_MouseHover(object sender, EventArgs e)
        {
            this.tbNomorKelas.BackColor = Color.AliceBlue;
            this.tbNamaKelas.BackColor = Color.AliceBlue; 
            this.tbBiayaKelas.BackColor = Color.AliceBlue;
            this.tbKuotaKelas.BackColor = Color.AliceBlue;

        }
    }
}
