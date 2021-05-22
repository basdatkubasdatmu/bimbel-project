
namespace bimbel
{
    partial class formInputPengajar
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
            this.lblNoPengajar = new System.Windows.Forms.Label();
            this.lblnoPegawai = new System.Windows.Forms.Label();
            this.lblKodePelajaran = new System.Windows.Forms.Label();
            this.txtNoPengajar = new System.Windows.Forms.TextBox();
            this.txtKodePelajaran = new System.Windows.Forms.TextBox();
            this.txtNoPegawai = new System.Windows.Forms.TextBox();
            this.bttnBatal = new System.Windows.Forms.Button();
            this.bttnSimpan = new System.Windows.Forms.Button();
            this.lblInputPengajar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoPengajar
            // 
            this.lblNoPengajar.AutoSize = true;
            this.lblNoPengajar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoPengajar.Location = new System.Drawing.Point(30, 95);
            this.lblNoPengajar.Name = "lblNoPengajar";
            this.lblNoPengajar.Size = new System.Drawing.Size(117, 20);
            this.lblNoPengajar.TabIndex = 0;
            this.lblNoPengajar.Text = "Nomor Pengajar";
            // 
            // lblnoPegawai
            // 
            this.lblnoPegawai.AutoSize = true;
            this.lblnoPegawai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnoPegawai.Location = new System.Drawing.Point(30, 154);
            this.lblnoPegawai.Name = "lblnoPegawai";
            this.lblnoPegawai.Size = new System.Drawing.Size(115, 20);
            this.lblnoPegawai.TabIndex = 1;
            this.lblnoPegawai.Text = "Nomor Pegawai";
            // 
            // lblKodePelajaran
            // 
            this.lblKodePelajaran.AutoSize = true;
            this.lblKodePelajaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKodePelajaran.Location = new System.Drawing.Point(30, 197);
            this.lblKodePelajaran.Name = "lblKodePelajaran";
            this.lblKodePelajaran.Size = new System.Drawing.Size(112, 21);
            this.lblKodePelajaran.TabIndex = 2;
            this.lblKodePelajaran.Text = "Kode Pelajaran";
            // 
            // txtNoPengajar
            // 
            this.txtNoPengajar.Location = new System.Drawing.Point(211, 92);
            this.txtNoPengajar.Name = "txtNoPengajar";
            this.txtNoPengajar.Size = new System.Drawing.Size(291, 23);
            this.txtNoPengajar.TabIndex = 9;
            // 
            // txtKodePelajaran
            // 
            this.txtKodePelajaran.Location = new System.Drawing.Point(211, 199);
            this.txtKodePelajaran.Name = "txtKodePelajaran";
            this.txtKodePelajaran.Size = new System.Drawing.Size(291, 23);
            this.txtKodePelajaran.TabIndex = 10;
            // 
            // txtNoPegawai
            // 
            this.txtNoPegawai.Location = new System.Drawing.Point(211, 151);
            this.txtNoPegawai.Name = "txtNoPegawai";
            this.txtNoPegawai.Size = new System.Drawing.Size(291, 23);
            this.txtNoPegawai.TabIndex = 11;
            // 
            // bttnBatal
            // 
            this.bttnBatal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnBatal.Location = new System.Drawing.Point(324, 259);
            this.bttnBatal.Name = "bttnBatal";
            this.bttnBatal.Size = new System.Drawing.Size(103, 40);
            this.bttnBatal.TabIndex = 15;
            this.bttnBatal.Text = "Batal";
            this.bttnBatal.UseVisualStyleBackColor = true;
            // 
            // bttnSimpan
            // 
            this.bttnSimpan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnSimpan.Location = new System.Drawing.Point(433, 259);
            this.bttnSimpan.Name = "bttnSimpan";
            this.bttnSimpan.Size = new System.Drawing.Size(106, 40);
            this.bttnSimpan.TabIndex = 16;
            this.bttnSimpan.Text = "Simpan";
            this.bttnSimpan.UseVisualStyleBackColor = true;
            // 
            // lblInputPengajar
            // 
            this.lblInputPengajar.AutoSize = true;
            this.lblInputPengajar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputPengajar.Location = new System.Drawing.Point(30, 27);
            this.lblInputPengajar.Name = "lblInputPengajar";
            this.lblInputPengajar.Size = new System.Drawing.Size(144, 25);
            this.lblInputPengajar.TabIndex = 17;
            this.lblInputPengajar.Text = "Input Pengajar";
            // 
            // formInputPengajar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 311);
            this.Controls.Add(this.lblInputPengajar);
            this.Controls.Add(this.bttnSimpan);
            this.Controls.Add(this.bttnBatal);
            this.Controls.Add(this.txtNoPegawai);
            this.Controls.Add(this.txtKodePelajaran);
            this.Controls.Add(this.txtNoPengajar);
            this.Controls.Add(this.lblKodePelajaran);
            this.Controls.Add(this.lblnoPegawai);
            this.Controls.Add(this.lblNoPengajar);
            this.Name = "formInputPengajar";
            this.Text = "Input Pengajar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoPengajar;
        private System.Windows.Forms.Label lblnoPegawai;
        private System.Windows.Forms.Label lblKodePelajaran;
        private System.Windows.Forms.TextBox txtNoPengajar;
        private System.Windows.Forms.TextBox txtKodePelajaran;
        private System.Windows.Forms.TextBox txtNoPegawai;
        private System.Windows.Forms.Button bttnBatal;
        private System.Windows.Forms.Button bttnSimpan;
        private System.Windows.Forms.Label lblInputPengajar;
    }
}