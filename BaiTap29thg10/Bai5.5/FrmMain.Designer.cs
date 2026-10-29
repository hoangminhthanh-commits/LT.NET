namespace Bai5._5
{
    partial class FrmMain
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
            pnlAll = new TableLayoutPanel();
            lblTieuDe = new Label();
            pnlMain = new TableLayoutPanel();
            pnlQuanLyVatTu = new TableLayoutPanel();
            pnlTimVatTu = new TableLayoutPanel();
            btnTimVatTu = new Button();
            txtTimVatTu = new TextBox();
            lblTimVatTu = new Label();
            pnlButton = new TableLayoutPanel();
            btnXoaVatTu = new Button();
            btnSuaVatTu = new Button();
            btnThemVatTu = new Button();
            pnlSoLuongTon = new TableLayoutPanel();
            txtSoLuongTon = new TextBox();
            lblSoLuongTon = new Label();
            pnlDVT = new TableLayoutPanel();
            txtDVT = new TextBox();
            lblDVT = new Label();
            pnlTenVatTu = new TableLayoutPanel();
            txtTenVatTu = new TextBox();
            lblTenVatTu = new Label();
            pnlMaVatTu = new TableLayoutPanel();
            lblMaVatTu = new Label();
            txtMaVatTu = new TextBox();
            lblQuanLyVatTu = new Label();
            dgvVatTu = new DataGridView();
            pnlLapPhieuKho = new TableLayoutPanel();
            btnLuuPhieu = new Button();
            btnThemChiTiet = new Button();
            lblTong = new Label();
            lblLapPhieuKho = new Label();
            pnlDonGia = new TableLayoutPanel();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            pnlSoLuong = new TableLayoutPanel();
            txtSoLuong = new TextBox();
            lblSoLuong = new Label();
            pnlVatTu = new TableLayoutPanel();
            cboVatTu = new ComboBox();
            lblVatTu = new Label();
            pnlNCC = new TableLayoutPanel();
            cboNCC = new ComboBox();
            lblNCC = new Label();
            pnlLoai = new TableLayoutPanel();
            lblLoaiPhieu = new Label();
            cboLoaiPhieu = new ComboBox();
            dgvChiTiet = new DataGridView();
            pnlAll.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlQuanLyVatTu.SuspendLayout();
            pnlTimVatTu.SuspendLayout();
            pnlButton.SuspendLayout();
            pnlSoLuongTon.SuspendLayout();
            pnlDVT.SuspendLayout();
            pnlTenVatTu.SuspendLayout();
            pnlMaVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVatTu).BeginInit();
            pnlLapPhieuKho.SuspendLayout();
            pnlDonGia.SuspendLayout();
            pnlSoLuong.SuspendLayout();
            pnlVatTu.SuspendLayout();
            pnlNCC.SuspendLayout();
            pnlLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // pnlAll
            // 
            pnlAll.ColumnCount = 1;
            pnlAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlAll.Controls.Add(lblTieuDe, 0, 0);
            pnlAll.Controls.Add(pnlMain, 0, 1);
            pnlAll.Dock = DockStyle.Fill;
            pnlAll.Location = new Point(0, 0);
            pnlAll.Name = "pnlAll";
            pnlAll.RowCount = 2;
            pnlAll.RowStyles.Add(new RowStyle(SizeType.Percent, 6.3920455F));
            pnlAll.RowStyles.Add(new RowStyle(SizeType.Percent, 93.6079559F));
            pnlAll.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlAll.Size = new Size(952, 704);
            pnlAll.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 12F);
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(946, 45);
            lblTieuDe.TabIndex = 8;
            lblTieuDe.Text = "QUẢN LÝ NHẬP XUẤT KHO";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 2;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlMain.Controls.Add(pnlQuanLyVatTu, 0, 0);
            pnlMain.Controls.Add(pnlLapPhieuKho, 1, 0);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(3, 48);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 1;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlMain.Size = new Size(946, 653);
            pnlMain.TabIndex = 0;
            // 
            // pnlQuanLyVatTu
            // 
            pnlQuanLyVatTu.ColumnCount = 1;
            pnlQuanLyVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlQuanLyVatTu.Controls.Add(pnlTimVatTu, 0, 6);
            pnlQuanLyVatTu.Controls.Add(pnlButton, 0, 5);
            pnlQuanLyVatTu.Controls.Add(pnlSoLuongTon, 0, 4);
            pnlQuanLyVatTu.Controls.Add(pnlDVT, 0, 3);
            pnlQuanLyVatTu.Controls.Add(pnlTenVatTu, 0, 2);
            pnlQuanLyVatTu.Controls.Add(pnlMaVatTu, 0, 1);
            pnlQuanLyVatTu.Controls.Add(lblQuanLyVatTu, 0, 0);
            pnlQuanLyVatTu.Controls.Add(dgvVatTu, 0, 7);
            pnlQuanLyVatTu.Dock = DockStyle.Fill;
            pnlQuanLyVatTu.Location = new Point(3, 3);
            pnlQuanLyVatTu.Name = "pnlQuanLyVatTu";
            pnlQuanLyVatTu.RowCount = 8;
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlQuanLyVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            pnlQuanLyVatTu.Size = new Size(467, 647);
            pnlQuanLyVatTu.TabIndex = 0;
            // 
            // pnlTimVatTu
            // 
            pnlTimVatTu.ColumnCount = 3;
            pnlTimVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTimVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTimVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTimVatTu.Controls.Add(btnTimVatTu, 2, 0);
            pnlTimVatTu.Controls.Add(txtTimVatTu, 1, 0);
            pnlTimVatTu.Controls.Add(lblTimVatTu, 0, 0);
            pnlTimVatTu.Dock = DockStyle.Fill;
            pnlTimVatTu.Location = new Point(3, 266);
            pnlTimVatTu.Name = "pnlTimVatTu";
            pnlTimVatTu.RowCount = 1;
            pnlTimVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTimVatTu.Size = new Size(461, 39);
            pnlTimVatTu.TabIndex = 6;
            // 
            // btnTimVatTu
            // 
            btnTimVatTu.Dock = DockStyle.Fill;
            btnTimVatTu.Location = new Point(371, 3);
            btnTimVatTu.Name = "btnTimVatTu";
            btnTimVatTu.Size = new Size(87, 33);
            btnTimVatTu.TabIndex = 11;
            btnTimVatTu.Text = "Tìm";
            btnTimVatTu.UseVisualStyleBackColor = true;
            btnTimVatTu.Click += btnTimVatTu_Click;
            // 
            // txtTimVatTu
            // 
            txtTimVatTu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTimVatTu.Location = new Point(95, 6);
            txtTimVatTu.Name = "txtTimVatTu";
            txtTimVatTu.Size = new Size(270, 27);
            txtTimVatTu.TabIndex = 10;
            // 
            // lblTimVatTu
            // 
            lblTimVatTu.AutoSize = true;
            lblTimVatTu.Dock = DockStyle.Fill;
            lblTimVatTu.Location = new Point(3, 0);
            lblTimVatTu.Name = "lblTimVatTu";
            lblTimVatTu.Size = new Size(86, 39);
            lblTimVatTu.TabIndex = 8;
            lblTimVatTu.Text = "Tìm:";
            lblTimVatTu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlButton
            // 
            pnlButton.ColumnCount = 3;
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlButton.Controls.Add(btnXoaVatTu, 2, 0);
            pnlButton.Controls.Add(btnSuaVatTu, 1, 0);
            pnlButton.Controls.Add(btnThemVatTu, 0, 0);
            pnlButton.Dock = DockStyle.Fill;
            pnlButton.Location = new Point(3, 221);
            pnlButton.Name = "pnlButton";
            pnlButton.RowCount = 1;
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlButton.Size = new Size(461, 39);
            pnlButton.TabIndex = 5;
            // 
            // btnXoaVatTu
            // 
            btnXoaVatTu.Dock = DockStyle.Fill;
            btnXoaVatTu.Location = new Point(319, 3);
            btnXoaVatTu.Margin = new Padding(13, 3, 13, 3);
            btnXoaVatTu.Name = "btnXoaVatTu";
            btnXoaVatTu.Size = new Size(129, 33);
            btnXoaVatTu.TabIndex = 2;
            btnXoaVatTu.Text = "Xóa";
            btnXoaVatTu.UseVisualStyleBackColor = true;
            btnXoaVatTu.Click += btnXoaVatTu_Click;
            // 
            // btnSuaVatTu
            // 
            btnSuaVatTu.Dock = DockStyle.Fill;
            btnSuaVatTu.Location = new Point(166, 3);
            btnSuaVatTu.Margin = new Padding(13, 3, 13, 3);
            btnSuaVatTu.Name = "btnSuaVatTu";
            btnSuaVatTu.Size = new Size(127, 33);
            btnSuaVatTu.TabIndex = 1;
            btnSuaVatTu.Text = "Sửa";
            btnSuaVatTu.UseVisualStyleBackColor = true;
            btnSuaVatTu.Click += btnSuaVatTu_Click;
            // 
            // btnThemVatTu
            // 
            btnThemVatTu.Dock = DockStyle.Fill;
            btnThemVatTu.Location = new Point(13, 3);
            btnThemVatTu.Margin = new Padding(13, 3, 13, 3);
            btnThemVatTu.Name = "btnThemVatTu";
            btnThemVatTu.Size = new Size(127, 33);
            btnThemVatTu.TabIndex = 0;
            btnThemVatTu.Text = "Thêm";
            btnThemVatTu.UseVisualStyleBackColor = true;
            btnThemVatTu.AutoSizeChanged += btnThemVatTu_Click;
            // 
            // pnlSoLuongTon
            // 
            pnlSoLuongTon.ColumnCount = 2;
            pnlSoLuongTon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlSoLuongTon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlSoLuongTon.Controls.Add(txtSoLuongTon, 1, 0);
            pnlSoLuongTon.Controls.Add(lblSoLuongTon, 0, 0);
            pnlSoLuongTon.Dock = DockStyle.Fill;
            pnlSoLuongTon.Location = new Point(3, 176);
            pnlSoLuongTon.Name = "pnlSoLuongTon";
            pnlSoLuongTon.RowCount = 1;
            pnlSoLuongTon.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSoLuongTon.Size = new Size(461, 39);
            pnlSoLuongTon.TabIndex = 4;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoLuongTon.Location = new Point(156, 6);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(302, 27);
            txtSoLuongTon.TabIndex = 10;
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.AutoSize = true;
            lblSoLuongTon.Dock = DockStyle.Fill;
            lblSoLuongTon.Location = new Point(3, 0);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(147, 39);
            lblSoLuongTon.TabIndex = 8;
            lblSoLuongTon.Text = "Số lượng tồn:";
            lblSoLuongTon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlDVT
            // 
            pnlDVT.ColumnCount = 2;
            pnlDVT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlDVT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlDVT.Controls.Add(txtDVT, 1, 0);
            pnlDVT.Controls.Add(lblDVT, 0, 0);
            pnlDVT.Dock = DockStyle.Fill;
            pnlDVT.Location = new Point(3, 131);
            pnlDVT.Name = "pnlDVT";
            pnlDVT.RowCount = 1;
            pnlDVT.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlDVT.Size = new Size(461, 39);
            pnlDVT.TabIndex = 3;
            // 
            // txtDVT
            // 
            txtDVT.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDVT.Location = new Point(156, 6);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(302, 27);
            txtDVT.TabIndex = 10;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Dock = DockStyle.Fill;
            lblDVT.Location = new Point(3, 0);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(147, 39);
            lblDVT.TabIndex = 8;
            lblDVT.Text = "ĐVT:";
            lblDVT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlTenVatTu
            // 
            pnlTenVatTu.ColumnCount = 2;
            pnlTenVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTenVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlTenVatTu.Controls.Add(txtTenVatTu, 1, 0);
            pnlTenVatTu.Controls.Add(lblTenVatTu, 0, 0);
            pnlTenVatTu.Dock = DockStyle.Fill;
            pnlTenVatTu.Location = new Point(3, 86);
            pnlTenVatTu.Name = "pnlTenVatTu";
            pnlTenVatTu.RowCount = 1;
            pnlTenVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTenVatTu.Size = new Size(461, 39);
            pnlTenVatTu.TabIndex = 2;
            // 
            // txtTenVatTu
            // 
            txtTenVatTu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenVatTu.Location = new Point(156, 6);
            txtTenVatTu.Name = "txtTenVatTu";
            txtTenVatTu.Size = new Size(302, 27);
            txtTenVatTu.TabIndex = 10;
            // 
            // lblTenVatTu
            // 
            lblTenVatTu.AutoSize = true;
            lblTenVatTu.Dock = DockStyle.Fill;
            lblTenVatTu.Location = new Point(3, 0);
            lblTenVatTu.Name = "lblTenVatTu";
            lblTenVatTu.Size = new Size(147, 39);
            lblTenVatTu.TabIndex = 8;
            lblTenVatTu.Text = "Tên VT:";
            lblTenVatTu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlMaVatTu
            // 
            pnlMaVatTu.ColumnCount = 2;
            pnlMaVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlMaVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlMaVatTu.Controls.Add(lblMaVatTu, 0, 0);
            pnlMaVatTu.Controls.Add(txtMaVatTu, 1, 0);
            pnlMaVatTu.Dock = DockStyle.Fill;
            pnlMaVatTu.Location = new Point(3, 41);
            pnlMaVatTu.Name = "pnlMaVatTu";
            pnlMaVatTu.RowCount = 1;
            pnlMaVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMaVatTu.Size = new Size(461, 39);
            pnlMaVatTu.TabIndex = 0;
            // 
            // lblMaVatTu
            // 
            lblMaVatTu.AutoSize = true;
            lblMaVatTu.Dock = DockStyle.Fill;
            lblMaVatTu.Location = new Point(3, 0);
            lblMaVatTu.Name = "lblMaVatTu";
            lblMaVatTu.Size = new Size(147, 39);
            lblMaVatTu.TabIndex = 8;
            lblMaVatTu.Text = "Mã VT:";
            lblMaVatTu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaVatTu
            // 
            txtMaVatTu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaVatTu.Location = new Point(156, 6);
            txtMaVatTu.Name = "txtMaVatTu";
            txtMaVatTu.Size = new Size(302, 27);
            txtMaVatTu.TabIndex = 9;
            // 
            // lblQuanLyVatTu
            // 
            lblQuanLyVatTu.AutoSize = true;
            lblQuanLyVatTu.Dock = DockStyle.Fill;
            lblQuanLyVatTu.Font = new Font("Segoe UI", 10F);
            lblQuanLyVatTu.Location = new Point(3, 0);
            lblQuanLyVatTu.Name = "lblQuanLyVatTu";
            lblQuanLyVatTu.Size = new Size(461, 38);
            lblQuanLyVatTu.TabIndex = 7;
            lblQuanLyVatTu.Text = "QUẢN LÝ VẬT TƯ";
            lblQuanLyVatTu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvVatTu
            // 
            dgvVatTu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVatTu.Dock = DockStyle.Fill;
            dgvVatTu.Location = new Point(3, 311);
            dgvVatTu.Name = "dgvVatTu";
            dgvVatTu.RowHeadersWidth = 51;
            dgvVatTu.Size = new Size(461, 333);
            dgvVatTu.TabIndex = 8;
            dgvVatTu.CellClick += dgvVatTu_CellClick;
            // 
            // pnlLapPhieuKho
            // 
            pnlLapPhieuKho.ColumnCount = 1;
            pnlLapPhieuKho.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLapPhieuKho.Controls.Add(btnLuuPhieu, 0, 9);
            pnlLapPhieuKho.Controls.Add(btnThemChiTiet, 0, 6);
            pnlLapPhieuKho.Controls.Add(lblTong, 0, 8);
            pnlLapPhieuKho.Controls.Add(lblLapPhieuKho, 0, 0);
            pnlLapPhieuKho.Controls.Add(pnlDonGia, 0, 5);
            pnlLapPhieuKho.Controls.Add(pnlSoLuong, 0, 4);
            pnlLapPhieuKho.Controls.Add(pnlVatTu, 0, 3);
            pnlLapPhieuKho.Controls.Add(pnlNCC, 0, 2);
            pnlLapPhieuKho.Controls.Add(pnlLoai, 0, 1);
            pnlLapPhieuKho.Controls.Add(dgvChiTiet, 0, 7);
            pnlLapPhieuKho.Dock = DockStyle.Fill;
            pnlLapPhieuKho.Location = new Point(476, 3);
            pnlLapPhieuKho.Name = "pnlLapPhieuKho";
            pnlLapPhieuKho.RowCount = 10;
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            pnlLapPhieuKho.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            pnlLapPhieuKho.Size = new Size(467, 647);
            pnlLapPhieuKho.TabIndex = 1;
            // 
            // btnLuuPhieu
            // 
            btnLuuPhieu.Dock = DockStyle.Fill;
            btnLuuPhieu.Location = new Point(120, 603);
            btnLuuPhieu.Margin = new Padding(120, 5, 120, 5);
            btnLuuPhieu.Name = "btnLuuPhieu";
            btnLuuPhieu.Size = new Size(227, 39);
            btnLuuPhieu.TabIndex = 16;
            btnLuuPhieu.Text = "Lưu phiếu kho";
            btnLuuPhieu.UseVisualStyleBackColor = true;
            btnLuuPhieu.Click += btnLuuPhieu_Click;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Dock = DockStyle.Fill;
            btnThemChiTiet.Location = new Point(111, 268);
            btnThemChiTiet.Margin = new Padding(111, 5, 111, 5);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(245, 35);
            btnThemChiTiet.TabIndex = 15;
            btnThemChiTiet.Text = "Thêm vào phiếu";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Dock = DockStyle.Fill;
            lblTong.Location = new Point(3, 566);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(461, 32);
            lblTong.TabIndex = 13;
            lblTong.Text = "Tổng: 0 VNĐ";
            lblTong.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLapPhieuKho
            // 
            lblLapPhieuKho.AutoSize = true;
            lblLapPhieuKho.Dock = DockStyle.Fill;
            lblLapPhieuKho.Font = new Font("Segoe UI", 10F);
            lblLapPhieuKho.Location = new Point(3, 0);
            lblLapPhieuKho.Name = "lblLapPhieuKho";
            lblLapPhieuKho.Size = new Size(461, 38);
            lblLapPhieuKho.TabIndex = 10;
            lblLapPhieuKho.Text = "LẬP PHIẾU KHO";
            lblLapPhieuKho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDonGia
            // 
            pnlDonGia.ColumnCount = 2;
            pnlDonGia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlDonGia.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlDonGia.Controls.Add(txtDonGia, 1, 0);
            pnlDonGia.Controls.Add(lblDonGia, 0, 0);
            pnlDonGia.Dock = DockStyle.Fill;
            pnlDonGia.Location = new Point(3, 221);
            pnlDonGia.Name = "pnlDonGia";
            pnlDonGia.RowCount = 1;
            pnlDonGia.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlDonGia.Size = new Size(461, 39);
            pnlDonGia.TabIndex = 9;
            // 
            // txtDonGia
            // 
            txtDonGia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDonGia.Location = new Point(156, 6);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(302, 27);
            txtDonGia.TabIndex = 10;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Dock = DockStyle.Fill;
            lblDonGia.Location = new Point(3, 0);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(147, 39);
            lblDonGia.TabIndex = 8;
            lblDonGia.Text = "Giá:";
            lblDonGia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlSoLuong
            // 
            pnlSoLuong.ColumnCount = 2;
            pnlSoLuong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlSoLuong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlSoLuong.Controls.Add(txtSoLuong, 1, 0);
            pnlSoLuong.Controls.Add(lblSoLuong, 0, 0);
            pnlSoLuong.Dock = DockStyle.Fill;
            pnlSoLuong.Location = new Point(3, 176);
            pnlSoLuong.Name = "pnlSoLuong";
            pnlSoLuong.RowCount = 1;
            pnlSoLuong.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSoLuong.Size = new Size(461, 39);
            pnlSoLuong.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoLuong.Location = new Point(156, 6);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(302, 27);
            txtSoLuong.TabIndex = 10;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Dock = DockStyle.Fill;
            lblSoLuong.Location = new Point(3, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(147, 39);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số lượng:";
            lblSoLuong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlVatTu
            // 
            pnlVatTu.ColumnCount = 2;
            pnlVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlVatTu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlVatTu.Controls.Add(cboVatTu, 1, 0);
            pnlVatTu.Controls.Add(lblVatTu, 0, 0);
            pnlVatTu.Dock = DockStyle.Fill;
            pnlVatTu.Location = new Point(3, 131);
            pnlVatTu.Name = "pnlVatTu";
            pnlVatTu.RowCount = 1;
            pnlVatTu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlVatTu.Size = new Size(461, 39);
            pnlVatTu.TabIndex = 6;
            // 
            // cboVatTu
            // 
            cboVatTu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboVatTu.FormattingEnabled = true;
            cboVatTu.Location = new Point(156, 5);
            cboVatTu.Name = "cboVatTu";
            cboVatTu.Size = new Size(302, 28);
            cboVatTu.TabIndex = 10;
            // 
            // lblVatTu
            // 
            lblVatTu.AutoSize = true;
            lblVatTu.Dock = DockStyle.Fill;
            lblVatTu.Location = new Point(3, 0);
            lblVatTu.Name = "lblVatTu";
            lblVatTu.Size = new Size(147, 39);
            lblVatTu.TabIndex = 8;
            lblVatTu.Text = "Vật tư:";
            lblVatTu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlNCC
            // 
            pnlNCC.ColumnCount = 2;
            pnlNCC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlNCC.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlNCC.Controls.Add(cboNCC, 1, 0);
            pnlNCC.Controls.Add(lblNCC, 0, 0);
            pnlNCC.Dock = DockStyle.Fill;
            pnlNCC.Location = new Point(3, 86);
            pnlNCC.Name = "pnlNCC";
            pnlNCC.RowCount = 1;
            pnlNCC.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNCC.Size = new Size(461, 39);
            pnlNCC.TabIndex = 5;
            // 
            // cboNCC
            // 
            cboNCC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboNCC.FormattingEnabled = true;
            cboNCC.Location = new Point(156, 5);
            cboNCC.Name = "cboNCC";
            cboNCC.Size = new Size(302, 28);
            cboNCC.TabIndex = 10;
            // 
            // lblNCC
            // 
            lblNCC.AutoSize = true;
            lblNCC.Dock = DockStyle.Fill;
            lblNCC.Location = new Point(3, 0);
            lblNCC.Name = "lblNCC";
            lblNCC.Size = new Size(147, 39);
            lblNCC.TabIndex = 8;
            lblNCC.Text = "Nhà cung cấp:";
            lblNCC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlLoai
            // 
            pnlLoai.ColumnCount = 2;
            pnlLoai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlLoai.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlLoai.Controls.Add(lblLoaiPhieu, 0, 0);
            pnlLoai.Controls.Add(cboLoaiPhieu, 1, 0);
            pnlLoai.Dock = DockStyle.Fill;
            pnlLoai.Location = new Point(3, 41);
            pnlLoai.Name = "pnlLoai";
            pnlLoai.RowCount = 1;
            pnlLoai.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLoai.Size = new Size(461, 39);
            pnlLoai.TabIndex = 4;
            // 
            // lblLoaiPhieu
            // 
            lblLoaiPhieu.AutoSize = true;
            lblLoaiPhieu.Dock = DockStyle.Fill;
            lblLoaiPhieu.Location = new Point(3, 0);
            lblLoaiPhieu.Name = "lblLoaiPhieu";
            lblLoaiPhieu.Size = new Size(147, 39);
            lblLoaiPhieu.TabIndex = 8;
            lblLoaiPhieu.Text = "Loại:";
            lblLoaiPhieu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboLoaiPhieu
            // 
            cboLoaiPhieu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboLoaiPhieu.FormattingEnabled = true;
            cboLoaiPhieu.Location = new Point(156, 5);
            cboLoaiPhieu.Name = "cboLoaiPhieu";
            cboLoaiPhieu.Size = new Size(302, 28);
            cboLoaiPhieu.TabIndex = 9;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(3, 311);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(461, 252);
            dgvChiTiet.TabIndex = 14;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 704);
            Controls.Add(pnlAll);
            Name = "FrmMain";
            Text = "Form1";
            pnlAll.ResumeLayout(false);
            pnlAll.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlQuanLyVatTu.ResumeLayout(false);
            pnlQuanLyVatTu.PerformLayout();
            pnlTimVatTu.ResumeLayout(false);
            pnlTimVatTu.PerformLayout();
            pnlButton.ResumeLayout(false);
            pnlSoLuongTon.ResumeLayout(false);
            pnlSoLuongTon.PerformLayout();
            pnlDVT.ResumeLayout(false);
            pnlDVT.PerformLayout();
            pnlTenVatTu.ResumeLayout(false);
            pnlTenVatTu.PerformLayout();
            pnlMaVatTu.ResumeLayout(false);
            pnlMaVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVatTu).EndInit();
            pnlLapPhieuKho.ResumeLayout(false);
            pnlLapPhieuKho.PerformLayout();
            pnlDonGia.ResumeLayout(false);
            pnlDonGia.PerformLayout();
            pnlSoLuong.ResumeLayout(false);
            pnlSoLuong.PerformLayout();
            pnlVatTu.ResumeLayout(false);
            pnlVatTu.PerformLayout();
            pnlNCC.ResumeLayout(false);
            pnlNCC.PerformLayout();
            pnlLoai.ResumeLayout(false);
            pnlLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlAll;
        private TableLayoutPanel pnlMain;
        private TableLayoutPanel pnlQuanLyVatTu;
        private TableLayoutPanel pnlLapPhieuKho;
        private TableLayoutPanel pnlMaVatTu;
        private TableLayoutPanel pnlTimVatTu;
        private TableLayoutPanel pnlButton;
        private TableLayoutPanel pnlSoLuongTon;
        private TableLayoutPanel pnlDVT;
        private TableLayoutPanel pnlTenVatTu;
        private TableLayoutPanel pnlSoLuong;
        private TableLayoutPanel pnlVatTu;
        private TableLayoutPanel pnlNCC;
        private TableLayoutPanel pnlLoai;
        private TableLayoutPanel pnlDonGia;
        private Label lblTimVatTu;
        private Label lblSoLuongTon;
        private Label lblDVT;
        private Label lblTenVatTu;
        private Label lblMaVatTu;
        private Label lblQuanLyVatTu;
        private Label lblTong;
        private Label lblLapPhieuKho;
        private Label lblDonGia;
        private Label lblSoLuong;
        private Label lblVatTu;
        private Label lblNCC;
        private Label lblLoaiPhieu;
        private Label lblTieuDe;
        private Button btnTimVatTu;
        private TextBox txtTimVatTu;
        private Button btnXoaVatTu;
        private Button btnSuaVatTu;
        private Button btnThemVatTu;
        private TextBox txtSoLuongTon;
        private TextBox txtDVT;
        private TextBox txtTenVatTu;
        private TextBox txtMaVatTu;
        private DataGridView dgvVatTu;
        private Button btnLuuPhieu;
        private Button btnThemChiTiet;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private ComboBox cboVatTu;
        private ComboBox cboNCC;
        private ComboBox cboLoaiPhieu;
        private DataGridView dgvChiTiet;
    }
}
