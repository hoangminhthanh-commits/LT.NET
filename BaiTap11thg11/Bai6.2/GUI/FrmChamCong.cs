using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HRM_Payroll.BUS;

namespace HRM_Payroll.GUI
{
    public class FrmChamCong : Form
    {
        private readonly ChamCongBUS bus = new ChamCongBUS();
        private readonly DataGridView grid = new DataGridView();
        private readonly DateTimePicker month = new DateTimePicker();
        private DataTable table;

        public FrmChamCong()
        {
            Text = "Chấm công tháng - Disconnected Model"; Size = new Size(900, 580);
            StartPosition = FormStartPosition.CenterScreen;
            month.Format = DateTimePickerFormat.Custom; month.CustomFormat = "MM/yyyy"; month.ShowUpDown = true;
            month.SetBounds(20, 20, 120, 25); Controls.Add(month);
            Button load = new Button { Text = "Tải dữ liệu", Location = new Point(160, 18), Size = new Size(100, 30) };
            load.Click += (s, e) => Safe(LoadMonth); Controls.Add(load);
            Button save = new Button { Text = "Lưu chấm công", Location = new Point(275, 18), Size = new Size(120, 30) };
            save.Click += (s, e) => Safe(Save); Controls.Add(save);
            grid.SetBounds(20, 65, 840, 440); grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AllowUserToAddRows = false; Controls.Add(grid);
            LoadMonth();
        }
        private string MonthKey { get { return month.Value.ToString("MM/yyyy"); } }
        private void Safe(Action a) { try { a(); } catch (Exception ex) { MessageBox.Show(ex.Message); } }
        private void LoadMonth()
        {
            table = bus.LoadMonth(MonthKey);
            grid.DataSource = table;
            grid.Columns["MaCong"].Visible = false;
            grid.Columns["MaNV"].ReadOnly = true;
            grid.Columns["HoTen"].ReadOnly = true;
            grid.Columns["ThangNam"].ReadOnly = true;
        }
        private void Save()
        {
            grid.EndEdit();
            bus.SaveMonth(table, MonthKey);
            MessageBox.Show("Đã lưu chấm công.");
            LoadMonth();
        }
    }
}
