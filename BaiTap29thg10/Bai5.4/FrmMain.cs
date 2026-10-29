using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bai5._4.BUS;

namespace Bai5._4
{
    public partial class FrmMain : Form
    {
        private PhongBUS phongBUS =
            new PhongBUS();

        private KhachHangBUS khachHangBUS =
            new KhachHangBUS();

        private DichVuBUS dichVuBUS =
            new DichVuBUS();

        private PhieuDatPhongBUS phieuBUS =
            new PhieuDatPhongBUS();


        private DataTable dtPhong;

        private string soPhongDangChon = "";

        private int maKH =
            -1;

        private int maPhieuDangChon =
            -1;


        public FrmMain()
        {
            InitializeComponent();

            LoadLoaiPhong();
            LoadTrangThai();
            LoadPhong();
            LoadDichVu();

            dgvDichVu.AutoGenerateColumns = true;
        }

        private void LoadLoaiPhong()
        {
            cboLoaiPhong.Items.Clear();

            cboLoaiPhong.Items.Add("Tất cả");
            cboLoaiPhong.Items.Add("Đơn");
            cboLoaiPhong.Items.Add("Đôi");
            cboLoaiPhong.Items.Add("VIP");

            cboLoaiPhong.SelectedIndex = 0;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Tất cả");
            cboTrangThai.Items.Add("Trống");
            cboTrangThai.Items.Add("Đang ở");
            cboTrangThai.Items.Add("Đang dọn dẹp");

            cboTrangThai.SelectedIndex = 0;
        }


        private void LoadPhong()
        {
            dtPhong =
                phongBUS.GetAll();

            HienThiPhong(dtPhong);
        }


        private void HienThiPhong(DataTable dt)
        {
            flpPhong.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                Button btn =
                    new Button();

                btn.Width = 120;
                btn.Height = 90;

                btn.Margin =
                    new Padding(8);

                string soPhong =
                    row["SoPhong"].ToString();

                string loaiPhong =
                    row["LoaiPhong"].ToString();

                decimal gia =
                    Convert.ToDecimal(
                        row["GiaTheoGio"]);

                string trangThai =
                    row["TrangThai"].ToString();


                btn.Text =
                    soPhong
                    + "\n"
                    + loaiPhong
                    + "\n"
                    + trangThai
                    + "\n"
                    + gia.ToString("N0");


                btn.Tag =
                    soPhong;

                if (trangThai == "Trống")
                {
                    btn.BackColor =
                        Color.LightGreen;
                }
                else if (trangThai == "Đang ở")
                {
                    btn.BackColor =
                        Color.LightCoral;
                }
                else if (trangThai ==
                         "Đang dọn dẹp")
                {
                    btn.BackColor =
                        Color.Khaki;
                }


                btn.Click +=
                    BtnPhong_Click;


                flpPhong.Controls.Add(btn);
            }
        }

        private void BtnPhong_Click(
            object sender,
            EventArgs e)
        {
            Button btn =
                (Button)sender;

            soPhongDangChon =
                btn.Tag.ToString();


            MessageBox.Show(
                "Bạn đang chọn phòng "
                + soPhongDangChon);


            int maPhieu =
                phieuBUS.GetPhieuDangO(
                    soPhongDangChon);


            if (maPhieu != -1)
            {
                maPhieuDangChon =
                    maPhieu;

                LoadDichVuDaDung();

                TinhTien();
            }
            else
            {
                maPhieuDangChon =
                    -1;

                dgvDichVu.DataSource =
                    null;

                lblTienPhong.Text =
                    "Tiền phòng: 0 VNĐ";

                lblTienDichVu.Text =
                    "Tiền dịch vụ: 0 VNĐ";

                lblTongTien.Text =
                    "Tổng tiền: 0 VNĐ";
            }
        }

        private void LoadDichVu()
        {
            DataTable dt =
                dichVuBUS.GetAll();

            cboDichVu.DataSource =
                dt;

            cboDichVu.DisplayMember =
                "TenDV";

            cboDichVu.ValueMember =
                "MaDV";
        }

