using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BaiTap2
{
    public partial class FormMain : Form
    {
        private BindingList<PhieuMuon> danhSachPhieu = new();
        private PhieuMuon? phieuDangChon;
        public FormMain()
        {
            InitializeComponent();

            cboThietBi.Items.Clear();
            cboThietBi.Items.AddRange(new string[]
            {
                "Máy tính",
                "Máy chiếu",
                "Bàn phím",
                "Chuột",
                "Màn hình",
                "Loa"
            });
            cboTinhTrang.Items.Clear();
            cboTinhTrang.Items.AddRange(new string[]
            {
                "Tốt",
                "Hư hỏng",
                "Mất"
            });
            cboLoc.Items.Clear();
            cboLoc.Items.AddRange(new string[]
            {
                "Tất cả",
                "Đang mượn",
                "Đã trả",
                "Quá hạn"
            });
            cboThietBi.SelectedIndex = -1;
            cboTinhTrang.SelectedIndex = -1;
            cboLoc.SelectedIndex = 0;

            bindingSource.DataSource = danhSachPhieu;
            dgvPhieuMuon.DataSource = bindingSource;
            
            dtpNgayTra.ShowCheckBox = true;
            dtpNgayTra.Checked = false;

            txtTimKiem.TextChanged += (s, e) => LocDanhSach();
            cboLoc.SelectedIndexChanged += (s, e) => LocDanhSach();
            dgvPhieuMuon.SelectionChanged += dgvPhieuMuon_SelectionChanged;

            CapNhatThongKe();
        }
        private bool KiemTraDuLieu()
        {
            errorProvider.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                errorProvider.SetError(txtMaPhieu, "Nhập mã phiếu.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider.SetError(txtMaSV, "Nhập mã sinh viên.");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider.SetError(txtHoTen, "Nhập họ tên sinh viên.");
                hopLe = false;
            }

            if (cboThietBi.SelectedIndex < 0)
            {
                errorProvider.SetError(cboThietBi, "Chọn thiết bị.");
                hopLe = false;
            }

            if (numSoLuong.Value <= 0)
            {
                errorProvider.SetError(numSoLuong, "Số lượng phải lớn hơn 0.");
                hopLe = false;
            }

            if (dtpHanTra.Value.Date < dtpNgayMuon.Value.Date)
            {
                errorProvider.SetError(
                    dtpHanTra, "Hạn trả không được trước ngày mượn.");
                hopLe = false;
            }

            if (dtpNgayTra.Checked &&
                dtpNgayTra.Value.Date < dtpNgayMuon.Value.Date)
            {
                errorProvider.SetError(
                    dtpNgayTra, "Ngày trả không được trước ngày mượn.");
                hopLe = false;
            }

            return hopLe;
        }

        private bool MaPhieuBiTrung(string ma)
        {
            return danhSachPhieu.Any(p =>
                p.MaPhieu.Equals(ma.Trim(),
                    StringComparison.OrdinalIgnoreCase) &&
                !ReferenceEquals(p, phieuDangChon));
        }

        private PhieuMuon LayPhieuTuForm()
        {
            return new PhieuMuon
            {
                MaPhieu = txtMaPhieu.Text.Trim(),
                MaSinhVien = txtMaSV.Text.Trim(),
                HoTenSinhVien = txtHoTen.Text.Trim(),
                ThietBi = cboThietBi.Text,
                SoLuong = (int)numSoLuong.Value,
                NgayMuon = dtpNgayMuon.Value.Date,
                HanTra = dtpHanTra.Value.Date,
                NgayTraThucTe = dtpNgayTra.Checked
                    ? dtpNgayTra.Value.Date
                    : null
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            phieuDangChon = null;

            if (!KiemTraDuLieu())
                return;

            if (MaPhieuBiTrung(txtMaPhieu.Text))
            {
                errorProvider.SetError(txtMaPhieu, "Mã phiếu đã tồn tại.");
                return;
            }

            danhSachPhieu.Add(LayPhieuTuForm());
            LocDanhSach();
            CapNhatThongKe();
            LamMoiForm();

            MessageBox.Show("Thêm phiếu thành công.");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (phieuDangChon == null)
            {
                MessageBox.Show("Hãy chọn phiếu cần cập nhật.");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            if (MaPhieuBiTrung(txtMaPhieu.Text))
            {
                errorProvider.SetError(txtMaPhieu, "Mã phiếu đã tồn tại.");
                return;
            }

            var p = phieuDangChon;
            p.MaPhieu = txtMaPhieu.Text.Trim();
            p.MaSinhVien = txtMaSV.Text.Trim();
            p.HoTenSinhVien = txtHoTen.Text.Trim();
            p.ThietBi = cboThietBi.Text;
            p.SoLuong = (int)numSoLuong.Value;
            p.NgayMuon = dtpNgayMuon.Value.Date;
            p.HanTra = dtpHanTra.Value.Date;
            p.NgayTraThucTe = dtpNgayTra.Checked
                ? dtpNgayTra.Value.Date
                : null;

            LocDanhSach();
            CapNhatThongKe();
            LamMoiForm();

            MessageBox.Show("Cập nhật thành công.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (phieuDangChon == null)
            {
                MessageBox.Show("Hãy chọn phiếu cần xóa.");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc muốn xóa phiếu " + phieuDangChon.MaPhieu + "?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            danhSachPhieu.Remove(phieuDangChon);
            phieuDangChon = null;

            LocDanhSach();
            CapNhatThongKe();
            LamMoiForm();
        }

        private void btnDaTra_Click(object sender, EventArgs e)
        {
            if (phieuDangChon == null)
            {
                MessageBox.Show("Hãy chọn phiếu cần đánh dấu đã trả.");
                return;
            }

            if (phieuDangChon.NgayTraThucTe.HasValue)
            {
                MessageBox.Show("Phiếu này đã được trả.");
                return;
            }

            if (DateTime.Today < phieuDangChon.NgayMuon.Date)
            {
                MessageBox.Show("Ngày trả không được trước ngày mượn.");
                return;
            }

            phieuDangChon.NgayTraThucTe = DateTime.Today;
            LocDanhSach();
            CapNhatThongKe();
            LamMoiForm();

            MessageBox.Show("Đã cập nhật ngày trả và tình trạng.");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                dgvPhieuMuon.DataSource = null;
                dgvPhieuMuon.DataSource = danhSachPhieu;
                return;
            }

            var ketQua = danhSachPhieu
                .Where(p =>
                    p.MaSinhVien.IndexOf(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    p.ThietBi.IndexOf(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                    ||
                    p.HoTenSinhVien.IndexOf(
                        tuKhoa,
                        StringComparison.OrdinalIgnoreCase) >= 0
                )
                .ToList();

            dgvPhieuMuon.DataSource = null;
            dgvPhieuMuon.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show(
                    "Không tìm thấy phiếu phù hợp.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = "DanhSachPhieuMuon.csv",
                DefaultExt = "csv",
                AddExtension = true
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            string tuKhoa = txtTimKiem.Text.Trim();
            string tinhTrang = cboLoc.SelectedItem?.ToString() ?? "Tất cả";

            var ketQua = danhSachPhieu.Where(p =>
                (p.MaSinhVien.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                 p.ThietBi.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase)) &&
                (tinhTrang == "Tất cả" || p.TinhTrang == tinhTrang)
            ).ToList();

            try
            {
                using var writer = new StreamWriter(
                    dialog.FileName, false, new UTF8Encoding(true));

                writer.WriteLine(
                    "MaPhieu,MaSinhVien,HoTenSinhVien,ThietBi," +
                    "SoLuong,NgayMuon,HanTra,NgayTraThucTe,TinhTrang");

                foreach (var p in ketQua)
                {
                    string[] fields =
                    {
                    p.MaPhieu, p.MaSinhVien, p.HoTenSinhVien,
                    p.ThietBi, p.SoLuong.ToString(),
                    p.NgayMuon.ToString("dd/MM/yyyy"),
                    p.HanTra.ToString("dd/MM/yyyy"),
                    p.NgayTraThucTe?.ToString("dd/MM/yyyy") ?? "",
                    p.TinhTrang
                };

                    writer.WriteLine(string.Join(",", fields.Select(Csv)));
                }

                MessageBox.Show("Xuất CSV thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất CSV: " + ex.Message);
            }
        }

        private string Csv(string value)
        {
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        private void dgvPhieuMuon_SelectionChanged(
        object? sender, EventArgs e)
        {
            if (dgvPhieuMuon.CurrentRow?.DataBoundItem is not PhieuMuon p)
                return;

            phieuDangChon = p;

            txtMaPhieu.Text = p.MaPhieu;
            txtMaSV.Text = p.MaSinhVien;
            txtHoTen.Text = p.HoTenSinhVien;

            if (!cboThietBi.Items.Contains(p.ThietBi))
                cboThietBi.Items.Add(p.ThietBi);

            cboThietBi.SelectedItem = p.ThietBi;
            numSoLuong.Value = Math.Max(
                numSoLuong.Minimum,
                Math.Min(numSoLuong.Maximum, p.SoLuong));

            dtpNgayMuon.Value = p.NgayMuon;
            dtpHanTra.Value = p.HanTra;

            if (p.NgayTraThucTe.HasValue)
            {
                dtpNgayTra.Value = p.NgayTraThucTe.Value;
                dtpNgayTra.Checked = true;
            }
            else
            {
                dtpNgayTra.Value = DateTime.Today;
                dtpNgayTra.Checked = false;
            }
        }

        private void LocDanhSach()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string tinhTrang = cboLoc.SelectedItem?.ToString() ?? "Tất cả";

            var ketQua = danhSachPhieu.Where(p =>
                (p.MaSinhVien.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase) ||
                 p.ThietBi.Contains(
                     tuKhoa, StringComparison.OrdinalIgnoreCase)) &&
                (tinhTrang == "Tất cả" || p.TinhTrang == tinhTrang)
            ).ToList();

            dgvPhieuMuon.DataSource = null;
            bindingSource.DataSource = new BindingList<PhieuMuon>(ketQua);
            dgvPhieuMuon.DataSource = bindingSource;

            CapNhatThongKe();
        }

        private void CapNhatThongKe()
        {
            lblTongPhieu.Text = "Tổng số phiếu: " + danhSachPhieu.Count;
            lblQuaHan.Text = "Số phiếu quá hạn: " +
                danhSachPhieu.Count(p => p.TinhTrang == "Quá hạn");
        }

        private void LamMoiForm()
        {
            phieuDangChon = null;
            errorProvider.Clear();

            dgvPhieuMuon.CurrentCell = null;
            dgvPhieuMuon.ClearSelection();

            txtMaPhieu.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();

            cboThietBi.SelectedIndex = -1;
            cboTinhTrang.SelectedIndex = -1;
            numSoLuong.Value = 1;

            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today.AddDays(7);
            dtpNgayTra.Value = DateTime.Today;
            dtpNgayTra.Checked = false;
        }

    }
}