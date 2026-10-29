using Bai5._5.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bai5._5
{
    public partial class FrmMain : Form
    {
        private VatTuBUS vatTuBUS = new VatTuBUS();
        private PhieuKhoBUS phieuKhoBUS = new PhieuKhoBUS();
        private NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private DataTable dtChiTiet;

        public FrmMain()
        {
            InitializeComponent();

            LoadVatTu();
            LoadLoaiPhieu();
            LoadNhaCungCap();
            LoadComboVatTu();

            TaoBangChiTiet();
        }

        // =========================
        // LOAD VẬT TƯ
        // =========================

        private void LoadVatTu()
        {
            dgvVatTu.DataSource = vatTuBUS.GetAll();

            if (dgvVatTu.Columns.Count > 0)
            {
                dgvVatTu.Columns["MaVatTu"].HeaderText = "Mã VT";
                dgvVatTu.Columns["TenVatTu"].HeaderText = "Tên vật tư";
                dgvVatTu.Columns["DVT"].HeaderText = "ĐVT";
                dgvVatTu.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            }

            dgvVatTu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =========================
        // LOAD LOẠI PHIẾU
        // =========================

        private void LoadLoaiPhieu()
        {
            cboLoaiPhieu.Items.Clear();

            cboLoaiPhieu.Items.Add("NHAP");
            cboLoaiPhieu.Items.Add("XUAT");

            cboLoaiPhieu.SelectedIndex = 0;
        }

        private void LoadNhaCungCap()
        {
            DataTable dt = nccBUS.GetAll();

            cboNCC.DataSource = dt;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }

        // =========================
        // CLICK DÒNG VẬT TƯ
        // =========================

        private void dgvVatTu_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvVatTu.Rows[e.RowIndex];

            txtMaVatTu.Text =
                row.Cells["MaVatTu"].Value?.ToString();

            txtTenVatTu.Text =
                row.Cells["TenVatTu"].Value?.ToString();

            txtDVT.Text =
                row.Cells["DVT"].Value?.ToString();

            txtSoLuongTon.Text =
                row.Cells["SoLuongTon"].Value?.ToString();
        }

        // =========================
        // THÊM VẬT TƯ
        // =========================

        private void btnThemVatTu_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (txtMaVatTu.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập mã vật tư!");
                    return;
                }

                if (txtTenVatTu.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập tên vật tư!");
                    return;
                }

                decimal soLuong;

                if (!decimal.TryParse(
                    txtSoLuongTon.Text,
                    out soLuong))
                {
                    MessageBox.Show(
                        "Số lượng tồn không hợp lệ!");
                    return;
                }

                if (soLuong < 0)
                {
                    MessageBox.Show(
                        "Số lượng tồn không được âm!");
                    return;
                }

                vatTuBUS.Them(
                    txtMaVatTu.Text.Trim(),
                    txtTenVatTu.Text.Trim(),
                    txtDVT.Text.Trim(),
                    soLuong);

                MessageBox.Show("Thêm vật tư thành công!");

                LoadVatTu();
                XoaTrangVatTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm vật tư:\n" + ex.Message);
            }
        }

        // =========================
        // SỬA VẬT TƯ
        // =========================

        private void btnSuaVatTu_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (txtMaVatTu.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Hãy chọn vật tư cần sửa!");
                    return;
                }

                decimal soLuong;

                if (!decimal.TryParse(
                    txtSoLuongTon.Text,
                    out soLuong))
                {
                    MessageBox.Show(
                        "Số lượng tồn không hợp lệ!");
                    return;
                }

                if (soLuong < 0)
                {
                    MessageBox.Show(
                        "Số lượng tồn không được âm!");
                    return;
                }

                vatTuBUS.Sua(
                    txtMaVatTu.Text.Trim(),
                    txtTenVatTu.Text.Trim(),
                    txtDVT.Text.Trim(),
                    soLuong);

                MessageBox.Show("Sửa thành công!");

                LoadVatTu();
                XoaTrangVatTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi sửa vật tư:\n" + ex.Message);
            }
        }

        // =========================
        // XÓA VẬT TƯ
        // =========================

        private void btnXoaVatTu_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (txtMaVatTu.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Hãy chọn vật tư cần xóa!");
                    return;
                }

                DialogResult result =
                    MessageBox.Show(
                        "Bạn có chắc muốn xóa vật tư này?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                vatTuBUS.Xoa(
                    txtMaVatTu.Text.Trim());

                MessageBox.Show("Xóa thành công!");

                LoadVatTu();
                XoaTrangVatTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không thể xóa vật tư.\n" +
                    ex.Message);
            }
        }

        // =========================
        // TÌM KIẾM
        // =========================

        private void btnTimVatTu_Click(
            object sender,
            EventArgs e)
        {
            dgvVatTu.DataSource =
                vatTuBUS.TimKiem(
                    txtTimVatTu.Text.Trim());
        }

        // =========================
        // XÓA TRẮNG
        // =========================

        private void XoaTrangVatTu()
        {
            txtMaVatTu.Clear();
            txtTenVatTu.Clear();
            txtDVT.Clear();
            txtSoLuongTon.Clear();
        }

        private void btnLuuPhieu_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                // =========================
                // KIỂM TRA LOẠI PHIẾU
                // =========================

                if (cboLoaiPhieu.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Hãy chọn loại phiếu!");

                    return;
                }

                string loaiPhieu =
                    cboLoaiPhieu.SelectedItem.ToString();

                // =========================
                // KIỂM TRA CHI TIẾT
                // =========================

                if (dtChiTiet == null ||
                    dtChiTiet.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Chưa có vật tư trong phiếu!");

                    return;
                }

                // =========================
                // NHÀ CUNG CẤP
                // =========================

                int? maNCC = null;

                if (loaiPhieu == "NHAP")
                {
                    if (cboNCC.SelectedValue == null)
                    {
                        MessageBox.Show(
                            "Phiếu nhập phải chọn nhà cung cấp!");

                        return;
                    }

                    maNCC =
                        Convert.ToInt32(
                            cboNCC.SelectedValue);
                }

                // =========================
                // TÍNH TỔNG TIỀN
                // =========================

                decimal tongTien = 0;

                foreach (DataRow row in dtChiTiet.Rows)
                {
                    decimal thanhTien =
                        Convert.ToDecimal(
                            row["ThanhTien"]);

                    tongTien += thanhTien;
                }

                // =========================
                // LƯU PHIẾU
                // =========================

                int maPhieu =
                    phieuKhoBUS.LuuPhieu(
                        loaiPhieu,
                        maNCC,
                        tongTien,
                        dtChiTiet);

                MessageBox.Show(
                    "Lưu phiếu kho thành công!\n" +
                    "Mã phiếu: " + maPhieu +
                    "\nTổng tiền: " +
                    tongTien.ToString("N0") +
                    " VNĐ",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // =========================
                // RESET
                // =========================

                dtChiTiet.Clear();

                lblTong.Text = "Tổng: 0 VNĐ";

                LoadVatTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lưu phiếu kho:\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn vật tư chưa
                if (cboVatTu.SelectedValue == null)
                {
                    MessageBox.Show("Hãy chọn vật tư!");
                    return;
                }

                // Kiểm tra số lượng
                decimal soLuong;

                if (!decimal.TryParse(
                    txtSoLuong.Text.Trim(),
                    out soLuong))
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    return;
                }

                if (soLuong <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0!");
                    return;
                }

                // Kiểm tra đơn giá
                decimal donGia;

                if (!decimal.TryParse(
                    txtDonGia.Text.Trim(),
                    out donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!");
                    return;
                }

                if (donGia < 0)
                {
                    MessageBox.Show("Đơn giá không được âm!");
                    return;
                }

                // Lấy mã vật tư
                string maVatTu =
                    cboVatTu.SelectedValue.ToString();

                // Lấy tên vật tư
                string tenVatTu =
                    cboVatTu.Text;

                // Kiểm tra vật tư đã có trong phiếu chưa
                foreach (DataRow row in dtChiTiet.Rows)
                {
                    if (row["MaVatTu"].ToString() == maVatTu)
                    {
                        MessageBox.Show(
                            "Vật tư này đã có trong phiếu!");

                        return;
                    }
                }

                // Tính thành tiền
                decimal thanhTien =
                    soLuong * donGia;

                // Thêm vào DataTable
                DataRow newRow =
                    dtChiTiet.NewRow();

                newRow["MaVatTu"] = maVatTu;
                newRow["TenVatTu"] = tenVatTu;
                newRow["SoLuong"] = soLuong;
                newRow["DonGia"] = donGia;
                newRow["ThanhTien"] = thanhTien;

                dtChiTiet.Rows.Add(newRow);

                // Tính lại tổng
                TinhTongTienChiTiet();

                // Xóa ô nhập
                txtSoLuong.Clear();
                txtDonGia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm chi tiết:\n" +
                    ex.Message);
            }
        }
        private void TinhTongTienChiTiet()
        {
            decimal tong = 0;

            foreach (DataRow row in dtChiTiet.Rows)
            {
                tong += Convert.ToDecimal(
                    row["ThanhTien"]);
            }

            lblTong.Text =
                "Tổng: " +
                tong.ToString("N0") +
                " VNĐ";
        }

        private void LoadComboVatTu()
        {
            DataTable dt = vatTuBUS.GetAll();

            cboVatTu.DataSource = dt;

            cboVatTu.DisplayMember =
                "TenVatTu";

            cboVatTu.ValueMember =
                "MaVatTu";
        }

        private void TaoBangChiTiet()
        {
            dtChiTiet = new DataTable();

            dtChiTiet.Columns.Add(
                "MaVatTu",
                typeof(string));

            dtChiTiet.Columns.Add(
                "TenVatTu",
                typeof(string));

            dtChiTiet.Columns.Add(
                "SoLuong",
                typeof(decimal));

            dtChiTiet.Columns.Add(
                "DonGia",
                typeof(decimal));

            dtChiTiet.Columns.Add(
                "ThanhTien",
                typeof(decimal));

            dgvChiTiet.DataSource = dtChiTiet;

            dgvChiTiet.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvChiTiet.ReadOnly = true;

            dgvChiTiet.AllowUserToAddRows = false;
        }
    }
}
