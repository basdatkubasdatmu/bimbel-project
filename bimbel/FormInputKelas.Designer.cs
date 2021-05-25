
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
            this.tbKuotaKelas = new System.Windows.Forms.TextBox();
            this.lbKuotaKelas = new System.Windows.Forms.Label();
            this.tbBiayaKelas = new System.Windows.Forms.TextBox();
            this.lbBiaya = new System.Windows.Forms.Label();
            this.tbNamaKelas = new System.Windows.Forms.TextBox();
            this.lbNamaKelas = new System.Windows.Forms.Label();
            this.tbNomorKelas = new System.Windows.Forms.TextBox();
            this.lbNomorKelas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbFasilitas
            // 
            this.clbFasilitas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbFasilitas.FormattingEnabled = true;
            this.clbFasilitas.Items.AddRange(new object[] {
            "Full AC",
            "Modul gratis",
            "3 kali pertemuan/minggu",
            "2 kali pertemuan/minggu"});
            this.clbFasilitas.Location = new System.Drawing.Point(139, 165);
            this.clbFasilitas.Name = "clbFasilitas";
            this.clbFasilitas.Size = new System.Drawing.Size(200, 124);
            this.clbFasilitas.TabIndex = 55;
            // 
            // lbJudulInputKelas
            // 
            this.lbJudulInputKelas.AutoSize = true;
            this.lbJudulInputKelas.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulInputKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbJudulInputKelas.Location = new System.Drawing.Point(12, 9);
            this.lbJudulInputKelas.Name = "lbJudulInputKelas";
            this.lbJudulInputKelas.Size = new System.Drawing.Size(166, 29);
            this.lbJudulInputKelas.TabIndex = 54;
            this.lbJudulInputKelas.Text = "Input Data Kelas";
            // 
            // btBatalKelas
            // 
            this.btBatalKelas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBatalKelas.Location = new System.Drawing.Point(218, 301);
            this.btBatalKelas.Name = "btBatalKelas";
            this.btBatalKelas.Size = new System.Drawing.Size(79, 39);
            this.btBatalKelas.TabIndex = 53;
            this.btBatalKelas.Text = "BATAL";
            this.btBatalKelas.UseVisualStyleBackColor = true;
            this.btBatalKelas.Click += new System.EventHandler(this.btBatalKelas_Click);
            // 
            // btSimpanKelas
            // 
            this.btSimpanKelas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSimpanKelas.Location = new System.Drawing.Point(303, 301);
            this.btSimpanKelas.Name = "btSimpanKelas";
            this.btSimpanKelas.Size = new System.Drawing.Size(79, 39);
            this.btSimpanKelas.TabIndex = 52;
            this.btSimpanKelas.Text = "SIMPAN";
            this.btSimpanKelas.UseVisualStyleBackColor = true;
            this.btSimpanKelas.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // lbFasilitasKelas
            // 
            this.lbFasilitasKelas.AutoSize = true;
            this.lbFasilitasKelas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFasilitasKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbFasilitasKelas.Location = new System.Drawing.Point(12, 164);
            this.lbFasilitasKelas.Name = "lbFasilitasKelas";
            this.lbFasilitasKelas.Size = new System.Drawing.Size(57, 20);
            this.lbFasilitasKelas.TabIndex = 51;
            this.lbFasilitasKelas.Text = "Fasilitas";
            // 
            // tbKuotaKelas
            // 
            this.tbKuotaKelas.Location = new System.Drawing.Point(139, 135);
            this.tbKuotaKelas.Name = "tbKuotaKelas";
            this.tbKuotaKelas.Size = new System.Drawing.Size(200, 23);
            this.tbKuotaKelas.TabIndex = 50;
            // 
            // lbKuotaKelas
            // 
            this.lbKuotaKelas.AutoSize = true;
            this.lbKuotaKelas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKuotaKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbKuotaKelas.Location = new System.Drawing.Point(12, 135);
            this.lbKuotaKelas.Name = "lbKuotaKelas";
            this.lbKuotaKelas.Size = new System.Drawing.Size(43, 20);
            this.lbKuotaKelas.TabIndex = 49;
            this.lbKuotaKelas.Text = "Kuota";
            // 
            // tbBiayaKelas
            // 
            this.tbBiayaKelas.Location = new System.Drawing.Point(139, 106);
            this.tbBiayaKelas.Name = "tbBiayaKelas";
            this.tbBiayaKelas.Size = new System.Drawing.Size(200, 23);
            this.tbBiayaKelas.TabIndex = 48;
            // 
            // lbBiaya
            // 
            this.lbBiaya.AutoSize = true;
            this.lbBiaya.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBiaya.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbBiaya.Location = new System.Drawing.Point(12, 106);
            this.lbBiaya.Name = "lbBiaya";
            this.lbBiaya.Size = new System.Drawing.Size(42, 20);
            this.lbBiaya.TabIndex = 47;
            this.lbBiaya.Text = "Biaya";
            // 
            // tbNamaKelas
            // 
            this.tbNamaKelas.Location = new System.Drawing.Point(139, 77);
            this.tbNamaKelas.Name = "tbNamaKelas";
            this.tbNamaKelas.Size = new System.Drawing.Size(200, 23);
            this.tbNamaKelas.TabIndex = 46;
            // 
            // lbNamaKelas
            // 
            this.lbNamaKelas.AutoSize = true;
            this.lbNamaKelas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNamaKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbNamaKelas.Location = new System.Drawing.Point(12, 77);
            this.lbNamaKelas.Name = "lbNamaKelas";
            this.lbNamaKelas.Size = new System.Drawing.Size(81, 20);
            this.lbNamaKelas.TabIndex = 45;
            this.lbNamaKelas.Text = "Nama Kelas";
            // 
            // tbNomorKelas
            // 
            this.tbNomorKelas.Location = new System.Drawing.Point(139, 46);
            this.tbNomorKelas.Name = "tbNomorKelas";
            this.tbNomorKelas.Size = new System.Drawing.Size(200, 23);
            this.tbNomorKelas.TabIndex = 44;
            // 
            // lbNomorKelas
            // 
            this.lbNomorKelas.AutoSize = true;
            this.lbNomorKelas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomorKelas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbNomorKelas.Location = new System.Drawing.Point(12, 46);
            this.lbNomorKelas.Name = "lbNomorKelas";
            this.lbNomorKelas.Size = new System.Drawing.Size(87, 20);
            this.lbNomorKelas.TabIndex = 43;
            this.lbNomorKelas.Text = "Nomor Kelas";
            // 
            // FormInputKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 352);
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
            this.Name = "FormInputKelas";
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
        private System.Windows.Forms.TextBox tbKuotaKelas;
        private System.Windows.Forms.Label lbKuotaKelas;
        private System.Windows.Forms.TextBox tbBiayaKelas;
        private System.Windows.Forms.Label lbBiaya;
        private System.Windows.Forms.TextBox tbNamaKelas;
        private System.Windows.Forms.Label lbNamaKelas;
        private System.Windows.Forms.TextBox tbNomorKelas;
        private System.Windows.Forms.Label lbNomorKelas;
    }
}