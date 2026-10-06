namespace Bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvProducts.AutoGenerateColumns = false;

            productBindingSource.DataSource = products;
            dgvProducts.DataSource = productBindingSource;
        }
        private List<Product> products = new List<Product>();

        private BindingSource productBindingSource = new BindingSource();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    ProductId = txtProductId.Text,
                    ProductName = txtProductName.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Category = txtCategory.Text
                };

                products.Add(product);

                productBindingSource.DataSource = null;
                productBindingSource.DataSource = products;

                ClearInputs();

                MessageBox.Show(
                    "Thêm sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch
            {
                MessageBox.Show(
                    "Vui lòng nhập dữ liệu hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                selectedProduct.ProductId = txtProductId.Text;
                selectedProduct.ProductName = txtProductName.Text;
                selectedProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                selectedProduct.Quantity = int.Parse(txtQuantity.Text);
                selectedProduct.Category = txtCategory.Text;

                productBindingSource.ResetBindings(false);

                ClearInputs();

                selectedProduct = null;
            }
            catch
            {
                MessageBox.Show(
                    "Vui lòng nhập dữ liệu hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
                return;

            Product product = (Product)dgvProducts.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm '{product.ProductName}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                products.Remove(product);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                ClearInputs();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                productBindingSource.DataSource = products;
                return;
            }

            List<Product> result = products.FindAll(p => p.ProductName.ToLower().Contains(keyword));

            productBindingSource.DataSource = result;
        }
        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtCategory.Clear();

            txtProductId.Focus();
        }

        private Product selectedProduct;
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

            if (row.IsNewRow)
                return;

            selectedProduct = products[e.RowIndex];

            txtProductId.Text = selectedProduct.ProductId;
            txtProductName.Text = selectedProduct.ProductName;
            txtUnitPrice.Text = selectedProduct.UnitPrice.ToString();
            txtQuantity.Text = selectedProduct.Quantity.ToString();
            txtCategory.Text = selectedProduct.Category;
        }

    }
}
