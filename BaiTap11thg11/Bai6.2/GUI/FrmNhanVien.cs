using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HRM_Payroll.BUS;

namespace HRM_Payroll.GUI
{
    public class FrmNhanVien : Form
    {
        private readonly NhanVienBUS bus = new NhanVienBUS();
        private readonly DataGridView grid = new DataGridView();
        private readonly TextBox txtTen = new TextBox(), txtCCCD = new TextBox(), txtLuong = new TextBox(), txtHeSo = new TextBox(), txtTim = new TextBox();
        private readonly DateTimePicker dtNgaySinh = new DateTimePicker();
        private readonly ComboBox cboPB = new ComboBox();
        private int selectedId = 0;

        public FrmNhanVien()
        {
            Text = "Quản lý nhân viên"; Size = new Size(1050, 650); StartPosition = FormStartPosition.CenterScreen;
            AddLabel("Họ tên", 20, 20); txtTen.SetBounds(100, 18, 180, 25); Controls.Add(txtTen);
            AddLabel("Ngày sinh", 300, 20); dtNgaySinh.SetBounds(380, 18, 150, 25); Controls.Add(dtNgaySinh);
            AddLabel("CCCD", 550, 20); txtCCCD.SetBounds(610, 18, 150, 25); Controls.Add(txtCCCD);
            AddLabel("Phòng ban", 20, 60); cboPB.SetBounds(100, 58, 180, 25); cboPB.DropDownStyle = ComboBoxStyle.DropDownList; Controls.Add(cboPB);
            AddLabel("Lương CB", 300, 60); txtLuong.SetBounds(380, 58, 150, 25); Controls.Add(txtLuong);
            AddLabel("Hệ số", 550, 60); txtHeSo.SetBounds(610, 58, 100, 25); Controls.Add(txtHeSo);
            AddButton("Thêm", 20, 100, Add); AddButton("Sửa", 110, 100, Update); AddButton("Xóa", 200, 100, Delete);
            txtTim.SetBounds(330, 105, 220, 25); Controls.Add(txtTim); AddButton("Tìm kiếm", 560, 100, LoadData);
            grid.SetBounds(20, 150, 990, 440); grid.ReadOnly = true; grid.AllowUserToAddRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect; grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.CellClick += Grid_CellClick; Controls.Add(grid);
            LoadPhongBan(); LoadData();
        }

        private void AddLabel(string text, int x, int y) { Controls.Add(new Label { Text = text, Location = new Point(x, y + 4), AutoSize = true }); }
        private void AddButton(string text, int x, int y, Action action)
        {
            var b = new Button { Text = text, Location = new Point(x, y), Size = new Size(80, 30) };
            b.Click += (s, e) => { try { action(); } catch (Exception ex) { MessageBox.Show(ex.Message); } };
            Controls.Add(b);
        }
        private void LoadPhongBan()
        {
            DataTable dt = bus.GetPhongBan(); cboPB.DataSource = dt; cboPB.DisplayMember = "TenPB"; cboPB.ValueMember = "MaPB";
        }
        private void LoadData() { grid.DataSource = bus.GetAll(txtTim.Text.Trim()); }
        private DateTime? NgaySinh { get { return dtNgaySinh.Value.Date; } }
        private void Add()
        {
            bus.Insert(txtTen.Text, NgaySinh, txtCCCD.Text.Trim(), Convert.ToInt32(cboPB.SelectedValue),
                decimal.Parse(txtLuong.Text), double.Parse(txtHeSo.Text));
            LoadData(); ClearInput();
        }
        private void Update()
        {
            if (selectedId == 0) throw new Exception("Hãy chọn nhân viên cần sửa.");
            bus.Update(selectedId, txtTen.Text, NgaySinh, txtCCCD.Text.Trim(), Convert.ToInt32(cboPB.SelectedValue),
                decimal.Parse(txtLuong.Text), double.Parse(txtHeSo.Text));
            LoadData();
        }
        private void Delete()
        {
            if (selectedId == 0) throw new Exception("Hãy chọn nhân viên cần xóa.");
            if (MessageBox.Show("Xóa nhân viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { bus.Delete(selectedId); LoadData(); ClearInput(); }
        }
        private void ClearInput() { selectedId = 0; txtTen.Clear(); txtCCCD.Clear(); txtLuong.Clear(); txtHeSo.Text = "1"; }
        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = grid.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(r.Cells["MaNV"].Value);
            txtTen.Text = Convert.ToString(r.Cells["HoTen"].Value);
            txtCCCD.Text = Convert.ToString(r.Cells["CCCD"].Value);
            txtLuong.Text = Convert.ToString(r.Cells["LuongCoBan"].Value);
            txtHeSo.Text = Convert.ToString(r.Cells["HeSoLuong"].Value);
            if (r.Cells["MaPB"].Value != DBNull.Value) cboPB.SelectedValue = r.Cells["MaPB"].Value;
            if (r.Cells["NgaySinh"].Value != DBNull.Value) dtNgaySinh.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
        }
    }
}
