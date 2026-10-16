namespace BaiTap3
{
    partial class FormMain
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
            menuMain = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuXuatCSV = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            stsTrangThai = new StatusStrip();
            lblSoDon = new ToolStripStatusLabel();
            lblTongChiPhi = new ToolStripStatusLabel();
            pnlTong = new TableLayoutPanel();
            pnlDanhSach = new TableLayoutPanel();
            dgvDonSuaChua = new DataGridView();
            colMaDon = new DataGridViewTextBoxColumn();
            colTenKhachHang = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colLoaiThietBi = new DataGridViewTextBoxColumn();
            colNgayTiepNhan = new DataGridViewTextBoxColumn();
            colChiPhi = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            lblDanhSach = new Label();
            pnlTimKiem = new TableLayoutPanel();
            cboLocTrangThai = new ComboBox();
            lblLoc = new Label();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            pnlThongTin = new TableLayoutPanel();
            pnlNut = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            lblThongTin = new Label();
            pnlNhapThongTin1 = new TableLayoutPanel();
            cboLoaiThietBi = new ComboBox();
            txtSoDienThoai = new TextBox();
            txtTenKhachHang = new TextBox();
            lblMaDon = new Label();
            lblTenKhachHang = new Label();
            lblSoDienThoai = new Label();
            lblLoaiThietBi = new Label();
            lblNgayTiepNhan = new Label();
            lblChiPhi = new Label();
            txtMaDon = new TextBox();
            txtChiPhi = new TextBox();
            dtpNgayTiepNhan = new DateTimePicker();
            pnlNhapThongTin2 = new TableLayoutPanel();
            txtMoTaLoi = new TextBox();
            lblTrangThai = new Label();
            lblMoTaLoi = new Label();
            cboTrangThai = new ComboBox();
            pnlAnh = new TableLayoutPanel();
            lblAnhThietBi = new Label();
            picThietBi = new PictureBox();
            btnChonAnh = new Button();
            errProvider = new ErrorProvider(components);
            sfdCSV = new SaveFileDialog();
            ofdAnh = new OpenFileDialog();
            menuMain.SuspendLayout();
            stsTrangThai.SuspendLayout();
            pnlTong.SuspendLayout();
            pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonSuaChua).BeginInit();
            pnlTimKiem.SuspendLayout();
            pnlThongTin.SuspendLayout();
            pnlNut.SuspendLayout();
            pnlNhapThongTin1.SuspendLayout();
            pnlNhapThongTin2.SuspendLayout();
            pnlAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picThietBi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { mnuHeThong });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(950, 28);
            menuMain.TabIndex = 0;
            menuMain.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.BackColor = SystemColors.ControlDark;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuXuatCSV, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuXuatCSV
            // 
            mnuXuatCSV.Name = "mnuXuatCSV";
            mnuXuatCSV.Size = new Size(222, 26);
            mnuXuatCSV.Text = "Xuất danh sách CSV";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(222, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // stsTrangThai
            // 
            stsTrangThai.ImageScalingSize = new Size(20, 20);
            stsTrangThai.Items.AddRange(new ToolStripItem[] { lblSoDon, lblTongChiPhi });
            stsTrangThai.Location = new Point(0, 778);
            stsTrangThai.Name = "stsTrangThai";
            stsTrangThai.Size = new Size(950, 26);
            stsTrangThai.TabIndex = 1;
            stsTrangThai.Text = "statusStrip1";
            // 
            // lblSoDon
            // 
            lblSoDon.Name = "lblSoDon";
            lblSoDon.Size = new Size(71, 20);
            lblSoDon.Text = "Số đơn: 0";
            // 
            // lblTongChiPhi
            // 
            lblTongChiPhi.Name = "lblTongChiPhi";
            lblTongChiPhi.Padding = new Padding(100, 0, 0, 0);
            lblTongChiPhi.Size = new Size(206, 20);
            lblTongChiPhi.Text = "Tổng chi phí: 0";
            // 
            // pnlTong
            // 
            pnlTong.ColumnCount = 1;
            pnlTong.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTong.Controls.Add(pnlDanhSach, 0, 1);
            pnlTong.Controls.Add(pnlThongTin, 0, 0);
            pnlTong.Dock = DockStyle.Fill;
            pnlTong.Location = new Point(0, 28);
            pnlTong.Name = "pnlTong";
            pnlTong.RowCount = 2;
            pnlTong.RowStyles.Add(new RowStyle(SizeType.Percent, 55.91572F));
            pnlTong.RowStyles.Add(new RowStyle(SizeType.Percent, 44.08428F));
            pnlTong.Size = new Size(950, 750);
            pnlTong.TabIndex = 2;
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.ColumnCount = 1;
            pnlDanhSach.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlDanhSach.Controls.Add(dgvDonSuaChua, 0, 2);
            pnlDanhSach.Controls.Add(lblDanhSach, 0, 0);
            pnlDanhSach.Controls.Add(pnlTimKiem, 0, 1);
            pnlDanhSach.Dock = DockStyle.Fill;
            pnlDanhSach.Location = new Point(3, 422);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.RowCount = 3;
            pnlDanhSach.RowStyles.Add(new RowStyle(SizeType.Percent, 7.894737F));
            pnlDanhSach.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0751877F));
            pnlDanhSach.RowStyles.Add(new RowStyle(SizeType.Percent, 62.0300751F));
            pnlDanhSach.Size = new Size(944, 325);
            pnlDanhSach.TabIndex = 4;
            // 
            // dgvDonSuaChua
            // 
            dgvDonSuaChua.AllowUserToAddRows = false;
            dgvDonSuaChua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonSuaChua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonSuaChua.Columns.AddRange(new DataGridViewColumn[] { colMaDon, colTenKhachHang, colSoDienThoai, colLoaiThietBi, colNgayTiepNhan, colChiPhi, colTrangThai });
            dgvDonSuaChua.Dock = DockStyle.Fill;
            dgvDonSuaChua.Location = new Point(3, 125);
            dgvDonSuaChua.MultiSelect = false;
            dgvDonSuaChua.Name = "dgvDonSuaChua";
            dgvDonSuaChua.ReadOnly = true;
            dgvDonSuaChua.RowHeadersWidth = 51;
            dgvDonSuaChua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonSuaChua.Size = new Size(938, 197);
            dgvDonSuaChua.TabIndex = 6;
            // 
            // colMaDon
            // 
            colMaDon.DataPropertyName = "MaDon";
            colMaDon.HeaderText = "Mã đơn";
            colMaDon.MinimumWidth = 6;
            colMaDon.Name = "colMaDon";
            colMaDon.ReadOnly = true;
            // 
            // colTenKhachHang
            // 
            colTenKhachHang.DataPropertyName = "TenKhachHang";
            colTenKhachHang.HeaderText = "Khách hàng";
            colTenKhachHang.MinimumWidth = 6;
            colTenKhachHang.Name = "colTenKhachHang";
            colTenKhachHang.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colSoDienThoai.HeaderText = "Số điện thoại";
            colSoDienThoai.MinimumWidth = 6;
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            // 
            // colLoaiThietBi
            // 
            colLoaiThietBi.DataPropertyName = "LoaiThietBi";
            colLoaiThietBi.HeaderText = "Loại thiết bị";
            colLoaiThietBi.MinimumWidth = 6;
            colLoaiThietBi.Name = "colLoaiThietBi";
            colLoaiThietBi.ReadOnly = true;
            // 
            // colNgayTiepNhan
            // 
            colNgayTiepNhan.DataPropertyName = "NgayTiepNhan";
            colNgayTiepNhan.HeaderText = "Ngày tiếp nhận";
            colNgayTiepNhan.MinimumWidth = 6;
            colNgayTiepNhan.Name = "colNgayTiepNhan";
            colNgayTiepNhan.ReadOnly = true;
            // 
            // colChiPhi
            // 
            colChiPhi.DataPropertyName = "ChiPhi";
            colChiPhi.HeaderText = "Chi phí dự kiến";
            colChiPhi.MinimumWidth = 6;
            colChiPhi.Name = "colChiPhi";
            colChiPhi.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(3, 0);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(170, 20);
            lblDanhSach.TabIndex = 2;
            lblDanhSach.Text = "Danh sách đơn sửa chữa";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.ColumnCount = 2;
            pnlTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTimKiem.Controls.Add(cboLocTrangThai, 1, 1);
            pnlTimKiem.Controls.Add(lblLoc, 0, 1);
            pnlTimKiem.Controls.Add(txtTimKiem, 1, 0);
            pnlTimKiem.Controls.Add(lblTimKiem, 0, 0);
            pnlTimKiem.Dock = DockStyle.Fill;
            pnlTimKiem.Location = new Point(3, 28);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.RowCount = 2;
            pnlTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTimKiem.Size = new Size(938, 91);
            pnlTimKiem.TabIndex = 3;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Location = new Point(472, 48);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(151, 28);
            cboLocTrangThai.TabIndex = 16;
            cboLocTrangThai.SelectedIndexChanged += cboLocTrangThai_SelectedIndexChanged;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Location = new Point(3, 45);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(103, 20);
            lblLoc.TabIndex = 14;
            lblLoc.Text = "Lọc trạng thái:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(472, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(125, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(3, 0);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(73, 20);
            lblTimKiem.TabIndex = 3;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // pnlThongTin
            // 
            pnlThongTin.ColumnCount = 1;
            pnlThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlThongTin.Controls.Add(pnlNut, 0, 4);
            pnlThongTin.Controls.Add(lblThongTin, 0, 0);
            pnlThongTin.Controls.Add(pnlNhapThongTin1, 0, 1);
            pnlThongTin.Controls.Add(pnlNhapThongTin2, 0, 2);
            pnlThongTin.Controls.Add(pnlAnh, 0, 3);
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(3, 3);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.RowCount = 5;
            pnlThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 6.47482F));
            pnlThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 26.6187057F));
            pnlThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 17.985611F));
            pnlThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 39.328537F));
            pnlThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 9.352518F));
            pnlThongTin.Size = new Size(944, 413);
            pnlThongTin.TabIndex = 3;
            // 
            // pnlNut
            // 
            pnlNut.ColumnCount = 4;
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNut.Controls.Add(btnLamMoi, 3, 0);
            pnlNut.Controls.Add(btnXoa, 2, 0);
            pnlNut.Controls.Add(btnCapNhat, 1, 0);
            pnlNut.Controls.Add(btnThem, 0, 0);
            pnlNut.Dock = DockStyle.Fill;
            pnlNut.Location = new Point(3, 375);
            pnlNut.Name = "pnlNut";
            pnlNut.RowCount = 1;
            pnlNut.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNut.Size = new Size(938, 35);
            pnlNut.TabIndex = 7;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(705, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(471, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(237, 3);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(3, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(165, 20);
            lblThongTin.TabIndex = 5;
            lblThongTin.Text = "Thông tin đơn sửa chữa";
            // 
            // pnlNhapThongTin1
            // 
            pnlNhapThongTin1.ColumnCount = 4;
            pnlNhapThongTin1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.4584217F));
            pnlNhapThongTin1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.3283577F));
            pnlNhapThongTin1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7633266F));
            pnlNhapThongTin1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3432827F));
            pnlNhapThongTin1.Controls.Add(cboLoaiThietBi, 3, 1);
            pnlNhapThongTin1.Controls.Add(txtSoDienThoai, 1, 1);
            pnlNhapThongTin1.Controls.Add(txtTenKhachHang, 3, 0);
            pnlNhapThongTin1.Controls.Add(lblMaDon, 0, 0);
            pnlNhapThongTin1.Controls.Add(lblTenKhachHang, 2, 0);
            pnlNhapThongTin1.Controls.Add(lblSoDienThoai, 0, 1);
            pnlNhapThongTin1.Controls.Add(lblLoaiThietBi, 2, 1);
            pnlNhapThongTin1.Controls.Add(lblNgayTiepNhan, 0, 2);
            pnlNhapThongTin1.Controls.Add(lblChiPhi, 2, 2);
            pnlNhapThongTin1.Controls.Add(txtMaDon, 1, 0);
            pnlNhapThongTin1.Controls.Add(txtChiPhi, 3, 2);
            pnlNhapThongTin1.Controls.Add(dtpNgayTiepNhan, 1, 2);
            pnlNhapThongTin1.Dock = DockStyle.Fill;
            pnlNhapThongTin1.Location = new Point(3, 29);
            pnlNhapThongTin1.Name = "pnlNhapThongTin1";
            pnlNhapThongTin1.RowCount = 3;
            pnlNhapThongTin1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            pnlNhapThongTin1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            pnlNhapThongTin1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            pnlNhapThongTin1.Size = new Size(938, 104);
            pnlNhapThongTin1.TabIndex = 1;
            // 
            // cboLoaiThietBi
            // 
            cboLoaiThietBi.FormattingEnabled = true;
            cboLoaiThietBi.Location = new Point(646, 37);
            cboLoaiThietBi.Name = "cboLoaiThietBi";
            cboLoaiThietBi.Size = new Size(151, 28);
            cboLoaiThietBi.TabIndex = 14;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(148, 37);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 12;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(646, 3);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(125, 27);
            txtTenKhachHang.TabIndex = 11;
            // 
            // lblMaDon
            // 
            lblMaDon.AutoSize = true;
            lblMaDon.Location = new Point(3, 0);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Size = new Size(63, 20);
            lblMaDon.TabIndex = 1;
            lblMaDon.Text = "Mã đơn:";
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(470, 0);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(114, 20);
            lblTenKhachHang.TabIndex = 2;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(3, 34);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 3;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblLoaiThietBi
            // 
            lblLoaiThietBi.AutoSize = true;
            lblLoaiThietBi.Location = new Point(470, 34);
            lblLoaiThietBi.Name = "lblLoaiThietBi";
            lblLoaiThietBi.Size = new Size(91, 20);
            lblLoaiThietBi.TabIndex = 4;
            lblLoaiThietBi.Text = "Loại thiết bị:";
            // 
            // lblNgayTiepNhan
            // 
            lblNgayTiepNhan.AutoSize = true;
            lblNgayTiepNhan.Location = new Point(3, 68);
            lblNgayTiepNhan.Name = "lblNgayTiepNhan";
            lblNgayTiepNhan.Size = new Size(113, 20);
            lblNgayTiepNhan.TabIndex = 5;
            lblNgayTiepNhan.Text = "Ngày tiếp nhận:";
            // 
            // lblChiPhi
            // 
            lblChiPhi.AutoSize = true;
            lblChiPhi.Location = new Point(470, 68);
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Size = new Size(111, 20);
            lblChiPhi.TabIndex = 6;
            lblChiPhi.Text = "Chi phí dự kiến:";
            // 
            // txtMaDon
            // 
            txtMaDon.Location = new Point(148, 3);
            txtMaDon.Name = "txtMaDon";
            txtMaDon.Size = new Size(125, 27);
            txtMaDon.TabIndex = 9;
            // 
            // txtChiPhi
            // 
            txtChiPhi.Location = new Point(646, 71);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.Size = new Size(125, 27);
            txtChiPhi.TabIndex = 13;
            // 
            // dtpNgayTiepNhan
            // 
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Short;
            dtpNgayTiepNhan.Location = new Point(148, 71);
            dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            dtpNgayTiepNhan.Size = new Size(250, 27);
            dtpNgayTiepNhan.TabIndex = 16;
            // 
            // pnlNhapThongTin2
            // 
            pnlNhapThongTin2.ColumnCount = 2;
            pnlNhapThongTin2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.245203F));
            pnlNhapThongTin2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.7548F));
            pnlNhapThongTin2.Controls.Add(txtMoTaLoi, 1, 1);
            pnlNhapThongTin2.Controls.Add(lblTrangThai, 0, 0);
            pnlNhapThongTin2.Controls.Add(lblMoTaLoi, 0, 1);
            pnlNhapThongTin2.Controls.Add(cboTrangThai, 1, 0);
            pnlNhapThongTin2.Dock = DockStyle.Fill;
            pnlNhapThongTin2.Location = new Point(3, 139);
            pnlNhapThongTin2.Name = "pnlNhapThongTin2";
            pnlNhapThongTin2.RowCount = 2;
            pnlNhapThongTin2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.666666F));
            pnlNhapThongTin2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1851845F));
            pnlNhapThongTin2.Size = new Size(938, 68);
            pnlNhapThongTin2.TabIndex = 4;
            // 
            // txtMoTaLoi
            // 
            txtMoTaLoi.Location = new Point(146, 37);
            txtMoTaLoi.Multiline = true;
            txtMoTaLoi.Name = "txtMoTaLoi";
            txtMoTaLoi.Size = new Size(660, 25);
            txtMoTaLoi.TabIndex = 16;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(3, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 7;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // lblMoTaLoi
            // 
            lblMoTaLoi.AutoSize = true;
            lblMoTaLoi.Location = new Point(3, 34);
            lblMoTaLoi.Name = "lblMoTaLoi";
            lblMoTaLoi.Size = new Size(72, 20);
            lblMoTaLoi.TabIndex = 8;
            lblMoTaLoi.Text = "Mô tả lỗi:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(146, 3);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 28);
            cboTrangThai.TabIndex = 15;
            // 
            // pnlAnh
            // 
            pnlAnh.ColumnCount = 2;
            pnlAnh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.49467F));
            pnlAnh.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.505331F));
            pnlAnh.Controls.Add(lblAnhThietBi, 0, 0);
            pnlAnh.Controls.Add(picThietBi, 0, 1);
            pnlAnh.Controls.Add(btnChonAnh, 1, 1);
            pnlAnh.Dock = DockStyle.Fill;
            pnlAnh.Location = new Point(3, 213);
            pnlAnh.Name = "pnlAnh";
            pnlAnh.RowCount = 2;
            pnlAnh.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlAnh.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            pnlAnh.Size = new Size(938, 156);
            pnlAnh.TabIndex = 6;
            // 
            // lblAnhThietBi
            // 
            lblAnhThietBi.AutoSize = true;
            lblAnhThietBi.Location = new Point(3, 0);
            lblAnhThietBi.Name = "lblAnhThietBi";
            lblAnhThietBi.Size = new Size(86, 20);
            lblAnhThietBi.TabIndex = 6;
            lblAnhThietBi.Text = "Ảnh thiết bị";
            // 
            // picThietBi
            // 
            picThietBi.Dock = DockStyle.Fill;
            picThietBi.Location = new Point(3, 24);
            picThietBi.Name = "picThietBi";
            picThietBi.Size = new Size(674, 129);
            picThietBi.TabIndex = 5;
            picThietBi.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnChonAnh.Location = new Point(683, 125);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 28);
            btnChonAnh.TabIndex = 3;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // ofdAnh
            // 
            ofdAnh.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 804);
            Controls.Add(pnlTong);
            Controls.Add(stsTrangThai);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "FormMain";
            Text = "Quản lý sửa chữa";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            stsTrangThai.ResumeLayout(false);
            stsTrangThai.PerformLayout();
            pnlTong.ResumeLayout(false);
            pnlDanhSach.ResumeLayout(false);
            pnlDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonSuaChua).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            pnlNut.ResumeLayout(false);
            pnlNhapThongTin1.ResumeLayout(false);
            pnlNhapThongTin1.PerformLayout();
            pnlNhapThongTin2.ResumeLayout(false);
            pnlNhapThongTin2.PerformLayout();
            pnlAnh.ResumeLayout(false);
            pnlAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picThietBi).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuMain;
        private StatusStrip stsTrangThai;
        private TableLayoutPanel pnlTong;
        private TableLayoutPanel pnlDanhSach;
        private TableLayoutPanel pnlThongTin;
        private TableLayoutPanel pnlNhapThongTin1;
        private Label lblMaDon;
        private Label lblTenKhachHang;
        private Label lblSoDienThoai;
        private Label lblLoaiThietBi;
        private Label lblNgayTiepNhan;
        private Label lblChiPhi;
        private Label lblDanhSach;
        private TableLayoutPanel pnlTimKiem;
        private Label lblThongTin;
        private ComboBox cboLoaiThietBi;
        private TextBox txtSoDienThoai;
        private TextBox txtTenKhachHang;
        private TextBox txtMaDon;
        private TextBox txtChiPhi;
        private DateTimePicker dtpNgayTiepNhan;
        private TableLayoutPanel pnlNhapThongTin2;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Label label12;
        private TextBox txtMoTaLoi;
        private ComboBox cboTrangThai;
        private Label lblTrangThai;
        private Label lblMoTaLoi;
        private ComboBox cboLocTrangThai;
        private Label lblLoc;
        private TableLayoutPanel pnlNut;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private TableLayoutPanel pnlAnh;
        private Button btnChonAnh;
        private Label lblAnhThietBi;
        private PictureBox picThietBi;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuXuatCSV;
        private ToolStripMenuItem mnuThoat;
        private ToolStripStatusLabel lblSoDon;
        private ToolStripStatusLabel lblTongChiPhi;
        private ErrorProvider errProvider;
        private DataGridView dgvDonSuaChua;
        private DataGridViewTextBoxColumn colMaDon;
        private DataGridViewTextBoxColumn colTenKhachHang;
        private DataGridViewTextBoxColumn colSoDienThoai;
        private DataGridViewTextBoxColumn colLoaiThietBi;
        private DataGridViewTextBoxColumn colNgayTiepNhan;
        private DataGridViewTextBoxColumn colChiPhi;
        private DataGridViewTextBoxColumn colTrangThai;
        private SaveFileDialog sfdCSV;
        private OpenFileDialog ofdAnh;
    }
}
