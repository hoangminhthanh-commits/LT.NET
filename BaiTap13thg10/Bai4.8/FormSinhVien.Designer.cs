namespace Bai4._8
{
    partial class FormSinhVien
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
            lblTienTrinh = new Label();
            lblPhanTram = new Label();
            lblDanhSach = new Label();
            progressBar1 = new ProgressBar();
            btnNapDuLieu = new Button();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // lblTienTrinh
            // 
            lblTienTrinh.AutoSize = true;
            lblTienTrinh.Location = new Point(35, 58);
            lblTienTrinh.Name = "lblTienTrinh";
            lblTienTrinh.Size = new Size(74, 20);
            lblTienTrinh.TabIndex = 0;
            lblTienTrinh.Text = "Tiến trình:";
            // 
            // lblPhanTram
            // 
            lblPhanTram.AutoSize = true;
            lblPhanTram.Location = new Point(562, 144);
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(29, 20);
            lblPhanTram.TabIndex = 1;
            lblPhanTram.Text = "0%";
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(35, 237);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(168, 20);
            lblDanhSach.TabIndex = 2;
            lblDanhSach.Text = "DANH SÁCH SINH VIÊN";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(35, 97);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(614, 44);
            progressBar1.TabIndex = 3;
            // 
            // btnNapDuLieu
            // 
            btnNapDuLieu.Location = new Point(36, 178);
            btnNapDuLieu.Name = "btnNapDuLieu";
            btnNapDuLieu.Size = new Size(167, 42);
            btnNapDuLieu.TabIndex = 4;
            btnNapDuLieu.Text = "Nạp dữ liệu";
            btnNapDuLieu.UseVisualStyleBackColor = true;
            btnNapDuLieu.Click += btnNapDuLieu_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoTen, colLop });
            dgvSinhVien.Location = new Point(35, 291);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(428, 188);
            dgvSinhVien.TabIndex = 5;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.Width = 125;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.Width = 125;
            // 
            // colLop
            // 
            colLop.DataPropertyName = "Lop";
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 6;
            colLop.Name = "colLop";
            colLop.Width = 125;
            // 
            // FormSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 525);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnNapDuLieu);
            Controls.Add(progressBar1);
            Controls.Add(lblDanhSach);
            Controls.Add(lblPhanTram);
            Controls.Add(lblTienTrinh);
            Name = "FormSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nạp dữ liệu sinh viên";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTienTrinh;
        private Label lblPhanTram;
        private Label lblDanhSach;
        private ProgressBar progressBar1;
        private Button btnNapDuLieu;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colLop;
    }
}