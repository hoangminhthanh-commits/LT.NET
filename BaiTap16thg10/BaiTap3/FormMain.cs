using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace BaiTap3
{
    public partial class FormMain : Form
    {
        private BindingList<RepairOrder> danhSachDon =
            new BindingList<RepairOrder>();

        private BindingList<RepairOrder> danhSachHienThi =
            new BindingList<RepairOrder>();

        private BindingSource bsDonSuaChua =
            new BindingSource();

        private string maDonDangChon = "";
        private string duongDanAnhDangChon = "";
        private bool dangNapDuLieu = false;
        public FormMain()
        {
            InitializeComponent();

            KhoiTaoComboBox();

            bsDonSuaChua.DataSource = danhSachHienThi;
            dgvDonSuaChua.DataSource = bsDonSuaChua;

            LamMoiForm();
            CapNhatDanhSach();
        }

        private void KhoiTaoComboBox()
        {
            cboLoaiThietBi.Items.Clear();
            cboLoaiThietBi.Items.AddRange(new object[]
            {
                "Laptop",
                "Máy tính để bàn",
                "Điện thoại",
                "Máy tính bảng",
                "Máy in",
                "Thiết bị khác"
            });

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[]
            {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });

            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("Tất cả");
            cboLocTrangThai.Items.AddRange(new object[]
            {
                "Mới tiếp nhận",
                "Đang sửa",
                "Chờ linh kiện",
                "Hoàn tất",
                "Đã hủy"
            });

            cboLoaiThietBi.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            cboLocTrangThai.SelectedIndex = 0;

            picThietBi.SizeMode = PictureBoxSizeMode.Zoom;

            ofdAnh.Filter =
                "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            sfdCSV.Filter = "CSV (*.csv)|*.csv";
            sfdCSV.DefaultExt = "csv";
            sfdCSV.AddExtension = true;
        }
        private void LamMoiForm()
        {
            dangNapDuLieu = true;

            txtMaDon.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtMoTaLoi.Clear();
            txtChiPhi.Clear();

            cboLoaiThietBi.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            dtpNgayTiepNhan.Value = DateTime.Today;

            maDonDangChon = "";
            duongDanAnhDangChon = "";

            HienThiAnh("");

            errProvider.Clear();

            txtMaDon.Enabled = true;

            dgvDonSuaChua.ClearSelection();

            dangNapDuLieu = false;
        }

        private void HienThiAnh(string duongDan)
        {
            Image anhCu = picThietBi.Image;
            picThietBi.Image = null;

            if (anhCu != null)
                anhCu.Dispose();

            if (string.IsNullOrWhiteSpace(duongDan)
                || !File.Exists(duongDan))
                return;

            using (Image anhGoc = Image.FromFile(duongDan))
            {
                picThietBi.Image = new Bitmap(anhGoc);
            }
        }

        private bool KiemTraDuLieu(out decimal chiPhi)
        {
            bool hopLe = true;
            chiPhi = 0;

            errProvider.Clear();

            string ma = txtMaDon.Text.Trim();

            if (ma == "")
            {
                errProvider.SetError(
                    txtMaDon, "Vui lòng nhập mã đơn.");
                hopLe = false;
            }
            else if (danhSachDon.Any(d =>
                d.MaDon.Equals(
                    ma, StringComparison.OrdinalIgnoreCase)
                &&
                !d.MaDon.Equals(
                    maDonDangChon,
                    StringComparison.OrdinalIgnoreCase)))
            {
                errProvider.SetError(
                    txtMaDon, "Mã đơn đã tồn tại.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                errProvider.SetError(
                    txtTenKhachHang,
                    "Vui lòng nhập tên khách hàng.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                errProvider.SetError(
                    txtSoDienThoai,
                    "Vui lòng nhập số điện thoại.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtMoTaLoi.Text))
            {
                errProvider.SetError(
                    txtMoTaLoi,
                    "Vui lòng nhập mô tả lỗi.");
                hopLe = false;
            }

            if (!decimal.TryParse(
                    txtChiPhi.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.CurrentCulture,
                    out chiPhi)
                || chiPhi < 0)
            {
                errProvider.SetError(
                    txtChiPhi,
                    "Chi phí phải là số không âm.");
                hopLe = false;
            }

            if (cboLoaiThietBi.SelectedIndex < 0)
            {
                errProvider.SetError(
                    cboLoaiThietBi,
                    "Vui lòng chọn loại thiết bị.");
                hopLe = false;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                errProvider.SetError(
                    cboTrangThai,
                    "Vui lòng chọn trạng thái.");
                hopLe = false;
            }

            return hopLe;
        }

        private RepairOrder TaoDon(decimal chiPhi)
        {
            return new RepairOrder
            {
                MaDon = txtMaDon.Text.Trim(),
                TenKhachHang = txtTenKhachHang.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                LoaiThietBi = cboLoaiThietBi.Text,
                MoTaLoi = txtMoTaLoi.Text.Trim(),
                NgayTiepNhan = dtpNgayTiepNhan.Value.Date,
                ChiPhi = chiPhi,
                TrangThai = cboTrangThai.Text,
                DuongDanAnh = duongDanAnhDangChon
            };
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (ofdAnh.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (Image anh = Image.FromFile(ofdAnh.FileName))
                {
                }

                duongDanAnhDangChon = ofdAnh.FileName;
                HienThiAnh(duongDanAnhDangChon);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể mở ảnh đã chọn.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out decimal chiPhi))
                return;

            danhSachDon.Add(TaoDon(chiPhi));

            CapNhatDanhSach();
            LamMoiForm();

            MessageBox.Show("Thêm đơn thành công!");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maDonDangChon))
            {
                MessageBox.Show("Vui lòng chọn đơn cần cập nhật.");
                return;
            }

            if (!KiemTraDuLieu(out decimal chiPhi))
                return;

            RepairOrder don = danhSachDon.FirstOrDefault(
                d => d.MaDon == maDonDangChon);

            if (don == null)
            {
                MessageBox.Show("Không tìm thấy đơn.");
                return;
            }

            RepairOrder moi = TaoDon(chiPhi);

            don.MaDon = moi.MaDon;
            don.TenKhachHang = moi.TenKhachHang;
            don.SoDienThoai = moi.SoDienThoai;
            don.LoaiThietBi = moi.LoaiThietBi;
            don.MoTaLoi = moi.MoTaLoi;
            don.NgayTiepNhan = moi.NgayTiepNhan;
            don.ChiPhi = moi.ChiPhi;
            don.TrangThai = moi.TrangThai;
            don.DuongDanAnh = moi.DuongDanAnh;

            CapNhatDanhSach();
            LamMoiForm();

            MessageBox.Show("Cập nhật đơn thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maDonDangChon))
            {
                MessageBox.Show("Vui lòng chọn đơn cần xóa.");
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đơn "
                + maDonDangChon + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (xacNhan != DialogResult.Yes)
                return;

            RepairOrder don = danhSachDon.FirstOrDefault(
                d => d.MaDon == maDonDangChon);

            if (don != null)
                danhSachDon.Remove(don);

            CapNhatDanhSach();
            LamMoiForm();

            MessageBox.Show("Xóa đơn thành công!");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }
        private void cboLocTrangThai_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatDanhSach();
        }

        private void CapNhatDanhSach()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string trangThai = cboLocTrangThai.Text;

            var ketQua = danhSachDon.Where(d =>
                (
                    d.MaDon.IndexOf(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    d.TenKhachHang.IndexOf(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    d.SoDienThoai.IndexOf(tuKhoa) >= 0
                )
                &&
                (
                    trangThai == "Tất cả"
                    || d.TrangThai == trangThai
                )
            ).ToList();

            dangNapDuLieu = true;

            danhSachHienThi =
                new BindingList<RepairOrder>(ketQua);

            bsDonSuaChua.DataSource = danhSachHienThi;
            dgvDonSuaChua.DataSource = bsDonSuaChua;

            dgvDonSuaChua.ClearSelection();

            dangNapDuLieu = false;

            CapNhatTrangThai();
        }

        private void dgvDonSuaChua_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dangNapDuLieu
                || dgvDonSuaChua.CurrentRow == null
                || dgvDonSuaChua.SelectedRows.Count == 0)
                return;

            RepairOrder don =
                dgvDonSuaChua.CurrentRow.DataBoundItem
                as RepairOrder;

            if (don == null)
                return;

            dangNapDuLieu = true;

            maDonDangChon = don.MaDon;

            txtMaDon.Text = don.MaDon;
            txtTenKhachHang.Text = don.TenKhachHang;
            txtSoDienThoai.Text = don.SoDienThoai;
            txtMoTaLoi.Text = don.MoTaLoi;

            txtChiPhi.Text = don.ChiPhi.ToString(
                "0.##", CultureInfo.CurrentCulture);

            cboLoaiThietBi.SelectedItem = don.LoaiThietBi;
            cboTrangThai.SelectedItem = don.TrangThai;
            dtpNgayTiepNhan.Value = don.NgayTiepNhan;

            duongDanAnhDangChon = don.DuongDanAnh;
            HienThiAnh(duongDanAnhDangChon);

            txtMaDon.Enabled = false;

            dangNapDuLieu = false;
        }

        private void CapNhatTrangThai()
        {
            int soDon = danhSachHienThi.Count;

            decimal tongChiPhi = danhSachHienThi
                .Where(d =>
                    d.TrangThai != "Hoàn tất"
                    && d.TrangThai != "Đã hủy")
                .Sum(d => d.ChiPhi);

            lblSoDon.Text =
                "Số đơn đang hiển thị: " + soDon;

            lblTongChiPhi.Text =
                "Tổng chi phí chưa hoàn tất: "
                + tongChiPhi.ToString(
                    "N0", CultureInfo.CurrentCulture);
        }

        private string ChuyenSangCSV(string giaTri)
        {
            return "\"" + (giaTri ?? "").Replace("\"", "\"\"")
                + "\"";
        }

        private void mnuXuatCSV_Click(object sender, EventArgs e)
        {
            sfdCSV.FileName = "DanhSachDonSuaChua.csv";

            if (sfdCSV.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (StreamWriter writer = new StreamWriter(
                    sfdCSV.FileName,
                    false,
                    new UTF8Encoding(true)))
                {
                    writer.WriteLine(
                        "MaDon,TenKhachHang,SoDienThoai,"
                        + "LoaiThietBi,MoTaLoi,NgayTiepNhan,"
                        + "ChiPhi,TrangThai");

                    foreach (RepairOrder don in danhSachHienThi)
                    {
                        string[] cot =
                        {
                            don.MaDon,
                            don.TenKhachHang,
                            don.SoDienThoai,
                            don.LoaiThietBi,
                            don.MoTaLoi,
                            don.NgayTiepNhan.ToString("dd/MM/yyyy"),
                            don.ChiPhi.ToString(
                                "0.##",
                                CultureInfo.InvariantCulture),
                            don.TrangThai
                        };

                        writer.WriteLine(
                            string.Join(",", cot.Select(ChuyenSangCSV)));
                    }
                }

                MessageBox.Show("Xuất CSV thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất CSV: " + ex.Message);
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (picThietBi.Image != null)
            {
                Image anhCu = picThietBi.Image;
                picThietBi.Image = null;
                anhCu.Dispose();
            }

            base.OnFormClosed(e);
        }
    }
}
