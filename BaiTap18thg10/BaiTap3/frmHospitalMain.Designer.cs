namespace BaiTap3
{
    partial class frmHospitalMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuReload = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuManage = new ToolStripMenuItem();
            mnuPatientProfiles = new ToolStripMenuItem();
            mnuDoctorSchedule = new ToolStripMenuItem();
            mnuDepartment = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuCloseAll = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblDoctorOnDuty = new ToolStripStatusLabel();
            progressBar1 = new ToolStripProgressBar();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuManage, mnuWindow });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(922, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuReload, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(85, 24);
            mnuSystem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(190, 26);
            mnuLogout.Text = "Đăng xuất";
            // 
            // mnuReload
            // 
            mnuReload.Name = "mnuReload";
            mnuReload.Size = new Size(190, 26);
            mnuReload.Text = "Nạp lại dữ liệu";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(190, 26);
            mnuExit.Text = "Thoát";
            // 
            // mnuManage
            // 
            mnuManage.DropDownItems.AddRange(new ToolStripItem[] { mnuPatientProfiles, mnuDoctorSchedule, mnuDepartment });
            mnuManage.Name = "mnuManage";
            mnuManage.Size = new Size(73, 24);
            mnuManage.Text = "Quản lý";
            // 
            // mnuPatientProfiles
            // 
            mnuPatientProfiles.Name = "mnuPatientProfiles";
            mnuPatientProfiles.Size = new Size(245, 26);
            mnuPatientProfiles.Text = "Hồ sơ Bệnh nhân";
            // 
            // mnuDoctorSchedule
            // 
            mnuDoctorSchedule.Name = "mnuDoctorSchedule";
            mnuDoctorSchedule.Size = new Size(245, 26);
            mnuDoctorSchedule.Text = "Danh mục Bác sĩ";
            // 
            // mnuDepartment
            // 
            mnuDepartment.Name = "mnuDepartment";
            mnuDepartment.Size = new Size(245, 26);
            mnuDepartment.Text = "Danh mục Khoa/Phòng";
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, mnuCloseAll });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(68, 24);
            mnuWindow.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(209, 26);
            mnuCascade.Text = "Sắp xếp Xếp tầng";
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(209, 26);
            mnuTileHorizontal.Text = "Ngang";
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(209, 26);
            mnuTileVertical.Text = "Dọc";
            // 
            // mnuCloseAll
            // 
            mnuCloseAll.Name = "mnuCloseAll";
            mnuCloseAll.Size = new Size(209, 26);
            mnuCloseAll.Text = "Đóng tất cả";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDoctorOnDuty, progressBar1 });
            statusStrip1.Location = new Point(0, 706);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(922, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDoctorOnDuty
            // 
            lblDoctorOnDuty.Name = "lblDoctorOnDuty";
            lblDoctorOnDuty.Size = new Size(151, 20);
            lblDoctorOnDuty.Text = "toolStripStatusLabel1";
            // 
            // progressBar1
            // 
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 18);
            // 
            // frmHospitalMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 732);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmHospitalMain";
            Text = "Hệ thống quản lý bệnh viện";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem mnuReload;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuManage;
        private ToolStripMenuItem mnuPatientProfiles;
        private ToolStripMenuItem mnuDoctorSchedule;
        private ToolStripMenuItem mnuDepartment;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem mnuCloseAll;
        private ToolStripStatusLabel lblDoctorOnDuty;
        private ToolStripProgressBar progressBar1;
    }
}
