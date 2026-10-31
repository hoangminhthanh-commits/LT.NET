using System;
using System.Drawing;
using System.Windows.Forms;
using HRM_Payroll.BUS;

namespace HRM_Payroll.GUI
{
    public class FrmBangLuong : Form
    {
        private readonly BangLuongBUS bus = new BangLuongBUS();
        private readonly DataGridView grid = new DataGridView();
        private readonly DateTimePicker month = new DateTimePicker();
        public FrmBangLuong()
        {
            Text = "Bảng lương và chốt lương"; Size = new Size(850, 550); StartPosition = FormStartPosition.CenterScreen;
            month.Format = DateTimePickerFormat.Custom; month.CustomFormat = "MM/yyyy"; month.ShowUpDown = true;
            month.SetBounds(20, 20, 120, 25); Controls.Add(month);
            Button view = new Button { Text = "Xem bảng lương", Location = new Point(160, 18), Size = new Size(130, 30) };
            view.Click += (s, e) => LoadData(); Controls.Add(view);
            Button close = new Button { Text = "Chốt lương tháng", Location = new Point(310, 18), Size = new Size(140, 30) };
            close.Click += (s, e) => ChotLuong(); Controls.Add(close);
            grid.SetBounds(20, 65, 790, 420); grid.ReadOnly = true; grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(grid); LoadData();
        }
        private string MonthKey { get { return month.Value.ToString("MM/yyyy"); } }
        private void LoadData() { try { grid.DataSource = bus.GetByMonth(MonthKey); } catch (Exception ex) { MessageBox.Show(ex.Message); } }
        private void ChotLuong()
        {
            if (MessageBox.Show("Chốt lương tháng " + MonthKey + "?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try { bus.ChotLuong(MonthKey); MessageBox.Show("Chốt lương thành công."); LoadData(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