        private void btnTimKhach_Click(
            object sender,
            EventArgs e)
        {
            string cccd =
                txtCCCD.Text.Trim();


            if (cccd == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập CCCD!");

                return;
            }


            object khach =
                khachHangBUS
                .GetKhachHangTheoCCCD(
                    cccd);


            if (khach == null)
            {
                maKH = -1;

                txtHoTen.Clear();
                txtSoDienThoai.Clear();

                MessageBox.Show(
                    "Không tìm thấy khách hàng.\n"
                    + "Hãy nhập thông tin khách mới.");

                return;
            }

            dynamic data =
                khach;

            maKH =
                data.MaKH;

            txtHoTen.Text =
                data.HoTen;

            txtSoDienThoai.Text =
                data.SoDienThoai;


            MessageBox.Show(
                "Đã tìm thấy khách hàng!");
        }

        private void btnCheckIn_Click(
            object sender,
            EventArgs e)
        {
            if (soPhongDangChon == "")
            {
                MessageBox.Show(
                    "Vui lòng chọn phòng!");

                return;
            }

            string cccd =
                txtCCCD.Text.Trim();


            if (cccd == "")
            {
                MessageBox.Show(
                    "Vui lòng nhập CCCD!");

                return;
            }

            if (maKH == -1)
            {
                string hoTen =
                    txtHoTen.Text.Trim();

                string soDienThoai =
                    txtSoDienThoai.Text.Trim();


                if (hoTen == "")
                {
                    MessageBox.Show(
                        "Vui lòng nhập họ tên!");

                    return;
                }


                try
                {
                    maKH =
                        khachHangBUS
                        .ThemKhachHang(
                            hoTen,
                            cccd,
                            soDienThoai);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi thêm khách hàng:\n"
                        + ex.Message);

                    return;
                }
            }


