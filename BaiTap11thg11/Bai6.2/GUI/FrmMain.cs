using System.Drawing;
using System.Windows.Forms;

namespace HRM_Payroll.GUI
{
    public class FrmMain : Form
    {
        public FrmMain()
        {
            Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ & TÍNH LƯƠNG";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(700, 420);
            var title = new Label { Text = "HRM & PAYROLL SYSTEM", Font = new Font("Arial", 20, FontStyle.Bold),
                AutoSize = true, Location = new Point(150, 55) };
            Controls.Add(title);
            AddButton("Quản lý nhân viên", 230, 130, () => new FrmNhanVien().ShowDialog());
            AddButton("Chấm công tháng", 230, 190, () => new FrmChamCong().ShowDialog());
            AddButton("Tính lương / Chốt lương", 230, 250, () => new FrmBangLuong().ShowDialog());
        }
        private void AddButton(string text, int x, int y, System.Action action)
        {
            var b = new Button { Text = text, Location = new Point(x, y), Size = new Size(230, 42) };
            b.Click += (s, e) => action(); Controls.Add(b);
        }
    }
}
