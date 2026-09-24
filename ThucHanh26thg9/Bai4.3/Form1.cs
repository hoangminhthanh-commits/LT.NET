using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace Bai4._3
{
    public partial class Form1 : Form
    {
        BindingList<ProductModel> danhSachSanPham = new BindingList<ProductModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.RowHeadersVisible = false;

            dgvSanPham.DataSource = danhSachSanPham;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider.SetError(txtTenSP, "Vui lòng nhập mã sản phẩm!");
                MessageBox.Show("Vui lòng nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                errorProvider.SetError(txtMaSP, "Vui lòng nhập tên sản phẩm!");
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return;
            }

            if (!decimal.TryParse(txtGia.Text, out decimal gia))
            {
                errorProvider.SetError(txtGia, "Giá sản phẩm không hợp lệ!");
                MessageBox.Show("Giá sản phẩm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGia.Focus();
                return;
            }
            ProductModel sp = new ProductModel();
            {
                sp.MaSP = txtTenSP.Text;
                sp.TenSP = txtMaSP.Text;
                sp.Gia = decimal.Parse(txtGia.Text);
            }

            danhSachSanPham.Add(sp);

            txtTenSP.Clear();
            txtMaSP.Clear();
            txtGia.Clear();

            txtTenSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null)
                return;

            ProductModel sp = dgvSanPham.CurrentRow.DataBoundItem as ProductModel;

            if (sp != null)
            {
                danhSachSanPham.Remove(sp);
            }
        }
    }
}
