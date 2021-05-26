
namespace bimbel
{
    partial class FormRuangZoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRuang = new System.Windows.Forms.DataGridView();
            this.txtRuang = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.kodeZoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRuang
            // 
            this.dgvRuang.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRuang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRuang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeZoom,
            this.link,
            this.meetingId,
            this.passcode});
            this.dgvRuang.Location = new System.Drawing.Point(12, 51);
            this.dgvRuang.Name = "dgvRuang";
            this.dgvRuang.RowTemplate.Height = 25;
            this.dgvRuang.Size = new System.Drawing.Size(711, 304);
            this.dgvRuang.TabIndex = 14;
            // 
            // txtRuang
            // 
            this.txtRuang.AutoSize = true;
            this.txtRuang.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRuang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtRuang.Location = new System.Drawing.Point(12, 9);
            this.txtRuang.Name = "txtRuang";
            this.txtRuang.Size = new System.Drawing.Size(161, 33);
            this.txtRuang.TabIndex = 15;
            this.txtRuang.Text = "Ruang Zoom";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.Info;
            this.btnTambah.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD

=======
>>>>>>> 18e187e3ac2e5d30b4940d2d1290be62609fc40f
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(603, 367);
            this.btnTambah.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTambah.Location = new System.Drawing.Point(602, 361);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 44);
            this.btnTambah.TabIndex = 21;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.Info;
            this.btnHapus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(699, 367);
            this.btnHapus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHapus.Location = new System.Drawing.Point(698, 361);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 44);
            this.btnHapus.TabIndex = 20;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(411, 367);
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(410, 361);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 44);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(507, 367);
            this.btnEdit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(506, 361);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 44);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // kodeZoom
            // 
            this.kodeZoom.HeaderText = "Kode Zoom";
            this.kodeZoom.Name = "kodeZoom";
            // 
            // link
            // 
            this.link.HeaderText = "Link";
            this.link.Name = "link";
            // 
            // meetingId
            // 
            this.meetingId.HeaderText = "MeetingID";
            this.meetingId.Name = "meetingId";
            // 
            // passcode
            // 
            this.passcode.HeaderText = "Passcode";
            this.passcode.Name = "passcode";
            // 
            // FormRuangZoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtRuang);
            this.Controls.Add(this.dgvRuang);
            this.MaximizeBox = false;
            this.Name = "FormRuangZoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRuangZoom";
            this.Load += new System.EventHandler(this.FormRuangZoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRuang;
        private System.Windows.Forms.Label txtRuang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeZoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn passcode;
    }
}