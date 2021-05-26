
namespace bimbel
{
    partial class formDataPengajar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPengajar = new System.Windows.Forms.DataGridView();
            this.lblDataPengajar = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nopengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengajar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPengajar
            // 
            this.dgvPengajar.AllowUserToAddRows = false;
            this.dgvPengajar.AllowUserToDeleteRows = false;
            this.dgvPengajar.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengajar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPengajar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengajar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nopengajar,
            this.NoPegawai,
            this.KodePelajaran});
            this.dgvPengajar.Location = new System.Drawing.Point(14, 45);
            this.dgvPengajar.Name = "dgvPengajar";
            this.dgvPengajar.RowTemplate.Height = 25;
            this.dgvPengajar.Size = new System.Drawing.Size(446, 304);
            this.dgvPengajar.TabIndex = 0;
            // 
            // lblDataPengajar
            // 
            this.lblDataPengajar.AutoSize = true;
            this.lblDataPengajar.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataPengajar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDataPengajar.Location = new System.Drawing.Point(12, 9);
            this.lblDataPengajar.Name = "lblDataPengajar";
            this.lblDataPengajar.Size = new System.Drawing.Size(117, 33);
            this.lblDataPengajar.TabIndex = 1;
            this.lblDataPengajar.Text = "Pengajar";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Info;
            this.btnTambah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(288, 355);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(83, 44);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(377, 355);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(83, 44);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(111, 355);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 44);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(199, 355);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 44);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nopengajar
            // 
            this.nopengajar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nopengajar.DataPropertyName = "nopengajar";
            this.nopengajar.HeaderText = "No. Pengajar";
            this.nopengajar.Name = "nopengajar";
            this.nopengajar.Width = 121;
            // 
            // NoPegawai
            // 
            this.NoPegawai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NoPegawai.DataPropertyName = "nopegawai";
            this.NoPegawai.HeaderText = "No. Pegawai";
            this.NoPegawai.Name = "NoPegawai";
            this.NoPegawai.Width = 118;
            // 
            // KodePelajaran
            // 
            this.KodePelajaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KodePelajaran.DataPropertyName = "kodepelajaran";
            this.KodePelajaran.HeaderText = "Kode Pelajaran";
            this.KodePelajaran.Name = "KodePelajaran";
            this.KodePelajaran.Width = 135;
            // 
            // formDataPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(474, 409);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDataPengajar);
            this.Controls.Add(this.dgvPengajar);
            this.MaximizeBox = false;
            this.Name = "formDataPengajar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengajar";
            this.Load += new System.EventHandler(this.formDataPengajar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPengajar;
        private System.Windows.Forms.Label lblDataPengajar;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePelajaran;
    }
}