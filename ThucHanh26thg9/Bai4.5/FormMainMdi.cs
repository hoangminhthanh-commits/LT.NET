using System;
using Bai4._1;
using Bai4._2;
using Bai4._3;
using Bai4._4;

namespace Bai4._5
{
    public partial class FormMainMdi : Form
    {
        public FormMainMdi()
        {
            InitializeComponent();
        }
        private void menuMayTinh_Click(object sender, EventArgs e)
        {
            Bai4._1.Form1 child = new Bai4._1.Form1();
            child.MdiParent = this;
            child.Show();
        }

        private void menuDangKy_Click(object sender, EventArgs e)
        {
            Bai4._2.Form1 child = new Bai4._2.Form1();
            child.MdiParent = this;
            child.Show();
        }

        private void menuQuanLySanPham_Click(object sender, EventArgs e)
        {
            Bai4._3.Form1 child = new Bai4._3.Form1();
            child.MdiParent = this;
            child.Show();
        }
        private void menuNapXuatAnh_Click(object sender, EventArgs e)
        {
            Bai4._4.Form1 child = new Bai4._4.Form1();
            child.MdiParent = this;
            child.Show();
        }
        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
