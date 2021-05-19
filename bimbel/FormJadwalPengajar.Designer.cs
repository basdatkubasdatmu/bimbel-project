
namespace bimbel
{
    partial class FormJadwalPengajar
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
            this.dgvJadwalPengajar = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDaftarJadwalPengajar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPengajar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJadwalPengajar
            // 
            this.dgvJadwalPengajar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalPengajar.Location = new System.Drawing.Point(17, 43);
            this.dgvJadwalPengajar.Name = "dgvJadwalPengajar";
            this.dgvJadwalPengajar.RowTemplate.Height = 25;
            this.dgvJadwalPengajar.Size = new System.Drawing.Size(717, 339);
            this.dgvJadwalPengajar.TabIndex = 14;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(549, 394);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 44);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(645, 394);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 44);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(357, 394);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 44);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(453, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 44);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblDaftarJadwalPengajar
            // 
            this.lblDaftarJadwalPengajar.AutoSize = true;
            this.lblDaftarJadwalPengajar.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDaftarJadwalPengajar.Location = new System.Drawing.Point(12, 9);
            this.lblDaftarJadwalPengajar.Name = "lblDaftarJadwalPengajar";
            this.lblDaftarJadwalPengajar.Size = new System.Drawing.Size(256, 31);
            this.lblDaftarJadwalPengajar.TabIndex = 9;
            this.lblDaftarJadwalPengajar.Text = "Daftar Jadwal Pengajar";
            // 
            // FormJadwalPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.dgvJadwalPengajar);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDaftarJadwalPengajar);
            this.Name = "FormJadwalPengajar";
            this.Text = "Jadwal Pengajar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalPengajar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJadwalPengajar;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDaftarJadwalPengajar;
    }
}