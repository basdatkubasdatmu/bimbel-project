
namespace bimbel
{
    partial class FormPegawai
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
            this.btHapusPegawai = new System.Windows.Forms.Button();
            this.btEditPegawai = new System.Windows.Forms.Button();
            this.btTambahPegawai = new System.Windows.Forms.Button();
            this.btRefreshPegawai = new System.Windows.Forms.Button();
            this.lbJudulDataPegawai = new System.Windows.Forms.Label();
            this.dgvPegawai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // btHapusPegawai
            // 
            this.btHapusPegawai.Location = new System.Drawing.Point(713, 315);
            this.btHapusPegawai.Name = "btHapusPegawai";
            this.btHapusPegawai.Size = new System.Drawing.Size(75, 23);
            this.btHapusPegawai.TabIndex = 58;
            this.btHapusPegawai.Text = "Hapus";
            this.btHapusPegawai.UseVisualStyleBackColor = true;
            this.btHapusPegawai.Click += new System.EventHandler(this.btHapusPegawai_Click);
            // 
            // btEditPegawai
            // 
            this.btEditPegawai.Location = new System.Drawing.Point(551, 315);
            this.btEditPegawai.Name = "btEditPegawai";
            this.btEditPegawai.Size = new System.Drawing.Size(75, 23);
            this.btEditPegawai.TabIndex = 57;
            this.btEditPegawai.Text = "Edit";
            this.btEditPegawai.UseVisualStyleBackColor = true;
            // 
            // btTambahPegawai
            // 
            this.btTambahPegawai.Location = new System.Drawing.Point(470, 315);
            this.btTambahPegawai.Name = "btTambahPegawai";
            this.btTambahPegawai.Size = new System.Drawing.Size(75, 23);
            this.btTambahPegawai.TabIndex = 56;
            this.btTambahPegawai.Text = "Tambah";
            this.btTambahPegawai.UseVisualStyleBackColor = true;
            this.btTambahPegawai.Click += new System.EventHandler(this.btTambahPegawai_Click);
            // 
            // btRefreshPegawai
            // 
            this.btRefreshPegawai.Location = new System.Drawing.Point(632, 315);
            this.btRefreshPegawai.Name = "btRefreshPegawai";
            this.btRefreshPegawai.Size = new System.Drawing.Size(75, 23);
            this.btRefreshPegawai.TabIndex = 55;
            this.btRefreshPegawai.Text = "Refresh";
            this.btRefreshPegawai.UseVisualStyleBackColor = true;
            this.btRefreshPegawai.Click += new System.EventHandler(this.btRefreshPegawai_Click);
            // 
            // lbJudulDataPegawai
            // 
            this.lbJudulDataPegawai.AutoSize = true;
            this.lbJudulDataPegawai.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulDataPegawai.Location = new System.Drawing.Point(12, 9);
            this.lbJudulDataPegawai.Name = "lbJudulDataPegawai";
            this.lbJudulDataPegawai.Size = new System.Drawing.Size(131, 25);
            this.lbJudulDataPegawai.TabIndex = 54;
            this.lbJudulDataPegawai.Text = "Data Pegawai";
            // 
            // dgvPegawai
            // 
            this.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawai.Location = new System.Drawing.Point(12, 37);
            this.dgvPegawai.Name = "dgvPegawai";
            this.dgvPegawai.RowTemplate.Height = 25;
            this.dgvPegawai.Size = new System.Drawing.Size(776, 256);
            this.dgvPegawai.TabIndex = 53;
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.btHapusPegawai);
            this.Controls.Add(this.btEditPegawai);
            this.Controls.Add(this.btTambahPegawai);
            this.Controls.Add(this.btRefreshPegawai);
            this.Controls.Add(this.lbJudulDataPegawai);
            this.Controls.Add(this.dgvPegawai);
            this.Name = "FormPegawai";
            this.Text = "Form Pegawai";
            this.Load += new System.EventHandler(this.FormPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHapusPegawai;
        private System.Windows.Forms.Button btEditPegawai;
        private System.Windows.Forms.Button btTambahPegawai;
        private System.Windows.Forms.Button btRefreshPegawai;
        private System.Windows.Forms.Label lbJudulDataPegawai;
        private System.Windows.Forms.DataGridView dgvPegawai;
    }
}