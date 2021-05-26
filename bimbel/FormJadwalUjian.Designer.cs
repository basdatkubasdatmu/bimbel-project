
namespace bimbel
{
    partial class FormJadwalUjian
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvJadwalUjian = new System.Windows.Forms.DataGridView();
            this.kodeUjian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePelajaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMulai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalUjian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jadwal Ujian";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(589, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "TAMBAH";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(674, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "HAPUS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(418, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "REFRESH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(504, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvJadwalUjian
            // 
            this.dgvJadwalUjian.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvJadwalUjian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJadwalUjian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeUjian,
            this.nama,
            this.kodePelajaran,
            this.tanggal,
            this.jamMulai,
            this.durasi});
            this.dgvJadwalUjian.Location = new System.Drawing.Point(16, 46);
            this.dgvJadwalUjian.Name = "dgvJadwalUjian";
            this.dgvJadwalUjian.RowTemplate.Height = 25;
            this.dgvJadwalUjian.Size = new System.Drawing.Size(737, 295);
            this.dgvJadwalUjian.TabIndex = 12;
            // 
            // kodeUjian
            // 
            this.kodeUjian.DataPropertyName = "kodeujian";
            this.kodeUjian.HeaderText = "Kode Ujian";
            this.kodeUjian.Name = "kodeUjian";
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            // 
            // kodePelajaran
            // 
            this.kodePelajaran.DataPropertyName = "kodePelajaran";
            this.kodePelajaran.HeaderText = "Kode Pelajaran";
            this.kodePelajaran.Name = "kodePelajaran";
            // 
            // tanggal
            // 
            this.tanggal.DataPropertyName = "tanggal";
            this.tanggal.HeaderText = "Tanggal Ujian";
            this.tanggal.Name = "tanggal";
            // 
            // jamMulai
            // 
            this.jamMulai.DataPropertyName = "jamMulai";
            this.jamMulai.HeaderText = "Jam Mulai";
            this.jamMulai.Name = "jamMulai";
            // 
            // durasi
            // 
            this.durasi.DataPropertyName = "durasi";
            this.durasi.HeaderText = "Durasi";
            this.durasi.Name = "durasi";
            // 
            // FormJadwalUjian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(770, 409);
            this.Controls.Add(this.dgvJadwalUjian);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormJadwalUjian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jadwal Ujian";
            this.Load += new System.EventHandler(this.FormJadwalUjian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJadwalUjian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvJadwalUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeUjian;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePelajaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMulai;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasi;
    }
}