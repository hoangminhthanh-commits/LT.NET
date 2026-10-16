
using System;
using System.Linq;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmHospitalMain : Form
    {
        public frmHospitalMain()
        {
            InitializeComponent();

            // Cấu hình Form cha MDI
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            // Thanh trạng thái
            lblDoctorOnDuty.Text = "Bác sĩ trực: Nguyễn Văn A";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Gắn sự kiện Menu
            mnuPatientProfiles.Click += mnuPatientProfiles_Click;
            mnuDoctorSchedule.Click += mnuDoctorSchedule_Click;

            mnuCascade.Click += mnuCascade_Click;
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            mnuTileVertical.Click += mnuTileVertical_Click;
            mnuCloseAll.Click += mnuCloseAll_Click;

            mnuReload.Click += mnuReload_Click;
            mnuLogout.Click += mnuLogout_Click;
            mnuExit.Click += mnuExit_Click;
        }

        // Mở Form con và không cho mở trùng
        private void OpenMdiChild<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == typeof(T))
                {
                    if (child.WindowState == FormWindowState.Minimized)
                    {
                        child.WindowState = FormWindowState.Normal;
                    }

                    child.BringToFront();
                    child.Activate();
                    return;
                }
            }

            T form = new T();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            form.BringToFront();
            form.Activate();
        }

        // Mở hồ sơ bệnh nhân
        private void mnuPatientProfiles_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frmPatientProfiles>();
        }

        // Mở lịch trực bác sĩ
        private void mnuDoctorSchedule_Click(object sender, EventArgs e)
        {
            OpenMdiChild<frmDoctorSchedule>();
        }

        // Sắp xếp xếp tầng
        private void mnuCascade_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        // Sắp xếp ngang
        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }

        // Sắp xếp dọc
        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
        }

        // Đóng tất cả Form con
        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren.ToArray())
            {
                child.Close();
            }
        }

        // Nạp lại dữ liệu
        private void mnuReload_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Value = 100;

            MessageBox.Show(
                "Đã thực hiện yêu cầu nạp lại dữ liệu.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            progressBar1.Value = 0;
        }

        // Đăng xuất
        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                mnuCloseAll_Click(sender, e);
                lblDoctorOnDuty.Text = "Chưa đăng nhập";
            }
        }

        // Thoát chương trình
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Danh mục khoa/phòng
        private void mnuDepartment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chức năng quản lý khoa/phòng chưa được xây dựng.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
