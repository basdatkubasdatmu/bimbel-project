
namespace bimbel
{
    partial class formDatasiswa
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
            this.dgvSiswa = new System.Windows.Forms.DataGridView();
            this.lblDatasiswa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiswa
            // 
            this.dgvSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiswa.Location = new System.Drawing.Point(27, 77);
            this.dgvSiswa.Name = "dgvSiswa";
            this.dgvSiswa.RowTemplate.Height = 25;
            this.dgvSiswa.Size = new System.Drawing.Size(682, 296);
            this.dgvSiswa.TabIndex = 0;
            // 
            // lblDatasiswa
            // 
            this.lblDatasiswa.AutoSize = true;
            this.lblDatasiswa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDatasiswa.Location = new System.Drawing.Point(27, 26);
            this.lblDatasiswa.Name = "lblDatasiswa";
            this.lblDatasiswa.Size = new System.Drawing.Size(89, 37);
            this.lblDatasiswa.TabIndex = 1;
            this.lblDatasiswa.Text = "Siswa";
            // 
            // formDatasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 396);
            this.Controls.Add(this.lblDatasiswa);
            this.Controls.Add(this.dgvSiswa);
            this.Name = "formDatasiswa";
            this.Text = "Siswa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiswa;
        private System.Windows.Forms.Label lblDatasiswa;
    }
}