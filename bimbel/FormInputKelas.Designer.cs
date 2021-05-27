
namespace bimbel
{
    partial class FormInputKelas
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
            this.clbFasilitas = new System.Windows.Forms.CheckedListBox();
            this.lbJudulInputKelas = new System.Windows.Forms.Label();
            this.btBatalKelas = new System.Windows.Forms.Button();
            this.btSimpanKelas = new System.Windows.Forms.Button();
            this.lbFasilitasKelas = new System.Windows.Forms.Label();
            this.lbKuotaKelas = new System.Windows.Forms.Label();
            this.tbBiayaKelas = new System.Windows.Forms.TextBox();
            this.lbBiaya = new System.Windows.Forms.Label();
            this.tbNamaKelas = new System.Windows.Forms.TextBox();
            this.lbNamaKelas = new System.Windows.Forms.Label();
            this.tbNomorKelas = new System.Windows.Forms.TextBox();
            this.lbNomorKelas = new System.Windows.Forms.Label();
            this.tbKuotaKelas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbFasilitas
            // 
            this.clbFasilitas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbFasilitas.FormattingEnabled = true;
            this.clbFasilitas.Items.AddRange(new object[] {
            "Full AC",
            "Modul gratis",
            "3 kali pertemuan/minggu",
            "2 kali pertemuan/minggu"});
            this.clbFasilitas.Location = new System.Drawing.Point(119, 203);
            this.clbFasilitas.Margin = new System.Windows.Forms.Padding(4);
            this.clbFasilitas.Name = "clbFasilitas";
            this.clbFasilitas.Size = new System.Drawing.Size(256, 92);
            this.clbFasilitas.TabIndex = 55;
            // 
            // lbJudulInputKelas
            // 
            this.lbJudulInputKelas.AutoSize = true;
            this.lbJudulInputKelas.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulInputKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbJudulInputKelas.Location = new System.Drawing.Point(8, 9);
            this.lbJudulInputKelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJudulInputKelas.Name = "lbJudulInputKelas";
            this.lbJudulInputKelas.Size = new System.Drawing.Size(204, 33);
            this.lbJudulInputKelas.TabIndex = 54;
            this.lbJudulInputKelas.Text = "Input Data Kelas";
            // 
            // btBatalKelas
            // 
            this.btBatalKelas.BackColor = System.Drawing.SystemColors.Info;
            this.btBatalKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btBatalKelas.Location = new System.Drawing.Point(175, 319);
            this.btBatalKelas.Margin = new System.Windows.Forms.Padding(4);
            this.btBatalKelas.Name = "btBatalKelas";
            this.btBatalKelas.Size = new System.Drawing.Size(96, 45);
            this.btBatalKelas.TabIndex = 53;
            this.btBatalKelas.Text = "BATAL";
            this.btBatalKelas.UseVisualStyleBackColor = false;
            this.btBatalKelas.Click += new System.EventHandler(this.btBatalKelas_Click);
            // 
            // btSimpanKelas
            // 
            this.btSimpanKelas.BackColor = System.Drawing.SystemColors.Info;
            this.btSimpanKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSimpanKelas.Location = new System.Drawing.Point(279, 319);
            this.btSimpanKelas.Margin = new System.Windows.Forms.Padding(4);
            this.btSimpanKelas.Name = "btSimpanKelas";
            this.btSimpanKelas.Size = new System.Drawing.Size(96, 45);
            this.btSimpanKelas.TabIndex = 52;
            this.btSimpanKelas.Text = "SIMPAN";
            this.btSimpanKelas.UseVisualStyleBackColor = false;
            this.btSimpanKelas.Click += new System.EventHandler(this.btnSimpan_Click);
            this.btSimpanKelas.MouseHover += new System.EventHandler(this.btSimpanKelas_MouseHover);
            // 
            // lbFasilitasKelas
            // 
            this.lbFasilitasKelas.AutoSize = true;
            this.lbFasilitasKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFasilitasKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbFasilitasKelas.Location = new System.Drawing.Point(15, 208);
            this.lbFasilitasKelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFasilitasKelas.Name = "lbFasilitasKelas";
            this.lbFasilitasKelas.Size = new System.Drawing.Size(63, 19);
            this.lbFasilitasKelas.TabIndex = 51;
            this.lbFasilitasKelas.Text = "Fasilitas";
            // 
            // lbKuotaKelas
            // 
            this.lbKuotaKelas.AutoSize = true;
            this.lbKuotaKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKuotaKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbKuotaKelas.Location = new System.Drawing.Point(15, 169);
            this.lbKuotaKelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKuotaKelas.Name = "lbKuotaKelas";
            this.lbKuotaKelas.Size = new System.Drawing.Size(50, 19);
            this.lbKuotaKelas.TabIndex = 49;
            this.lbKuotaKelas.Text = "Kuota";
            // 
            // tbBiayaKelas
            // 
            this.tbBiayaKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBiayaKelas.Location = new System.Drawing.Point(119, 131);
            this.tbBiayaKelas.Margin = new System.Windows.Forms.Padding(4);
            this.tbBiayaKelas.Name = "tbBiayaKelas";
            this.tbBiayaKelas.Size = new System.Drawing.Size(256, 27);
            this.tbBiayaKelas.TabIndex = 48;
            // 
            // lbBiaya
            // 
            this.lbBiaya.AutoSize = true;
            this.lbBiaya.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBiaya.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbBiaya.Location = new System.Drawing.Point(15, 134);
            this.lbBiaya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBiaya.Name = "lbBiaya";
            this.lbBiaya.Size = new System.Drawing.Size(44, 19);
            this.lbBiaya.TabIndex = 47;
            this.lbBiaya.Text = "Biaya";
            // 
            // tbNamaKelas
            // 
            this.tbNamaKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNamaKelas.Location = new System.Drawing.Point(119, 95);
            this.tbNamaKelas.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamaKelas.MaxLength = 30;
            this.tbNamaKelas.Name = "tbNamaKelas";
            this.tbNamaKelas.Size = new System.Drawing.Size(256, 27);
            this.tbNamaKelas.TabIndex = 46;
            // 
            // lbNamaKelas
            // 
            this.lbNamaKelas.AutoSize = true;
            this.lbNamaKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNamaKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbNamaKelas.Location = new System.Drawing.Point(15, 98);
            this.lbNamaKelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNamaKelas.Name = "lbNamaKelas";
            this.lbNamaKelas.Size = new System.Drawing.Size(88, 19);
            this.lbNamaKelas.TabIndex = 45;
            this.lbNamaKelas.Text = "Nama Kelas";
            // 
            // tbNomorKelas
            // 
            this.tbNomorKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNomorKelas.Location = new System.Drawing.Point(119, 60);
            this.tbNomorKelas.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomorKelas.MaxLength = 5;
            this.tbNomorKelas.Name = "tbNomorKelas";
            this.tbNomorKelas.Size = new System.Drawing.Size(256, 27);
            this.tbNomorKelas.TabIndex = 44;
            // 
            // lbNomorKelas
            // 
            this.lbNomorKelas.AutoSize = true;
            this.lbNomorKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomorKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbNomorKelas.Location = new System.Drawing.Point(15, 63);
            this.lbNomorKelas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomorKelas.Name = "lbNomorKelas";
            this.lbNomorKelas.Size = new System.Drawing.Size(83, 19);
            this.lbNomorKelas.TabIndex = 43;
            this.lbNomorKelas.Text = "Kode Kelas";
            // 
            // tbKuotaKelas
            // 
            this.tbKuotaKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKuotaKelas.Location = new System.Drawing.Point(119, 166);
            this.tbKuotaKelas.Margin = new System.Windows.Forms.Padding(4);
            this.tbKuotaKelas.Name = "tbKuotaKelas";
            this.tbKuotaKelas.Size = new System.Drawing.Size(256, 27);
            this.tbKuotaKelas.TabIndex = 50;
            // 
            // FormInputKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(398, 374);
            this.Controls.Add(this.clbFasilitas);
            this.Controls.Add(this.lbJudulInputKelas);
            this.Controls.Add(this.btBatalKelas);
            this.Controls.Add(this.btSimpanKelas);
            this.Controls.Add(this.lbFasilitasKelas);
            this.Controls.Add(this.tbKuotaKelas);
            this.Controls.Add(this.lbKuotaKelas);
            this.Controls.Add(this.tbBiayaKelas);
            this.Controls.Add(this.lbBiaya);
            this.Controls.Add(this.tbNamaKelas);
            this.Controls.Add(this.lbNamaKelas);
            this.Controls.Add(this.tbNomorKelas);
            this.Controls.Add(this.lbNomorKelas);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "FormInputKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Kelas";
            this.Load += new System.EventHandler(this.FormInputKelas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbFasilitas;
        private System.Windows.Forms.Label lbJudulInputKelas;
        private System.Windows.Forms.Button btBatalKelas;
        private System.Windows.Forms.Button btSimpanKelas;
        private System.Windows.Forms.Label lbFasilitasKelas;
        private System.Windows.Forms.Label lbKuotaKelas;
        private System.Windows.Forms.TextBox tbBiayaKelas;
        private System.Windows.Forms.Label lbBiaya;
        private System.Windows.Forms.TextBox tbNamaKelas;
        private System.Windows.Forms.Label lbNamaKelas;
        private System.Windows.Forms.TextBox tbNomorKelas;
        private System.Windows.Forms.Label lbNomorKelas;
        private System.Windows.Forms.TextBox tbKuotaKelas;
    }
}