            try
            {
                maPhieuDangChon =
                    phieuBUS.CheckIn(
                        soPhongDangChon,
                        maKH);


                MessageBox.Show(
                    "CHECK-IN thành công!\n"
                    + "Phòng: "
                    + soPhongDangChon);


                LoadPhong();


                LoadDichVuDaDung();

                TinhTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi CHECK-IN:\n"
                    + ex.Message);
            }
        }


        private void btnThemDV_Click(
            object sender,
            EventArgs e)
        {
            if (maPhieuDangChon == -1)
            {
                MessageBox.Show(
                    "Phòng chưa CHECK-IN!");

                return;
            }


            if (cboDichVu.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn dịch vụ!");

                return;
            }


            int soLuong;

            if (!int.TryParse(
                txtSoLuongDV.Text,
                out soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải lớn hơn 0!");

                return;
            }


            int maDV =
                Convert.ToInt32(
                    cboDichVu.SelectedValue);


            try
            {
                phieuBUS.ThemDichVu(
                    maPhieuDangChon,
                    maDV,
                    soLuong);


                MessageBox.Show(
                    "Đã thêm dịch vụ!");


                txtSoLuongDV.Clear();


                LoadDichVuDaDung();

                TinhTien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm dịch vụ:\n"
                    + ex.Message);
            }
        }


        private void LoadDichVuDaDung()
        {
            if (maPhieuDangChon == -1)
            {
                dgvDichVu.DataSource =
                    null;

                return;
            }


            DataTable dt =
                phieuBUS
                .GetDichVuDaDung(
                    maPhieuDangChon);


            dgvDichVu.DataSource =
                dt;


            if (dgvDichVu.Columns.Contains(
                "MaDV"))
            {
                dgvDichVu.Columns["MaDV"]
                    .HeaderText =
                    "Mã DV";
            }


            if (dgvDichVu.Columns.Contains(
                "TenDV"))
            {
                dgvDichVu.Columns["TenDV"]
                    .HeaderText =
                    "Tên dịch vụ";
            }


            if (dgvDichVu.Columns.Contains(
                "SoLuong"))
            {
                dgvDichVu.Columns["SoLuong"]
                    .HeaderText =
                    "Số lượng";
            }


            if (dgvDichVu.Columns.Contains(
                "DonGia"))
            {
                dgvDichVu.Columns["DonGia"]
                    .HeaderText =
                    "Đơn giá";
            }


            if (dgvDichVu.Columns.Contains(
                "ThanhTien"))
            {
                dgvDichVu.Columns["ThanhTien"]
                    .HeaderText =
                    "Thành tiền";
            }


            if (dgvDichVu.Columns.Contains(
                "ThoiGian"))
            {
                dgvDichVu.Columns["ThoiGian"]
                    .HeaderText =
                    "Thời gian";
            }


            dgvDichVu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void TinhTien()
        {
            if (maPhieuDangChon == -1)
                return;


            DateTime ngayNhan =
                phieuBUS
                .GetNgayNhanPhong(
                    maPhieuDangChon);


            DateTime hienTai =
                DateTime.Now;


            TimeSpan thoiGian =
                hienTai - ngayNhan;


            double soGio =
                Math.Ceiling(
                    thoiGian.TotalHours);


            if (soGio < 1)
                soGio = 1;


            decimal giaPhong =
                phieuBUS.GetGiaPhong(
                    soPhongDangChon);


            decimal tienPhong =
                (decimal)soGio
                * giaPhong;


            decimal tienDichVu =
                phieuBUS
                .TinhTienDichVu(
                    maPhieuDangChon);


            decimal tongTien =
                tienPhong
                + tienDichVu;


            lblTienPhong.Text =
                "Tiền phòng: "
                + tienPhong.ToString("N0")
                + " VNĐ";


            lblTienDichVu.Text =
                "Tiền dịch vụ: "
                + tienDichVu.ToString("N0")
                + " VNĐ";


            lblTongTien.Text =
                "Tổng tiền: "
                + tongTien.ToString("N0")
                + " VNĐ";
        }


        private void btnCheckOut_Click(
            object sender,
            EventArgs e)
        {
            if (maPhieuDangChon == -1)
            {
                MessageBox.Show(
                    "Phòng chưa CHECK-IN!");

                return;
            }


            DateTime ngayNhan =
                phieuBUS
                .GetNgayNhanPhong(
                    maPhieuDangChon);


            double soGio =
                Math.Ceiling(
                    (DateTime.Now
                    - ngayNhan)
                    .TotalHours);


            if (soGio < 1)
                soGio = 1;


            decimal giaPhong =
                phieuBUS.GetGiaPhong(
                    soPhongDangChon);


            decimal tienPhong =
                (decimal)soGio
                * giaPhong;


            decimal tienDichVu =
                phieuBUS
                .TinhTienDichVu(
                    maPhieuDangChon);


            decimal tongTien =
                tienPhong
                + tienDichVu;


            DialogResult result =
                MessageBox.Show(
                    "Tiền phòng: "
                    + tienPhong.ToString("N0")
                    + " VNĐ\n\n"

                    + "Tiền dịch vụ: "
                    + tienDichVu.ToString("N0")
                    + " VNĐ\n\n"

                    + "TỔNG TIỀN: "
                    + tongTien.ToString("N0")
                    + " VNĐ\n\n"

                    + "Xác nhận CHECK-OUT?",

                    "Thanh toán",

                    MessageBoxButtons.YesNo,

                    MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
                return;


            try
            {
                phieuBUS.CheckOut(
                    maPhieuDangChon,
                    soPhongDangChon,
                    tongTien);


                MessageBox.Show(
                    "CHECK-OUT thành công!\n\n"
                    + "Tổng thanh toán: "
                    + tongTien.ToString("N0")
                    + " VNĐ");


                maPhieuDangChon =
                    -1;

                maKH =
                    -1;

                soPhongDangChon =
                    "";


                txtCCCD.Clear();
                txtHoTen.Clear();
                txtSoDienThoai.Clear();
                txtSoLuongDV.Clear();


                dgvDichVu.DataSource =
                    null;


                lblTienPhong.Text =
                    "Tiền phòng: 0 VNĐ";

                lblTienDichVu.Text =
                    "Tiền dịch vụ: 0 VNĐ";

                lblTongTien.Text =
                    "Tổng tiền: 0 VNĐ";


                LoadPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi CHECK-OUT:\n"
                    + ex.Message);
            }
        }

        private void btnLocPhong_Click(
            object sender,
            EventArgs e)
        {
            if (dtPhong == null)
                return;


            DataView view =
                dtPhong.DefaultView;


            string dieuKien = "";


            if (cboLoaiPhong.SelectedIndex > 0)
            {
                string loai =
                    cboLoaiPhong
                    .SelectedItem
                    .ToString();


                dieuKien =
                    "LoaiPhong = '"
                    + loai.Replace("'", "''")
                    + "'";
            }


            if (cboTrangThai.SelectedIndex > 0)
            {
                string trangThai =
                    cboTrangThai
                    .SelectedItem
                    .ToString();


                if (dieuKien != "")
                    dieuKien += " AND ";


                dieuKien +=
                    "TrangThai = '"
                    + trangThai.Replace("'", "''")
                    + "'";
            }


            view.RowFilter =
                dieuKien;


            HienThiPhong(
                view.ToTable());
        }
    }
}