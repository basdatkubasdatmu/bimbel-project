
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
            this.btHapusKelas.BackColor = System.Drawing.SystemColors.Info;
            this.btHapusKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHapusKelas.Location = new System.Drawing.Point(649, 337);
            this.btHapusKelas.Name = "btHapusKelas";
            this.btHapusKelas.Size = new System.Drawing.Size(90, 44);
            this.btHapusKelas.TabIndex = 52;
            this.btHapusKelas.Text = "HAPUS";
            this.btHapusKelas.UseVisualStyleBackColor = false;
            this.btHapusKelas.Click += new System.EventHandler(this.btHapusKelas_Click);
            // 
            // btEditKelas
            // 
            this.btEditKelas.BackColor = System.Drawing.SystemColors.Info;
            this.btEditKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditKelas.Location = new System.Drawing.Point(457, 337);
            this.btEditKelas.Name = "btEditKelas";
            this.btEditKelas.Size = new System.Drawing.Size(90, 44);
            this.btEditKelas.TabIndex = 51;
            this.btEditKelas.Text = "EDIT";
            this.btEditKelas.UseVisualStyleBackColor = false;
            this.btEditKelas.Click += new System.EventHandler(this.btEditKelas_Click);
            // 
            // btTambahKelas
            // 
            this.btTambahKelas.BackColor = System.Drawing.SystemColors.Info;
            this.btTambahKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTambahKelas.Location = new System.Drawing.Point(553, 337);
            this.btTambahKelas.Name = "btTambahKelas";
            this.btTambahKelas.Size = new System.Drawing.Size(90, 44);
            this.btTambahKelas.TabIndex = 50;
            this.btTambahKelas.Text = "TAMBAH";
            this.btTambahKelas.UseVisualStyleBackColor = false;
            this.btTambahKelas.Click += new System.EventHandler(this.btTambahKelas_Click);
            // 
            // btRefreshKelas
            // 
            this.btRefreshKelas.BackColor = System.Drawing.SystemColors.Info;
            this.btRefreshKelas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRefreshKelas.Location = new System.Drawing.Point(361, 337);
            this.btRefreshKelas.Name = "btRefreshKelas";
            this.btRefreshKelas.Size = new System.Drawing.Size(90, 44);
            this.btRefreshKelas.TabIndex = 49;
            this.btRefreshKelas.Text = "REFRESH";
            this.btRefreshKelas.UseVisualStyleBackColor = false;
            this.btRefreshKelas.Click += new System.EventHandler(this.btRefreshKelas_Click);
            // 
            // lbJudulDataKelas
            // 
            this.lbJudulDataKelas.AutoSize = true;
            this.lbJudulDataKelas.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulDataKelas.ForeColor = System.Drawing.SystemColors.Info;
            this.lbJudulDataKelas.Location = new System.Drawing.Point(12, 9);
            this.lbJudulDataKelas.Name = "lbJudulDataKelas";
            this.lbJudulDataKelas.Size = new System.Drawing.Size(76, 33);
            this.lbJudulDataKelas.TabIndex = 48;
            this.lbJudulDataKelas.Text = "Kelas";
            // 
            // dgvKelas
            // 
            this.dgvKelas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvKelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKelas.Location = new System.Drawing.Point(19, 46);
            this.dgvKelas.Name = "dgvKelas";
            this.dgvKelas.RowTemplate.Height = 25;
            this.dgvKelas.Size = new System.Drawing.Size(720, 278);
            this.dgvKelas.TabIndex = 47;
            // 
            // FormKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(759, 395);
            this.Controls.Add(this.btHapusKelas);
            this.Controls.Add(this.btEditKelas);
            this.Controls.Add(this.btTambahKelas);
            this.Controls.Add(this.btRefreshKelas);
            this.Controls.Add(this.lbJudulDataKelas);
            this.Controls.Add(this.dgvKelas);
            this.MaximizeBox = false;
            this.Name = "FormKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Kelas";
            this.Load += new System.EventHandler(this.FormKelas_Load);
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