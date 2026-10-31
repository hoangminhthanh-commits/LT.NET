using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBanHangMini.GUI
{
    public class FrmMain : Form
    {
        private Panel menu, content;
        public FrmMain()
        {
            Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG - SIÊU THỊ MINI";
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1000, 650);
            menu = new Panel { Dock = DockStyle.Left, Width = 220, BackColor = Color.FromArgb(32, 45, 65) };
            content = new Panel { Dock = DockStyle.Fill, BackColor = Color.FromArgb(245, 247, 250) };
            Controls.Add(content); Controls.Add(menu);

            Label logo = new Label { Text = "MINI MART\nQUẢN LÝ BÁN HÀNG", ForeColor = Color.White,
                Font = new Font("Segoe UI", 15, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top, Height = 100 };
            menu.Controls.Add(logo);

            AddMenu("Trang chủ", 115, () => ShowHome());
            AddMenu("Quản lý sản phẩm", 170, () => OpenChild(new FrmSanPham()));
            AddMenu("Quản lý khách hàng", 225, () => OpenChild(new FrmKhachHang()));
            AddMenu("Quản lý nhân viên", 280, () => OpenChild(new FrmNhanVien()));
            AddMenu("Bán hàng / Lập hóa đơn", 335, () => OpenChild(new FrmBanHang()));
            AddMenu("Thống kê - Báo cáo", 390, () => OpenChild(new FrmThongKe()));
            AddMenu("Thoát", 445, () => Close());
            ShowHome();
        }
        private void AddMenu(string title, int top, Action action)
        {
            Button b = new Button { Text = title, Left = 12, Top = top, Width = 196, Height = 42,
                FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(47, 65, 91),
                ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand };
            b.FlatAppearance.BorderSize = 0; b.Click += (s, e) => action(); menu.Controls.Add(b);
        }
        private void ShowHome()
        {
            content.Controls.Clear();
            Label title = new Label { Text = "TỔNG QUAN HỆ THỐNG", Left = 35, Top = 30, Width = 700, Height = 45,
                Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = Color.FromArgb(32,45,65) };
            Label note = new Label { Text = "Chọn chức năng ở thanh menu bên trái để bắt đầu làm việc.",
                Left = 38, Top = 95, AutoSize = true, Font = new Font("Segoe UI", 12) };
            content.Controls.Add(title); content.Controls.Add(note);
        }
        private void OpenChild(Form f)
        {
            content.Controls.Clear();
            f.TopLevel = false; f.FormBorderStyle = FormBorderStyle.None; f.Dock = DockStyle.Fill;
            content.Controls.Add(f); f.Show();
        }
    }
}
