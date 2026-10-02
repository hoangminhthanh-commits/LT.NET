namespace Bai5._3
{
    partial class Form1
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
            lblHeader = new Label();
            grpProductInfo = new GroupBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblUnitPrice = new Label();
            lblProductName = new Label();
            txtProductId = new TextBox();
            lblProductId = new Label();
            grpFunctions = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            grpProductInfo.SuspendLayout();
            grpFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(350, 29);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(148, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // grpProductInfo
            // 
            grpProductInfo.Controls.Add(txtCategory);
            grpProductInfo.Controls.Add(txtQuantity);
            grpProductInfo.Controls.Add(txtUnitPrice);
            grpProductInfo.Controls.Add(txtProductName);
            grpProductInfo.Controls.Add(lblCategory);
            grpProductInfo.Controls.Add(lblQuantity);
            grpProductInfo.Controls.Add(lblUnitPrice);
            grpProductInfo.Controls.Add(lblProductName);
            grpProductInfo.Controls.Add(txtProductId);
            grpProductInfo.Controls.Add(lblProductId);
            grpProductInfo.Location = new Point(86, 79);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(412, 255);
            grpProductInfo.TabIndex = 1;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Thông tin sản phẩm";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(181, 202);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(199, 27);
            txtCategory.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(181, 160);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(199, 27);
            txtQuantity.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(181, 122);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(199, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(181, 81);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(199, 27);
            txtProductName.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(24, 205);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Danh mục:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(24, 163);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Số lượng:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(24, 125);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(65, 20);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "Đơn giá:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(24, 84);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(55, 20);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Tên SP:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(181, 39);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(199, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(24, 42);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(53, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            // 
            // grpFunctions
            // 
            grpFunctions.Controls.Add(txtSearch);
            grpFunctions.Controls.Add(btnSearch);
            grpFunctions.Controls.Add(btnDelete);
            grpFunctions.Controls.Add(btnEdit);
            grpFunctions.Controls.Add(btnAdd);
            grpFunctions.Location = new Point(86, 353);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(688, 69);
            grpFunctions.TabIndex = 2;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Chức năng";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(501, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(392, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(264, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(132, 26);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colUnitPrice, colQuantity, colCategory });
            dgvProducts.Location = new Point(86, 458);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(675, 240);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "ProductId";
            colProductId.HeaderText = "Mã SP";
            colProductId.MinimumWidth = 6;
            colProductId.Name = "colProductId";
            colProductId.Width = 125;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "ProductName";
            colProductName.HeaderText = "Tên SP";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.Width = 125;
            // 
            // colUnitPrice
            // 
            colUnitPrice.DataPropertyName = "UnitPrice";
            colUnitPrice.HeaderText = "Đơn giá";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 125;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Danh mục";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 710);
            Controls.Add(dgvProducts);
            Controls.Add(grpFunctions);
            Controls.Add(grpProductInfo);
            Controls.Add(lblHeader);
            Name = "Form1";
            Text = "Form1";
            grpProductInfo.ResumeLayout(false);
            grpProductInfo.PerformLayout();
            grpFunctions.ResumeLayout(false);
            grpFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grpProductInfo;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblUnitPrice;
        private Label lblProductName;
        private TextBox txtProductId;
        private Label lblProductId;
        private GroupBox grpFunctions;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colCategory;
    }
}
