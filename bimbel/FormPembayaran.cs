using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bimbel
{
    public partial class FormPembayaran : Form
    {
        public FormPembayaran()
        {
            InitializeComponent();
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            DataAccess dtacc = new DataAccess();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtacc.getAllPembayaran();
        }

        private void btTambahPegawai_Click(object sender, EventArgs e)
        {
            FormInputPembayaran frm = new FormInputPembayaran();
            this.Show();
        }

        private void btHapusPegawai_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataAccess da = new DataAccess();
                string Selectedkodepembayaran = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                da.hapusDataPembayaran(Selectedkodepembayaran);

                dataGridView1.DataSource = da.getAllKelas();

                MessageBox.Show("Data " + Selectedkodepembayaran + " Telah Terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btEditPegawai_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Selectedkodepembayaran = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                FormInputPembayaran frm = new FormInputPembayaran();
                frm.isEditPembayaran = true;
                frm.kodepembayaran = Selectedkodepembayaran;
                frm.Show();
            }
        }

        private void btRefreshPegawai_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            dataGridView1.DataSource = da.getAllPembayaran();
        }
    }
}
