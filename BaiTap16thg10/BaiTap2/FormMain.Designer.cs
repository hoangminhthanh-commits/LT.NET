namespace BaiTap2
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
            statusStrip = new StatusStrip();
            lblTongPhieu = new ToolStripStatusLabel();
            lblQuaHan = new ToolStripStatusLabel();
            pnlInput = new TableLayoutPanel();
            lblTieuDe = new Label();
            pnlTren = new TableLayoutPanel();
            lblThongTin = new Label();
            pnlNut = new TableLayoutPanel();
            btnLamMoi = new Button();
            btnDaTra = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            pnlTinhTrang = new TableLayoutPanel();
            cboTinhTrang = new ComboBox();
            lblTinhTrang = new Label();
            pnlNapDuLieu = new TableLayoutPanel();
            dtpHanTra = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            lblMaPhieu = new Label();
            lblHanTra = new Label();
            lblNgayTra = new Label();
            lblNgayMuon = new Label();
            lblSoLuong = new Label();
            lblThietBi = new Label();
            lblHoTen = new Label();
            lblMaSV = new Label();
            txtMaPhieu = new TextBox();
            dtpNgayTra = new DateTimePicker();
            dtpNgayMuon = new DateTimePicker();
            cboThietBi = new ComboBox();
            numSoLuong = new NumericUpDown();
            pnlDuoi = new TableLayoutPanel();
            dgvPhieuMuon = new DataGridView();
            colMaPhieu = new DataGridViewTextBoxColumn();
            colMaSinhVien = new DataGridViewTextBoxColumn();
            colHoTenSinhVien = new DataGridViewTextBoxColumn();
            colThietBi = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colNgayMuon = new DataGridViewTextBoxColumn();
            colHanTra = new DataGridViewTextBoxColumn();
            colNgayTraThucTe = new DataGridViewTextBoxColumn();
            lblTimKiemVaLoc = new Label();
            pnlTimKiem = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnTimKiem = new Button();
            lblDanhSach = new Label();
            pnlLoc = new TableLayoutPanel();
            cboLoc = new ComboBox();
            lblLoc = new Label();
            btnXuatCSV = new Button();
            bindingSource = new BindingSource(components);
            errorProvider = new ErrorProvider(components);
            saveFileDialog = new SaveFileDialog();
            statusStrip.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlTren.SuspendLayout();
            pnlNut.SuspendLayout();
            pnlTinhTrang.SuspendLayout();
            pnlNapDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            pnlDuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).BeginInit();
            pnlTimKiem.SuspendLayout();
            pnlLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTongPhieu, lblQuaHan });
            statusStrip.Location = new Point(0, 651);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1028, 26);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // lblTongPhieu
            // 
            lblTongPhieu.Name = "lblTongPhieu";
            lblTongPhieu.Size = new Size(118, 20);
            lblTongPhieu.Text = "Tổng số phiếu: 0";
            // 
            // lblQuaHan
            // 
            lblQuaHan.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblQuaHan.Name = "lblQuaHan";
            lblQuaHan.Size = new Size(139, 20);
            lblQuaHan.Text = "Số phiếu quá hạn: 0";
            // 
            // pnlInput
            // 
            pnlInput.ColumnCount = 1;
            pnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlInput.Controls.Add(lblTieuDe, 0, 0);
            pnlInput.Controls.Add(pnlTren, 0, 1);
            pnlInput.Controls.Add(pnlDuoi, 0, 2);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(0, 0);
            pnlInput.Name = "pnlInput";
            pnlInput.RowCount = 3;
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Percent, 39.23664F));
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Percent, 55.87786F));
            pnlInput.Size = new Size(1028, 651);
            pnlInput.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Location = new Point(3, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1022, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ MƯỢN TRẢ THIẾT BỊ PHÒNG THỰC HÀNH";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTren
            // 
            pnlTren.ColumnCount = 1;
            pnlTren.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTren.Controls.Add(lblThongTin, 0, 0);
            pnlTren.Controls.Add(pnlNut, 0, 3);
            pnlTren.Controls.Add(pnlTinhTrang, 0, 2);
            pnlTren.Controls.Add(pnlNapDuLieu, 0, 1);
            pnlTren.Dock = DockStyle.Fill;
            pnlTren.Location = new Point(3, 35);
            pnlTren.Name = "pnlTren";
            pnlTren.RowCount = 4;
            pnlTren.RowStyles.Add(new RowStyle(SizeType.Percent, 8.812586F));
            pnlTren.RowStyles.Add(new RowStyle(SizeType.Percent, 59.6F));
            pnlTren.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            pnlTren.RowStyles.Add(new RowStyle(SizeType.Percent, 15.1380692F));
            pnlTren.Size = new Size(1022, 249);
            pnlTren.TabIndex = 1;
            // 
            // lblThongTin
            // 
            lblThongTin.AutoSize = true;
            lblThongTin.Location = new Point(3, 0);
            lblThongTin.Name = "lblThongTin";
            lblThongTin.Size = new Size(182, 20);
            lblThongTin.TabIndex = 1;
            lblThongTin.Text = "THÔNG TIN PHIẾU MƯỢN";
            lblThongTin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNut
            // 
            pnlNut.ColumnCount = 5;
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlNut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlNut.Controls.Add(btnLamMoi, 4, 0);
            pnlNut.Controls.Add(btnDaTra, 3, 0);
            pnlNut.Controls.Add(btnXoa, 2, 0);
            pnlNut.Controls.Add(btnCapNhat, 1, 0);
            pnlNut.Controls.Add(btnThem, 0, 0);
            pnlNut.Dock = DockStyle.Fill;
            pnlNut.Location = new Point(3, 214);
            pnlNut.Name = "pnlNut";
            pnlNut.RowCount = 1;
            pnlNut.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlNut.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlNut.Size = new Size(1016, 32);
            pnlNut.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(815, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 26);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnDaTra
            // 
            btnDaTra.Location = new Point(612, 3);
            btnDaTra.Name = "btnDaTra";
            btnDaTra.Size = new Size(137, 26);
            btnDaTra.TabIndex = 3;
            btnDaTra.Text = "Đánh dấu đã trả";
            btnDaTra.UseVisualStyleBackColor = true;
            btnDaTra.Click += btnDaTra_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(409, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 26);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(206, 3);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 26);
            btnCapNhat.TabIndex = 1;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 26);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // pnlTinhTrang
            // 
            pnlTinhTrang.ColumnCount = 2;
            pnlTinhTrang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlTinhTrang.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            pnlTinhTrang.Controls.Add(cboTinhTrang, 1, 0);
            pnlTinhTrang.Controls.Add(lblTinhTrang, 0, 0);
            pnlTinhTrang.Dock = DockStyle.Fill;
            pnlTinhTrang.Location = new Point(3, 174);
            pnlTinhTrang.Name = "pnlTinhTrang";
            pnlTinhTrang.RowCount = 1;
            pnlTinhTrang.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTinhTrang.Size = new Size(1016, 34);
            pnlTinhTrang.TabIndex = 3;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Location = new Point(257, 3);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(151, 28);
            cboTinhTrang.TabIndex = 17;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(3, 0);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(79, 20);
            lblTinhTrang.TabIndex = 8;
            lblTinhTrang.Text = "Tình trạng:";
            // 
            // pnlNapDuLieu
            // 
            pnlNapDuLieu.ColumnCount = 4;
            pnlNapDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.Controls.Add(dtpHanTra, 1, 3);
            pnlNapDuLieu.Controls.Add(txtHoTen, 1, 1);
            pnlNapDuLieu.Controls.Add(txtMaSV, 3, 0);
            pnlNapDuLieu.Controls.Add(lblMaPhieu, 0, 0);
            pnlNapDuLieu.Controls.Add(lblHanTra, 0, 3);
            pnlNapDuLieu.Controls.Add(lblNgayTra, 2, 3);
            pnlNapDuLieu.Controls.Add(lblNgayMuon, 2, 2);
            pnlNapDuLieu.Controls.Add(lblSoLuong, 0, 2);
            pnlNapDuLieu.Controls.Add(lblThietBi, 2, 1);
            pnlNapDuLieu.Controls.Add(lblHoTen, 0, 1);
            pnlNapDuLieu.Controls.Add(lblMaSV, 2, 0);
            pnlNapDuLieu.Controls.Add(txtMaPhieu, 1, 0);
            pnlNapDuLieu.Controls.Add(dtpNgayTra, 3, 3);
            pnlNapDuLieu.Controls.Add(dtpNgayMuon, 3, 2);
            pnlNapDuLieu.Controls.Add(cboThietBi, 3, 1);
            pnlNapDuLieu.Controls.Add(numSoLuong, 1, 2);
            pnlNapDuLieu.Dock = DockStyle.Fill;
            pnlNapDuLieu.Location = new Point(3, 25);
            pnlNapDuLieu.Name = "pnlNapDuLieu";
            pnlNapDuLieu.RowCount = 4;
            pnlNapDuLieu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlNapDuLieu.Size = new Size(1016, 143);
            pnlNapDuLieu.TabIndex = 4;
            // 
            // dtpHanTra
            // 
            dtpHanTra.Format = DateTimePickerFormat.Short;
            dtpHanTra.Location = new Point(257, 108);
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.Size = new Size(248, 27);
            dtpHanTra.TabIndex = 14;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(257, 38);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 10;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(765, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 9;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(3, 0);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(117, 20);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu mượn:";
            // 
            // lblHanTra
            // 
            lblHanTra.AutoSize = true;
            lblHanTra.Location = new Point(3, 105);
            lblHanTra.Name = "lblHanTra";
            lblHanTra.Size = new Size(61, 20);
            lblHanTra.TabIndex = 6;
            lblHanTra.Text = "Hạn trả:";
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(511, 105);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(69, 20);
            lblNgayTra.TabIndex = 7;
            lblNgayTra.Text = "Ngày trả:";
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.AutoSize = true;
            lblNgayMuon.Location = new Point(511, 70);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(90, 20);
            lblNgayMuon.TabIndex = 5;
            lblNgayMuon.Text = "Ngày mượn:";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(3, 70);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(72, 20);
            lblSoLuong.TabIndex = 4;
            lblSoLuong.Text = "Số lượng:";
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Location = new Point(511, 35);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(62, 20);
            lblThietBi.TabIndex = 3;
            lblThietBi.Text = "Thiết bị:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(3, 35);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(118, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên sinh viên:";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(511, 0);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(94, 20);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sinh viên:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(257, 3);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(125, 27);
            txtMaPhieu.TabIndex = 8;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(765, 108);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(248, 27);
            dtpNgayTra.TabIndex = 15;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(765, 73);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(248, 27);
            dtpNgayMuon.TabIndex = 13;
            // 
            // cboThietBi
            // 
            cboThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThietBi.FormattingEnabled = true;
            cboThietBi.Location = new Point(765, 38);
            cboThietBi.Name = "cboThietBi";
            cboThietBi.Size = new Size(151, 28);
            cboThietBi.TabIndex = 16;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(257, 73);
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 17;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pnlDuoi
            // 
            pnlDuoi.ColumnCount = 1;
            pnlDuoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlDuoi.Controls.Add(dgvPhieuMuon, 0, 4);
            pnlDuoi.Controls.Add(lblTimKiemVaLoc, 0, 0);
            pnlDuoi.Controls.Add(pnlTimKiem, 0, 1);
            pnlDuoi.Controls.Add(lblDanhSach, 0, 3);
            pnlDuoi.Controls.Add(pnlLoc, 0, 2);
            pnlDuoi.Controls.Add(btnXuatCSV, 0, 5);
            pnlDuoi.Dock = DockStyle.Fill;
            pnlDuoi.Location = new Point(3, 290);
            pnlDuoi.Name = "pnlDuoi";
            pnlDuoi.RowCount = 6;
            pnlDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            pnlDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            pnlDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            pnlDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            pnlDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5F));
            pnlDuoi.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlDuoi.Size = new Size(1022, 358);
            pnlDuoi.TabIndex = 2;
            // 
            // dgvPhieuMuon
            // 
            dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuMuon.Columns.AddRange(new DataGridViewColumn[] { colMaPhieu, colMaSinhVien, colHoTenSinhVien, colThietBi, colSoLuong, colNgayMuon, colHanTra, colNgayTraThucTe });
            dgvPhieuMuon.Dock = DockStyle.Fill;
            dgvPhieuMuon.Location = new Point(3, 155);
            dgvPhieuMuon.Name = "dgvPhieuMuon";
            dgvPhieuMuon.RowHeadersWidth = 51;
            dgvPhieuMuon.Size = new Size(1016, 160);
            dgvPhieuMuon.TabIndex = 18;
            // 
            // colMaPhieu
            // 
            colMaPhieu.DataPropertyName = "MaPhieu";
            colMaPhieu.HeaderText = "Mã phiếu mượn";
            colMaPhieu.MinimumWidth = 6;
            colMaPhieu.Name = "colMaPhieu";
            colMaPhieu.Width = 125;
            // 
            // colMaSinhVien
            // 
            colMaSinhVien.DataPropertyName = "MaSinhVien";
            colMaSinhVien.HeaderText = "Mã sinh viên";
            colMaSinhVien.MinimumWidth = 6;
            colMaSinhVien.Name = "colMaSinhVien";
            colMaSinhVien.Width = 125;
            // 
            // colHoTenSinhVien
            // 
            colHoTenSinhVien.DataPropertyName = "HoTenSinhVien";
            colHoTenSinhVien.HeaderText = "Họ tên sinh viên";
            colHoTenSinhVien.MinimumWidth = 6;
            colHoTenSinhVien.Name = "colHoTenSinhVien";
            colHoTenSinhVien.Width = 125;
            // 
            // colThietBi
            // 
            colThietBi.DataPropertyName = "ThietBi";
            colThietBi.HeaderText = "Thiết bị";
            colThietBi.MinimumWidth = 6;
            colThietBi.Name = "colThietBi";
            colThietBi.Width = 125;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 125;
            // 
            // colNgayMuon
            // 
            colNgayMuon.DataPropertyName = "NgayMuon";
            colNgayMuon.HeaderText = "Ngày mượn";
            colNgayMuon.MinimumWidth = 6;
            colNgayMuon.Name = "colNgayMuon";
            colNgayMuon.Width = 125;
            // 
            // colHanTra
            // 
            colHanTra.DataPropertyName = "HanTra";
            colHanTra.HeaderText = "Hạn trả";
            colHanTra.MinimumWidth = 6;
            colHanTra.Name = "colHanTra";
            colHanTra.Width = 125;
            // 
            // colNgayTraThucTe
            // 
            colNgayTraThucTe.DataPropertyName = "NgayTraThucTe";
            colNgayTraThucTe.HeaderText = "Ngày trả thực tế";
            colNgayTraThucTe.MinimumWidth = 6;
            colNgayTraThucTe.Name = "colNgayTraThucTe";
            colNgayTraThucTe.Width = 125;
            // 
            // lblTimKiemVaLoc
            // 
            lblTimKiemVaLoc.AutoSize = true;
            lblTimKiemVaLoc.Location = new Point(3, 0);
            lblTimKiemVaLoc.Name = "lblTimKiemVaLoc";
            lblTimKiemVaLoc.Size = new Size(125, 20);
            lblTimKiemVaLoc.TabIndex = 9;
            lblTimKiemVaLoc.Text = "TÌM KIẾM VÀ LỌC";
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.ColumnCount = 3;
            pnlTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTimKiem.Controls.Add(txtTimKiem, 1, 0);
            pnlTimKiem.Controls.Add(lblTimKiem, 0, 0);
            pnlTimKiem.Controls.Add(btnTimKiem, 2, 0);
            pnlTimKiem.Dock = DockStyle.Fill;
            pnlTimKiem.Location = new Point(3, 29);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.RowCount = 1;
            pnlTimKiem.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTimKiem.Size = new Size(1016, 36);
            pnlTimKiem.TabIndex = 15;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(341, 3);
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
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(679, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 27);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(3, 110);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(189, 20);
            lblDanhSach.TabIndex = 12;
            lblDanhSach.Text = "DANH SÁCH PHIẾU MƯỢN";
            // 
            // pnlLoc
            // 
            pnlLoc.ColumnCount = 2;
            pnlLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.30003F));
            pnlLoc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.69997F));
            pnlLoc.Controls.Add(cboLoc, 1, 0);
            pnlLoc.Controls.Add(lblLoc, 0, 0);
            pnlLoc.Dock = DockStyle.Fill;
            pnlLoc.Location = new Point(3, 71);
            pnlLoc.Name = "pnlLoc";
            pnlLoc.RowCount = 1;
            pnlLoc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLoc.Size = new Size(1016, 36);
            pnlLoc.TabIndex = 14;
            // 
            // cboLoc
            // 
            cboLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoc.FormattingEnabled = true;
            cboLoc.Location = new Point(341, 3);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(151, 28);
            cboLoc.TabIndex = 17;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Location = new Point(3, 0);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(35, 20);
            lblLoc.TabIndex = 11;
            lblLoc.Text = "Lọc:";
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.Dock = DockStyle.Right;
            btnXuatCSV.Location = new Point(925, 321);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(94, 34);
            btnXuatCSV.TabIndex = 16;
            btnXuatCSV.Text = "Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            btnXuatCSV.Click += btnXuatCSV_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 677);
            Controls.Add(pnlInput);
            Controls.Add(statusStrip);
            Name = "FormMain";
            Text = "FormMain";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlTren.ResumeLayout(false);
            pnlTren.PerformLayout();
            pnlNut.ResumeLayout(false);
            pnlTinhTrang.ResumeLayout(false);
            pnlTinhTrang.PerformLayout();
            pnlNapDuLieu.ResumeLayout(false);
            pnlNapDuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            pnlDuoi.ResumeLayout(false);
            pnlDuoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuMuon).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            pnlLoc.ResumeLayout(false);
            pnlLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private TableLayoutPanel pnlInput;
        private Label lblTieuDe;
        private TableLayoutPanel pnlTren;
        private Label lblThongTin;
        private TableLayoutPanel pnlNut;
        private TableLayoutPanel pnlTinhTrang;
        private TableLayoutPanel pnlNapDuLieu;
        private Label lblTinhTrang;
        private Label lblHanTra;
        private Label lblNgayMuon;
        private Label lblSoLuong;
        private Label lblThietBi;
        private Label lblHoTen;
        private Label lblMaSV;
        private Label lblMaPhieu;
        private Label lblTimKiemVaLoc;
        private TableLayoutPanel pnlDuoi;
        private TableLayoutPanel pnlTimKiem;
        private Label lblTimKiem;
        private Label lblDanhSach;
        private Label lblNgayTra;
        private TableLayoutPanel pnlLoc;
        private Label lblLoc;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private TextBox txtMaPhieu;
        private Button btnLamMoi;
        private Button btnDaTra;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private ComboBox cboTinhTrang;
        private DateTimePicker dtpHanTra;
        private DateTimePicker dtpNgayTra;
        private DateTimePicker dtpNgayMuon;
        private ComboBox cboThietBi;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private ComboBox cboLoc;
        private Button btnXuatCSV;
        private DataGridView dgvPhieuMuon;
        private BindingSource bindingSource;
        private ErrorProvider errorProvider;
        private SaveFileDialog saveFileDialog;
        private DataGridViewTextBoxColumn colMaPhieu;
        private DataGridViewTextBoxColumn colMaSinhVien;
        private DataGridViewTextBoxColumn colHoTenSinhVien;
        private DataGridViewTextBoxColumn colThietBi;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colHanTra;
        private DataGridViewTextBoxColumn colNgayTraThucTe;
        private ToolStripStatusLabel lblTongPhieu;
        private ToolStripStatusLabel lblQuaHan;
        private NumericUpDown numSoLuong;
    }
}
