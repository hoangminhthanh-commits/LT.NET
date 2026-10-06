using System;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace Bai4._7
{
    public partial class FormMain : Form
    {
        private System.Windows.Forms.Timer timer;
        public FormMain()
        {
            InitializeComponent();

            IsMdiContainer = true;

            lblUser.Text = "Người dùng: Admin";
            lblMessage.Text = "Sẵn sàng";

            timer = new System.Windows.Forms.Timer();

            timer.Interval = 1000;

            timer.Tick += (s, e) =>
            {
                lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            };

            timer.Start();

            mnuStudent.Click += (s, e) => MoFormCon<FormStudent>();
            mnuProduct.Click += (s, e) => MoFormCon<FormProduct>();

            btnStudent.Click += (s, e) => MoFormCon<FormStudent>();
            btnProduct.Click += (s, e) => MoFormCon<FormProduct>();

            mnuCascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);

            mnuHorizontal.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);

            mnuVertical.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);

            mnuExit.Click += (s, e) => Close();

            mnuLogout.Click += (s, e) =>
            {
                foreach (Form f in MdiChildren)
                    f.Close();

                lblUser.Text = "Người dùng: Chưa đăng nhập";
                lblMessage.Text = "Đã đăng xuất";
            };
        }

        private void MoFormCon<T>() where T : Form, new()
        {
            T form = MdiChildren.OfType<T>().FirstOrDefault();

            if (form == null || form.IsDisposed)
            {
                form = new T();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                if (form.WindowState == FormWindowState.Minimized)
                    form.WindowState = FormWindowState.Normal;

                form.Activate();
            }
        }

        public void CapNhatTrangThai(string thongBao)
        {
            lblMessage.Text = thongBao;
        }
    }
}
