
namespace bimbel
{
    partial class FormKelas
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
            this.btHapusKelas = new System.Windows.Forms.Button();
            this.btEditKelas = new System.Windows.Forms.Button();
            this.btTambahKelas = new System.Windows.Forms.Button();
            this.btRefreshKelas = new System.Windows.Forms.Button();
            this.lbJudulDataKelas = new System.Windows.Forms.Label();
            this.dgvKelas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btHapusKelas
            // 
            this.btHapusKelas.Location = new System.Drawing.Point(713, 312);
            this.btHapusKelas.Name = "btHapusKelas";
            this.btHapusKelas.Size = new System.Drawing.Size(75, 23);
            this.btHapusKelas.TabIndex = 52;
            this.btHapusKelas.Text = "Hapus";
            this.btHapusKelas.UseVisualStyleBackColor = true;
            // 
            // btEditKelas
            // 
            this.btEditKelas.Location = new System.Drawing.Point(551, 312);
            this.btEditKelas.Name = "btEditKelas";
            this.btEditKelas.Size = new System.Drawing.Size(75, 23);
            this.btEditKelas.TabIndex = 51;
            this.btEditKelas.Text = "Edit";
            this.btEditKelas.UseVisualStyleBackColor = true;
            // 
            // btTambahKelas
            // 
            this.btTambahKelas.Location = new System.Drawing.Point(470, 312);
            this.btTambahKelas.Name = "btTambahKelas";
            this.btTambahKelas.Size = new System.Drawing.Size(75, 23);
            this.btTambahKelas.TabIndex = 50;
            this.btTambahKelas.Text = "Tambah";
            this.btTambahKelas.UseVisualStyleBackColor = true;
            // 
            // btRefreshKelas
            // 
            this.btRefreshKelas.Location = new System.Drawing.Point(632, 312);
            this.btRefreshKelas.Name = "btRefreshKelas";
            this.btRefreshKelas.Size = new System.Drawing.Size(75, 23);
            this.btRefreshKelas.TabIndex = 49;
            this.btRefreshKelas.Text = "Refresh";
            this.btRefreshKelas.UseVisualStyleBackColor = true;
            // 
            // lbJudulDataKelas
            // 
            this.lbJudulDataKelas.AutoSize = true;
            this.lbJudulDataKelas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulDataKelas.Location = new System.Drawing.Point(12, 9);
            this.lbJudulDataKelas.Name = "lbJudulDataKelas";
            this.lbJudulDataKelas.Size = new System.Drawing.Size(103, 25);
            this.lbJudulDataKelas.TabIndex = 48;
            this.lbJudulDataKelas.Text = "Data Kelas";
            // 
            // dgvKelas
            // 
            this.dgvKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKelas.Location = new System.Drawing.Point(12, 37);
            this.dgvKelas.Name = "dgvKelas";
            this.dgvKelas.RowTemplate.Height = 25;
            this.dgvKelas.Size = new System.Drawing.Size(776, 256);
            this.dgvKelas.TabIndex = 47;
            // 
            // FormKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 346);
            this.Controls.Add(this.btHapusKelas);
            this.Controls.Add(this.btEditKelas);
            this.Controls.Add(this.btTambahKelas);
            this.Controls.Add(this.btRefreshKelas);
            this.Controls.Add(this.lbJudulDataKelas);
            this.Controls.Add(this.dgvKelas);
            this.Name = "FormKelas";
            this.Text = "Form Kelas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHapusKelas;
        private System.Windows.Forms.Button btEditKelas;
        private System.Windows.Forms.Button btTambahKelas;
        private System.Windows.Forms.Button btRefreshKelas;
        private System.Windows.Forms.Label lbJudulDataKelas;
        private System.Windows.Forms.DataGridView dgvKelas;
    }
}