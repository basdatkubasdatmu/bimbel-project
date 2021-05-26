
namespace bimbel
{
    partial class FormNilai
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
            this.txtNilai = new System.Windows.Forms.Label();
            this.dgvNilai = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.kodeujian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPengajar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNilai
            // 
            this.txtNilai.AutoSize = true;
            this.txtNilai.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNilai.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtNilai.Location = new System.Drawing.Point(12, 9);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(67, 33);
            this.txtNilai.TabIndex = 2;
            this.txtNilai.Text = "Nilai";
            // 
            // dgvNilai
            // 
            this.dgvNilai.AllowUserToAddRows = false;
            this.dgvNilai.AllowUserToDeleteRows = false;
            this.dgvNilai.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNilai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNilai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeujian,
            this.noSiswa,
            this.NamaSiswa,
            this.noPengajar,
            this.NamaPengajar,
            this.kodePelajaran,
            this.nilai});
            this.dgvNilai.Location = new System.Drawing.Point(12, 43);
            this.dgvNilai.Name = "dgvNilai";
            this.dgvNilai.RowHeadersWidth = 51;
            this.dgvNilai.RowTemplate.Height = 25;
            this.dgvNilai.Size = new System.Drawing.Size(776, 312);
            this.dgvNilai.TabIndex = 13;
            this.dgvNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNilai_CellContentClick);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Info;
            this.btnTambah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(601, 361);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 44);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(697, 361);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 44);
            this.btnHapus.TabIndex = 16;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(409, 361);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 44);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(505, 361);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 44);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // kodeujian
            // 
            this.kodeujian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeujian.DataPropertyName = "kodeujian";
            this.kodeujian.HeaderText = "Kode Ujian";
            this.kodeujian.MinimumWidth = 6;
            this.kodeujian.Name = "kodeujian";
            this.kodeujian.Width = 97;
            // 
            // noSiswa
            // 
            this.noSiswa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.noSiswa.DataPropertyName = "nosiswa";
            this.noSiswa.HeaderText = "No Siswa";
            this.noSiswa.MinimumWidth = 6;
            this.noSiswa.Name = "noSiswa";
            this.noSiswa.Width = 88;
            // 
            // NamaSiswa
            // 
            this.NamaSiswa.DataPropertyName = "nama";
            this.NamaSiswa.HeaderText = "Nama Siswa";
            this.NamaSiswa.Name = "NamaSiswa";
            // 
            // noPengajar
            // 
            this.noPengajar.DataPropertyName = "nopengajar";
            this.noPengajar.HeaderText = "No Pengajar";
            this.noPengajar.MinimumWidth = 6;
            this.noPengajar.Name = "noPengajar";
            this.noPengajar.Width = 125;
            // 
            // NamaPengajar
            // 
            this.NamaPengajar.DataPropertyName = "nama";
            this.NamaPengajar.HeaderText = "Nama Pengajar";
            this.NamaPengajar.Name = "NamaPengajar";
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.DataPropertyName = "kodepelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.MinimumWidth = 6;
            this.kodePelajaran.Name = "kodePelajaran";
            this.kodePelajaran.Width = 125;
            // 
            // nilai
            // 
            this.nilai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nilai.DataPropertyName = "nilai";
            this.nilai.HeaderText = "Nilai";
            this.nilai.MinimumWidth = 6;
            this.nilai.Name = "nilai";
            this.nilai.Width = 63;
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvNilai);
            this.Controls.Add(this.txtNilai);
            this.MaximizeBox = false;
            this.Name = "FormNilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNilai;
        private System.Windows.Forms.DataGridView dgvNilai;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeujian;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPengajar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilai;
    }
}