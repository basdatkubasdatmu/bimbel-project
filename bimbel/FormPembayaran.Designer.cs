
namespace bimbel
{
    partial class FormPembayaran
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btHapusPegawai = new System.Windows.Forms.Button();
            this.btEditPegawai = new System.Windows.Forms.Button();
            this.btTambahPegawai = new System.Windows.Forms.Button();
            this.btRefreshPegawai = new System.Windows.Forms.Button();
            this.kodePembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pembayaran";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodePembayaran,
            this.noSiswa,
            this.kodeKelas,
            this.tanggalPembayaran,
            this.status,
            this.jumlahPembayaran});
            this.dataGridView1.Location = new System.Drawing.Point(10, 56);
            this.dataGridView1.Location = new System.Drawing.Point(23, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(766, 278);
            this.dataGridView1.Size = new System.Drawing.Size(754, 278);
            this.dataGridView1.TabIndex = 1;
            // 
            // btHapusPegawai
            // 
            this.btHapusPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHapusPegawai.Location = new System.Drawing.Point(686, 351);
            this.btHapusPegawai.Name = "btHapusPegawai";
            this.btHapusPegawai.Size = new System.Drawing.Size(90, 33);
            this.btHapusPegawai.TabIndex = 62;
            this.btHapusPegawai.Text = "HAPUS";
            this.btHapusPegawai.UseVisualStyleBackColor = true;
            // 
            // btEditPegawai
            // 
            this.btEditPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEditPegawai.Location = new System.Drawing.Point(494, 351);
            this.btEditPegawai.Name = "btEditPegawai";
            this.btEditPegawai.Size = new System.Drawing.Size(90, 33);
            this.btEditPegawai.TabIndex = 61;
            this.btEditPegawai.Text = "EDIT";
            this.btEditPegawai.UseVisualStyleBackColor = true;
            // 
            // btTambahPegawai
            // 
            this.btTambahPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTambahPegawai.Location = new System.Drawing.Point(590, 351);
            this.btTambahPegawai.Name = "btTambahPegawai";
            this.btTambahPegawai.Size = new System.Drawing.Size(90, 33);
            this.btTambahPegawai.TabIndex = 60;
            this.btTambahPegawai.Text = "TAMBAH";
            this.btTambahPegawai.UseVisualStyleBackColor = true;
            // 
            // btRefreshPegawai
            // 
            this.btRefreshPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRefreshPegawai.Location = new System.Drawing.Point(398, 351);
            this.btRefreshPegawai.Name = "btRefreshPegawai";
            this.btRefreshPegawai.Size = new System.Drawing.Size(90, 33);
            this.btRefreshPegawai.TabIndex = 59;
            this.btRefreshPegawai.Text = "REFRESH";
            this.btRefreshPegawai.UseVisualStyleBackColor = true;
            this.btHapusPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btHapusPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHapusPegawai.Location = new System.Drawing.Point(696, 346);
            this.btHapusPegawai.Name = "btHapusPegawai";
            this.btHapusPegawai.Size = new System.Drawing.Size(80, 38);
            this.btHapusPegawai.TabIndex = 62;
            this.btHapusPegawai.Text = "HAPUS";
            this.btHapusPegawai.UseVisualStyleBackColor = false;
            this.btHapusPegawai.Click += new System.EventHandler(this.btHapusPegawai_Click);
            // 
            // btEditPegawai
            // 
            this.btEditPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btEditPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditPegawai.Location = new System.Drawing.Point(524, 346);
            this.btEditPegawai.Name = "btEditPegawai";
            this.btEditPegawai.Size = new System.Drawing.Size(80, 38);
            this.btEditPegawai.TabIndex = 61;
            this.btEditPegawai.Text = "EDIT";
            this.btEditPegawai.UseVisualStyleBackColor = false;
            this.btEditPegawai.Click += new System.EventHandler(this.btEditPegawai_Click);
            // 
            // btTambahPegawai
            // 
            this.btTambahPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btTambahPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTambahPegawai.Location = new System.Drawing.Point(610, 346);
            this.btTambahPegawai.Name = "btTambahPegawai";
            this.btTambahPegawai.Size = new System.Drawing.Size(80, 38);
            this.btTambahPegawai.TabIndex = 60;
            this.btTambahPegawai.Text = "TAMBAH";
            this.btTambahPegawai.UseVisualStyleBackColor = false;
            this.btTambahPegawai.Click += new System.EventHandler(this.btTambahPegawai_Click);
            // 
            // btRefreshPegawai
            // 
            this.btRefreshPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btRefreshPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRefreshPegawai.Location = new System.Drawing.Point(438, 346);
            this.btRefreshPegawai.Name = "btRefreshPegawai";
            this.btRefreshPegawai.Size = new System.Drawing.Size(80, 38);
            this.btRefreshPegawai.TabIndex = 59;
            this.btRefreshPegawai.Text = "REFRESH";
            this.btRefreshPegawai.UseVisualStyleBackColor = false;
            this.btRefreshPegawai.Click += new System.EventHandler(this.btRefreshPegawai_Click);
            // 
            // kodePembayaran
            // 
            this.kodePembayaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodePembayaran.DataPropertyName = "kodepembayaran";
            this.kodePembayaran.HeaderText = "Kode Pembayaran";
            this.kodePembayaran.MinimumWidth = 6;
            this.kodePembayaran.Name = "kodePembayaran";
            this.kodePembayaran.Width = 143;
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
            // kodeKelas
            // 
            this.kodeKelas.DataPropertyName = "kodekelas";
            this.kodeKelas.HeaderText = "Kode Kelas";
            this.kodeKelas.MinimumWidth = 6;
            this.kodeKelas.Name = "kodeKelas";
            this.kodeKelas.Width = 125;
            // 
            // tanggalPembayaran
            // 
            this.tanggalPembayaran.DataPropertyName = "tanggalpembayaran";
            this.tanggalPembayaran.HeaderText = "Tanggal Pembayaran";
            this.tanggalPembayaran.MinimumWidth = 6;
            this.tanggalPembayaran.Name = "tanggalPembayaran";
            this.tanggalPembayaran.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // jumlahPembayaran
            // 
            this.jumlahPembayaran.DataPropertyName = "jumlah";
            this.jumlahPembayaran.HeaderText = "Jumlah Pembayaran";
            this.jumlahPembayaran.MinimumWidth = 6;
            this.jumlahPembayaran.Name = "jumlahPembayaran";
            this.jumlahPembayaran.Width = 125;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(798, 400);
            this.Controls.Add(this.btHapusPegawai);
            this.Controls.Add(this.btEditPegawai);
            this.Controls.Add(this.btTambahPegawai);
            this.Controls.Add(this.btRefreshPegawai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btHapusPegawai;
        private System.Windows.Forms.Button btEditPegawai;
        private System.Windows.Forms.Button btTambahPegawai;
        private System.Windows.Forms.Button btRefreshPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSiswa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPembayaran;
    }
}