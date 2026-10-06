namespace Bai4._8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            IsMdiContainer = true;

            progressBarMain.Minimum = 0;
            progressBarMain.Maximum = 100;
            progressBarMain.Value = 0;

            lblStatus.Text = "Sẵn sàng";
        }
        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                if (f is FormSinhVien)
                {
                    f.Activate();
                    return;
                }
            }

            FormSinhVien frm = new FormSinhVien(this);
            frm.MdiParent = this;
            frm.Show();
        }
        public void CapNhatTienTrinh(int phanTram)
        {
            if (phanTram < 0) phanTram = 0;
            if (phanTram > 100) phanTram = 100;

            progressBarMain.Value = phanTram;
            lblStatus.Text = "Đang nạp dữ liệu: "
                           + phanTram + "%";
        }

        public void CapNhatTrangThai(string thongBao)
        {
            lblStatus.Text = thongBao;
        }
    }
}
