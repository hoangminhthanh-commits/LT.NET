namespace Bai4._5
{
    partial class FormMainMdi
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
            menuChucNang = new ToolStripMenuItem();
            menuMayTinh = new ToolStripMenuItem();
            menuDangKy = new ToolStripMenuItem();
            menuQuanLySanPham = new ToolStripMenuItem();
            menuNapXuatAnh = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuChucNang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuChucNang
            // 
            menuChucNang.DropDownItems.AddRange(new ToolStripItem[] { menuMayTinh, menuDangKy, menuQuanLySanPham, menuNapXuatAnh, menuThoat });
            menuChucNang.Name = "menuChucNang";
            menuChucNang.Size = new Size(93, 24);
            menuChucNang.Text = "Chức năng";
            // 
            // menuMayTinh
            // 
            menuMayTinh.Name = "menuMayTinh";
            menuMayTinh.Size = new Size(224, 26);
            menuMayTinh.Text = "Máy tính";
            menuMayTinh.Click += menuMayTinh_Click;
            // 
            // menuDangKy
            // 
            menuDangKy.Name = "menuDangKy";
            menuDangKy.Size = new Size(224, 26);
            menuDangKy.Text = "Đăng ký học viên";
            menuDangKy.Click += menuDangKy_Click;
            // 
            // menuQuanLySanPham
            // 
            menuQuanLySanPham.Name = "menuQuanLySanPham";
            menuQuanLySanPham.Size = new Size(224, 26);
            menuQuanLySanPham.Text = "Quản lý sản phẩm";
            menuQuanLySanPham.Click += menuQuanLySanPham_Click;
            // 
            // menuNapXuatAnh
            // 
            menuNapXuatAnh.Name = "menuNapXuatAnh";
            menuNapXuatAnh.Size = new Size(224, 26);
            menuNapXuatAnh.Text = "Nạp ảnh & Xuất CSV";
            menuNapXuatAnh.Click += menuNapXuatAnh_Click;
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(224, 26);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // FormMainMdi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMainMdi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuChucNang;
        private ToolStripMenuItem menuThoat;
        private ToolStripMenuItem menuMayTinh;
        private ToolStripMenuItem menuDangKy;
        private ToolStripMenuItem menuQuanLySanPham;
        private ToolStripMenuItem menuNapXuatAnh;
    }
}
