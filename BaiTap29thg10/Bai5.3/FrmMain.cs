using Bai5._3.BLL;
using System.Data;

namespace Bai5._3
{
    public partial class FrmMain : Form
    {
        private BanAnBLL banBLL = new BanAnBLL();
        private MonAnBLL monBLL = new MonAnBLL();
        private HoaDonBLL hoaDonBLL = new HoaDonBLL();

        private int maBanDangChon = -1;

        public FrmMain()
        {
            InitializeComponent();

            LoadBan();
            LoadMon();
        }
        private void LoadBan()
        {
            flpBan.Controls.Clear();

            DataTable dt = banBLL.GetAll();

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();

                btn.Width = 110;
                btn.Height = 80;

                btn.Margin = new Padding(10);

                btn.Text = row["TenBan"].ToString();

                btn.Tag = row["MaBan"];

                string trangThai = row["TrangThai"].ToString();

                if (trangThai == "Trống")
                {
                    btn.BackColor = Color.LightGreen;
                }
                else
                {
                    btn.BackColor = Color.LightCoral;
                }

                btn.Click += BtnBan_Click;

                flpBan.Controls.Add(btn);
            }
        }
        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            maBanDangChon =
                Convert.ToInt32(btn.Tag);

            lblBan.Text =
                "Đang chọn: " + btn.Text;

            LoadHoaDon();
        }
        private void LoadMon()
        {
            DataTable dt = monBLL.GetAll();

            cboMon.DataSource = dt;

            cboMon.DisplayMember = "TenMon";

            cboMon.ValueMember = "MaMon";
        }
        private void LoadHoaDon()
        {
            if (maBanDangChon == -1)
                return;

            DataTable dt =
                hoaDonBLL.GetChiTietHoaDon(
                    maBanDangChon);

            dgvHoaDon.DataSource = dt;

            dgvHoaDon.Columns["MaMon"].HeaderText = "Mã món";
            dgvHoaDon.Columns["TenMon"].HeaderText = "Tên món";
            dgvHoaDon.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvHoaDon.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvHoaDon.Columns["ThanhTien"].HeaderText = "Thành tiền";

            TinhTongTien();
        }
        private decimal TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in dgvHoaDon.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["ThanhTien"].Value != null)
                {
                    tong += Convert.ToDecimal(
                        row.Cells["ThanhTien"].Value);
                }
            }

            lblTongTien.Text =
                "Tổng tiền: "
                + tong.ToString("N0")
                + " VNĐ";

            return tong;
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn trước!");
                return;
            }

            if (cboMon.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn món!");
                return;
            }

            if (!int.TryParse(
                txtSoLuong.Text,
                out int soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên lớn hơn 0!");
                return;
            }

            int maMon =
                Convert.ToInt32(
                    cboMon.SelectedValue);

            try
            {
                hoaDonBLL.ThemMon(
                    maBanDangChon,
                    maMon,
                    soLuong);

                MessageBox.Show(
                    "Thêm món thành công!");

                LoadHoaDon();

                LoadBan();

                txtSoLuong.Text = "1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thêm món:\n" +
                    ex.Message);
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn!");
                return;
            }

            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn món cần sửa!");
                return;
            }

            if (!int.TryParse(
                txtSoLuong.Text,
                out int soLuong)
                || soLuong <= 0)
            {
                MessageBox.Show(
                    "Số lượng phải lớn hơn 0!");
                return;
            }

            int maMon = Convert.ToInt32(
                dgvHoaDon.CurrentRow
                    .Cells["MaMon"]
                    .Value);

            try
            {
                hoaDonBLL.SuaMon(
                    maBanDangChon,
                    maMon,
                    soLuong);

                LoadHoaDon();

                MessageBox.Show(
                    "Đã sửa số lượng món!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi sửa món:\n" +
                    ex.Message);
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn!");
                return;
            }

            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn món cần xóa!");
                return;
            }

            int maMon = Convert.ToInt32(
                dgvHoaDon.CurrentRow
                    .Cells["MaMon"]
                    .Value);

            string tenMon =
                dgvHoaDon.CurrentRow
                    .Cells["TenMon"]
                    .Value
                    .ToString();

            DialogResult result =
                MessageBox.Show(
                    "Bạn có chắc muốn xóa món: "
                    + tenMon + "?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                hoaDonBLL.XoaMon(
                    maBanDangChon,
                    maMon);

                LoadHoaDon();

                MessageBox.Show(
                    "Đã xóa món!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi xóa món:\n" +
                    ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maBanDangChon == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn cần thanh toán!");
                return;
            }

            decimal tongTien = TinhTongTien();

            if (tongTien <= 0)
            {
                MessageBox.Show(
                    "Bàn này chưa có món để thanh toán!");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Tổng tiền: "
                    + tongTien.ToString("N0")
                    + " VNĐ\n\n"
                    + "Bạn có chắc muốn thanh toán?",
                    "Xác nhận thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                hoaDonBLL.ThanhToan(
                    maBanDangChon,
                    tongTien);

                MessageBox.Show(
                    "Thanh toán thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvHoaDon.DataSource = null;

                lblTongTien.Text =
                    "Tổng tiền: 0 VNĐ";

                LoadBan();

                maBanDangChon = -1;

                lblBan.Text =
                    "Đang chọn: chưa chọn bàn";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi thanh toán:\n"
                    + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
