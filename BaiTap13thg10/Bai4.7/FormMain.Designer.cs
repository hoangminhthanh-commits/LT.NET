namespace Bai4._7
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            toolMain = new ToolStrip();
            btnStudent = new ToolStripButton();
            btnProduct = new ToolStripButton();
            statusMain = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblMessage = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            menuMain = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            mnuStudent = new ToolStripMenuItem();
            mnuProduct = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuHorizontal = new ToolStripMenuItem();
            mnuVertical = new ToolStripMenuItem();
            toolMain.SuspendLayout();
            statusMain.SuspendLayout();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // toolMain
            // 
            toolMain.ImageScalingSize = new Size(20, 20);
            toolMain.Items.AddRange(new ToolStripItem[] { btnStudent, btnProduct });
            toolMain.Location = new Point(0, 28);
            toolMain.Name = "toolMain";
            toolMain.Size = new Size(800, 27);
            toolMain.TabIndex = 2;
            toolMain.Text = "toolStrip1";
            // 
            // btnStudent
            // 
            btnStudent.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnStudent.Image = (Image)resources.GetObject("btnStudent.Image");
            btnStudent.ImageTransparentColor = Color.Magenta;
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(72, 24);
            btnStudent.Text = "Sinh viên";
            // 
            // btnProduct
            // 
            btnProduct.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageTransparentColor = Color.Magenta;
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(79, 24);
            btnProduct.Text = "Sản phẩm";
            // 
            // statusMain
            // 
            statusMain.ImageScalingSize = new Size(20, 20);
            statusMain.Items.AddRange(new ToolStripItem[] { lblUser, lblMessage, lblClock });
            statusMain.Location = new Point(0, 424);
            statusMain.Name = "statusMain";
            statusMain.Size = new Size(800, 26);
            statusMain.TabIndex = 3;
            statusMain.Text = "statusStrip1";
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(140, 20);
            lblUser.Text = "Người dùng: Admin";
            // 
            // lblMessage
            // 
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(68, 20);
            lblMessage.Text = "Sẵn sàng";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(63, 20);
            lblClock.Text = "00:00:00";
            // 
            // menuMain
            // 
            menuMain.ImageScalingSize = new Size(20, 20);
            menuMain.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, danhMụcToolStripMenuItem, cửaSổToolStripMenuItem });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(800, 28);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuExit });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(160, 26);
            mnuLogout.Text = "Đăng xuất";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(160, 26);
            mnuExit.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuStudent, mnuProduct });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuStudent
            // 
            mnuStudent.Name = "mnuStudent";
            mnuStudent.Size = new Size(210, 26);
            mnuStudent.Text = "Quản lý sinh viên";
            // 
            // mnuProduct
            // 
            mnuProduct.Name = "mnuProduct";
            mnuProduct.Size = new Size(210, 26);
            mnuProduct.Text = "Quản lý sản phẩm";
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuHorizontal, mnuVertical });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(190, 26);
            mnuCascade.Text = "Cascade";
            // 
            // mnuHorizontal
            // 
            mnuHorizontal.Name = "mnuHorizontal";
            mnuHorizontal.Size = new Size(190, 26);
            mnuHorizontal.Text = "Tile Horizontal";
            // 
            // mnuVertical
            // 
            mnuVertical.Name = "mnuVertical";
            mnuVertical.Size = new Size(190, 26);
            mnuVertical.Text = "Tile Vertical";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusMain);
            Controls.Add(toolMain);
            Controls.Add(menuMain);
            IsMdiContainer = true;
            Name = "FormMain";
            Text = "Hệ thống quản lý";
            WindowState = FormWindowState.Maximized;
            toolMain.ResumeLayout(false);
            toolMain.PerformLayout();
            statusMain.ResumeLayout(false);
            statusMain.PerformLayout();
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolMain;
        private StatusStrip statusMain;
        private MenuStrip menuMain;
        private ToolStripButton btnStudent;
        private ToolStripButton btnProduct;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblMessage;
        private ToolStripStatusLabel lblClock;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuLogout;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem mnuStudent;
        private ToolStripMenuItem mnuProduct;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuHorizontal;
        private ToolStripMenuItem mnuVertical;
    }
}
