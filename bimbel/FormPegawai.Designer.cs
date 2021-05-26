
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btHapusPegawai = new System.Windows.Forms.Button();
            this.btEditPegawai = new System.Windows.Forms.Button();
            this.btTambahPegawai = new System.Windows.Forms.Button();
            this.btRefreshPegawai = new System.Windows.Forms.Button();
            this.lbJudulDataPegawai = new System.Windows.Forms.Label();
            this.dgvPegawai = new System.Windows.Forms.DataGridView();
            this.nopegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // btHapusPegawai
            // 
            this.btHapusPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btHapusPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHapusPegawai.Location = new System.Drawing.Point(698, 332);
            this.btHapusPegawai.Name = "btHapusPegawai";
            this.btHapusPegawai.Size = new System.Drawing.Size(90, 44);
            this.btHapusPegawai.TabIndex = 58;
            this.btHapusPegawai.Text = "HAPUS";
            this.btHapusPegawai.UseVisualStyleBackColor = false;
            this.btHapusPegawai.Click += new System.EventHandler(this.btHapusPegawai_Click);
            // 
            // btEditPegawai
            // 
            this.btEditPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btEditPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditPegawai.Location = new System.Drawing.Point(506, 332);
            this.btEditPegawai.Name = "btEditPegawai";
            this.btEditPegawai.Size = new System.Drawing.Size(90, 44);
            this.btEditPegawai.TabIndex = 57;
            this.btEditPegawai.Text = "EDIT";
            this.btEditPegawai.UseVisualStyleBackColor = false;
            this.btEditPegawai.Click += new System.EventHandler(this.btEditPegawai_Click);
            // 
            // btTambahPegawai
            // 
            this.btTambahPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btTambahPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btTambahPegawai.Location = new System.Drawing.Point(602, 332);
            this.btTambahPegawai.Name = "btTambahPegawai";
            this.btTambahPegawai.Size = new System.Drawing.Size(90, 44);
            this.btTambahPegawai.TabIndex = 56;
            this.btTambahPegawai.Text = "TAMBAH";
            this.btTambahPegawai.UseVisualStyleBackColor = false;
            this.btTambahPegawai.Click += new System.EventHandler(this.btTambahPegawai_Click);
            // 
            // btRefreshPegawai
            // 
            this.btRefreshPegawai.BackColor = System.Drawing.SystemColors.Info;
            this.btRefreshPegawai.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRefreshPegawai.Location = new System.Drawing.Point(410, 332);
            this.btRefreshPegawai.Name = "btRefreshPegawai";
            this.btRefreshPegawai.Size = new System.Drawing.Size(90, 44);
            this.btRefreshPegawai.TabIndex = 55;
            this.btRefreshPegawai.Text = "REFRESH";
            this.btRefreshPegawai.UseVisualStyleBackColor = false;
            this.btRefreshPegawai.Click += new System.EventHandler(this.btRefreshPegawai_Click);
            // 
            // lbJudulDataPegawai
            // 
            this.lbJudulDataPegawai.AutoSize = true;
            this.lbJudulDataPegawai.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulDataPegawai.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbJudulDataPegawai.Location = new System.Drawing.Point(12, 9);
            this.lbJudulDataPegawai.Name = "lbJudulDataPegawai";
            this.lbJudulDataPegawai.Size = new System.Drawing.Size(113, 33);
            this.lbJudulDataPegawai.TabIndex = 54;
            this.lbJudulDataPegawai.Text = "Pegawai";
            // 
            // dgvPegawai
            // 
            this.dgvPegawai.AllowUserToAddRows = false;
            this.dgvPegawai.AllowUserToDeleteRows = false;
            this.dgvPegawai.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPegawai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nopegawai,
            this.nama,
            this.jenisKelamin,
            this.noHp,
            this.email,
            this.posisi});
            this.dgvPegawai.Location = new System.Drawing.Point(12, 43);
            this.dgvPegawai.Name = "dgvPegawai";
            this.dgvPegawai.RowHeadersWidth = 51;
            this.dgvPegawai.RowTemplate.Height = 25;
            this.dgvPegawai.Size = new System.Drawing.Size(776, 283);
            this.dgvPegawai.TabIndex = 53;
            // 
            // nopegawai
            // 
            this.nopegawai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nopegawai.DataPropertyName = "nopegawai";
            this.nopegawai.HeaderText = "No Pegawai";
            this.nopegawai.MinimumWidth = 6;
            this.nopegawai.Name = "nopegawai";
            this.nopegawai.Width = 114;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 125;
            // 
            // jenisKelamin
            // 
            this.jenisKelamin.DataPropertyName = "jenisKelamin";
            this.jenisKelamin.HeaderText = "Jenis Kelamin";
            this.jenisKelamin.MinimumWidth = 6;
            this.jenisKelamin.Name = "jenisKelamin";
            this.jenisKelamin.Width = 125;
            // 
            // noHp
            // 
            this.noHp.DataPropertyName = "noHp";
            this.noHp.HeaderText = "No HP";
            this.noHp.MinimumWidth = 6;
            this.noHp.Name = "noHp";
            this.noHp.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // posisi
            // 
            this.posisi.DataPropertyName = "posisi";
            this.posisi.HeaderText = "Posisi";
            this.posisi.MinimumWidth = 6;
            this.posisi.Name = "posisi";
            this.posisi.Width = 125;
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btHapusPegawai);
            this.Controls.Add(this.btEditPegawai);
            this.Controls.Add(this.btTambahPegawai);
            this.Controls.Add(this.btRefreshPegawai);
            this.Controls.Add(this.lbJudulDataPegawai);
            this.Controls.Add(this.dgvPegawai);
            this.MaximizeBox = false;
            this.Name = "FormPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nopegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn posisi;
    }
}