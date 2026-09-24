namespace Bai4._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMaSP = new Label();
            lblTenSP = new Label();
            lblGia = new Label();
            txtMaSP = new TextBox();
            txtGia = new TextBox();
            txtTenSP = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            dgvSanPham = new DataGridView();
            colMaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(119, 110);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(53, 20);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã SP:";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(119, 153);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(55, 20);
            lblTenSP.TabIndex = 1;
            lblTenSP.Text = "Tên SP:";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(119, 200);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(34, 20);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(189, 107);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(197, 27);
            txtMaSP.TabIndex = 4;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(189, 200);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(197, 27);
            txtGia.TabIndex = 5;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(189, 150);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(197, 27);
            txtTenSP.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(149, 247);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(263, 247);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colMaSP, colTenSP, colGia });
            dgvSanPham.Location = new Point(119, 308);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(377, 188);
            dgvSanPham.TabIndex = 9;
            // 
            // colMaSP
            // 
            colMaSP.DataPropertyName = "MaSP";
            colMaSP.HeaderText = "Mã SP";
            colMaSP.MinimumWidth = 6;
            colMaSP.Name = "colMaSP";
            colMaSP.Width = 125;
            // 
            // colTenSP
            // 
            colTenSP.DataPropertyName = "TenSP";
            colTenSP.HeaderText = "Tên SP";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            colTenSP.Width = 125;
            // 
            // colGia
            // 
            colGia.DataPropertyName = "Gia";
            colGia.HeaderText = "Giá";
            colGia.MinimumWidth = 6;
            colGia.Name = "colGia";
            colGia.Width = 125;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(dgvSanPham);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenSP);
            Controls.Add(txtGia);
            Controls.Add(txtMaSP);
            Controls.Add(lblGia);
            Controls.Add(lblTenSP);
            Controls.Add(lblMaSP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSP;
        private Label lblTenSP;
        private Label lblGia;
        private TextBox txtMaSP;
        private TextBox txtGia;
        private TextBox txtTenSP;
        private Button btnThem;
        private Button btnXoa;
        private DataGridView dgvSanPham;
        private DataGridViewTextBoxColumn colMaSP;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colGia;
        private ErrorProvider errorProvider;
    }
}
