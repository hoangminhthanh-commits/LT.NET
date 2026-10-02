using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TechMartProductManager;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products =
            new BindingList<Product>();

        private BindingSource productBindingSource =
            new BindingSource();

        private Product? selectedProduct;

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupCategories();
            productBindingSource.DataSource = products;
            dgvProducts.DataSource = productBindingSource;
            UpdateStatus();
            dgvProducts.CellClick += dgvProducts_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            btnChooseImage.Click += btnChooseImage_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;

            mnuExportCsv.Click += mnuExportCsv_Click;
            mnuExit.Click += mnuExit_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = false;
        }
        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            colProductId.DataPropertyName = "ProductId";
            colProductName.DataPropertyName = "ProductName";
            colCategory.DataPropertyName = "CategoryName";
            colUnitPrice.DataPropertyName = "UnitPrice";
            colQuantity.DataPropertyName = "Quantity";
            colUnitPrice.DefaultCellStyle.Format = "#,##0 \"VNĐ\"";
            colUnitPrice.DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
        }
        private void SetupCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Điện thoại"
                },

                new Category
                {
                    Id = 2,
                    Name = "Laptop"
                },

                new Category
                {
                    Id = 3,
                    Name = "Phụ kiện"
                }
            };

            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
        }
        private bool ValidateInput()
        {
            errorProvider.Clear();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(
                    txtProductName,
                    "Tên sản phẩm không được để trống."
                );

                isValid = false;
            }
            if (!decimal.TryParse(
                txtUnitPrice.Text,
                out decimal unitPrice))
            {
                errorProvider.SetError(
                    txtUnitPrice,
                    "Đơn giá phải là số."
                );

                isValid = false;
            }
            else if (unitPrice <= 0)
            {
                errorProvider.SetError(
                    txtUnitPrice,
                    "Đơn giá phải lớn hơn 0."
                );

                isValid = false;
            }

            if (!int.TryParse(
                txtQuantity.Text,
                out int quantity))
            {
                errorProvider.SetError(
                    txtQuantity,
                    "Số lượng phải là số nguyên."
                );
                isValid = false;
            }
            else if (quantity < 0)
            {
                errorProvider.SetError(
                    txtQuantity,
                    "Số lượng phải lớn hơn hoặc bằng 0."
                );

                isValid = false;
            }
            return isValid;
        }
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại thông tin sản phẩm.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            string productId = txtProductId.Text.Trim();
            if (string.IsNullOrWhiteSpace(productId))
            {
                MessageBox.Show(
                    "Mã sản phẩm không được để trống.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProductId.Focus();

                return;
            }
            foreach (Product product in products)
            {
                if (product.ProductId.Equals(
                    productId,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtProductId.Focus();

                    return;
                }
            }

            decimal unitPrice =
                decimal.Parse(txtUnitPrice.Text);

            int quantity =
                int.Parse(txtQuantity.Text);
            Category category =
                (Category)cboCategory.SelectedItem;
            Product newProduct = new Product
            {
                ProductId = productId,

                ProductName =
                    txtProductName.Text.Trim(),

                CategoryId = category.Id,

                CategoryName = category.Name,

                UnitPrice = unitPrice,

                Quantity = quantity,

                ImagePath =
                    picAvatar.Tag?.ToString() ?? ""
            };

            products.Add(newProduct);

            productBindingSource.ResetBindings(false);

            UpdateStatus();

            MessageBox.Show(
                "Thêm sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            ClearInput();
        }
        private void UpdateStatus()
        {
            lblStatus.Text =
                $"Tổng số sản phẩm: {products.Count}";
        }
        private void ClearInput()
        {
            txtProductId.Clear();

            txtProductName.Clear();

            txtUnitPrice.Clear();

            txtQuantity.Clear();

            if (cboCategory.Items.Count > 0)
            {
                cboCategory.SelectedIndex = 0;
            }

            picAvatar.Image = null;

            picAvatar.Tag = null;

            errorProvider.Clear();

            selectedProduct = null;

            dgvProducts.ClearSelection();

            txtProductId.Focus();
        }

        private void btnClear_Click(
            object? sender,
            EventArgs e)
        {
            ClearInput();
        }

        private void dgvProducts_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem
                is Product product)
            {
                selectedProduct = product;

                txtProductId.Text =
                    product.ProductId;

                txtProductName.Text =
                    product.ProductName;

                txtUnitPrice.Text =
                    product.UnitPrice.ToString("0.##");

                txtQuantity.Text =
                    product.Quantity.ToString();

                cboCategory.SelectedValue =
                    product.CategoryId;

                if (!string.IsNullOrWhiteSpace(
                    product.ImagePath)
                    && File.Exists(product.ImagePath))
                {
                    if (picAvatar.Image != null)
                    {
                        picAvatar.Image.Dispose();
                    }

                    picAvatar.Image =
                        Image.FromFile(product.ImagePath);
                }
                else
                {
                    picAvatar.Image = null;
                }

                picAvatar.Tag =
                    product.ImagePath;
            }
        }
        private void btnUpdate_Click(
            object? sender,
            EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần cập nhật.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidateInput())
            {
                MessageBox.Show(
                    "Vui lòng kiểm tra lại thông tin.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            decimal unitPrice =
                decimal.Parse(txtUnitPrice.Text);

            int quantity =
                int.Parse(txtQuantity.Text);

            Category category =
                (Category)cboCategory.SelectedItem;

            selectedProduct.ProductId =
                txtProductId.Text.Trim();

            selectedProduct.ProductName =
                txtProductName.Text.Trim();

            selectedProduct.CategoryId =
                category.Id;

            selectedProduct.CategoryName =
                category.Name;

            selectedProduct.UnitPrice =
                unitPrice;

            selectedProduct.Quantity =
                quantity;

            selectedProduct.ImagePath =
                picAvatar.Tag?.ToString() ?? "";

            productBindingSource.ResetBindings(false);

            UpdateStatus();

            MessageBox.Show(
                "Cập nhật sản phẩm thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnDelete_Click(
            object? sender,
            EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            DialogResult result =
                MessageBox.Show(
                    $"Bạn có chắc muốn xóa sản phẩm " +
                    $"\"{selectedProduct.ProductName}\" không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                products.Remove(selectedProduct);

                productBindingSource.ResetBindings(false);

                UpdateStatus();

                ClearInput();

                MessageBox.Show(
                    "Xóa sản phẩm thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnChooseImage_Click(
            object? sender,
            EventArgs e)
        {
            using OpenFileDialog openFileDialog =
                new OpenFileDialog();

            openFileDialog.Title = "Chọn ảnh sản phẩm";

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                if (picAvatar.Image != null)
                {
                    picAvatar.Image.Dispose();
                    picAvatar.Image = null;
                }

                using FileStream stream =
                    new FileStream(
                        imagePath,
                        FileMode.Open,
                        FileAccess.Read);

                    picAvatar.Image = Image.FromStream(stream);

                picAvatar.Tag = imagePath;
            }
        }
        private void txtSearch_TextChanged(
            object? sender,
            EventArgs e)
        {
            string keyword =
                txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                productBindingSource.DataSource =
                    products;
            }
            else
            {
                BindingList<Product> searchResults =
                    new BindingList<Product>();

                foreach (Product product in products)
                {
                    if (product.ProductName.Contains(
                        keyword,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        searchResults.Add(product);
                    }
                }

                productBindingSource.DataSource =
                    searchResults;
            }

            productBindingSource.ResetBindings(false);
        }
        private void mnuExportCsv_Click(
            object? sender,
            EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show(
                    "Danh sách sản phẩm đang trống.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            using SaveFileDialog saveFileDialog =
                new SaveFileDialog();

            saveFileDialog.Title =
                "Xuất danh sách sản phẩm";

            saveFileDialog.Filter =
                "CSV Files (*.csv)|*.csv";

            saveFileDialog.FileName =
                "products.csv";

            if (saveFileDialog.ShowDialog()
                != DialogResult.OK)
            {
                return;
            }

            StringBuilder csv =
                new StringBuilder();

            csv.AppendLine(
                "Mã SP,Tên SP,Danh Mục,Đơn Giá,Số Lượng"
            );

            foreach (Product product in products)
            {
                csv.AppendLine(
                    $"{EscapeCsv(product.ProductId)}," +
                    $"{EscapeCsv(product.ProductName)}," +
                    $"{EscapeCsv(product.CategoryName)}," +
                    $"{product.UnitPrice.ToString(CultureInfo.InvariantCulture)}," +
                    $"{product.Quantity}"
                );
            }

            File.WriteAllText(
                saveFileDialog.FileName,
                csv.ToString(),
                Encoding.UTF8
            );

            MessageBox.Show(
                "Xuất file CSV thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private string EscapeCsv(string value)
        {
            if (value.Contains(",")
                || value.Contains("\"")
                || value.Contains("\n"))
            {
                value =
                    value.Replace("\"", "\"\"");

                return $"\"{value}\"";
            }

            return value;
        }

        private void mnuExit_Click(
            object? sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}
