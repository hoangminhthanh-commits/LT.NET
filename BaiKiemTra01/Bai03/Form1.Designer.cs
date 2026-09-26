namespace Bai03
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
            components = new System.ComponentModel.Container();
            tlpMain = new TableLayoutPanel();
            grpProduct = new GroupBox();
            tlpInput = new TableLayoutPanel();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblUnitPrice = new Label();
            txtProductId = new TextBox();
            cboCategory = new ComboBox();
            lblProductId = new Label();
            lblProductName = new Label();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            pnlData = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuExportCsv = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            errorProvider = new ErrorProvider(components);
            tlpMain.SuspendLayout();
            grpProduct.SuspendLayout();
            tlpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlSearch.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpMain.Controls.Add(grpProduct, 0, 0);
            tlpMain.Controls.Add(pnlData, 1, 0);
            tlpMain.Location = new Point(0, 27);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(982, 522);
            tlpMain.TabIndex = 0;
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(tlpInput);
            grpProduct.Dock = DockStyle.Fill;
            grpProduct.Location = new Point(3, 3);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(337, 516);
            grpProduct.TabIndex = 0;
            grpProduct.TabStop = false;
            grpProduct.Text = "Thông tin sản phẩm";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 2;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpInput.Controls.Add(btnUpdate, 1, 7);
            tlpInput.Controls.Add(txtQuantity, 1, 4);
            tlpInput.Controls.Add(txtUnitPrice, 1, 3);
            tlpInput.Controls.Add(txtProductName, 1, 1);
            tlpInput.Controls.Add(lblQuantity, 0, 4);
            tlpInput.Controls.Add(lblCategory, 0, 2);
            tlpInput.Controls.Add(lblUnitPrice, 0, 3);
            tlpInput.Controls.Add(txtProductId, 1, 0);
            tlpInput.Controls.Add(cboCategory, 1, 2);
            tlpInput.Controls.Add(lblProductId, 0, 0);
            tlpInput.Controls.Add(lblProductName, 0, 1);
            tlpInput.Controls.Add(picAvatar, 1, 5);
            tlpInput.Controls.Add(btnChooseImage, 1, 6);
            tlpInput.Controls.Add(btnClear, 1, 8);
            tlpInput.Controls.Add(btnDelete, 0, 8);
            tlpInput.Controls.Add(btnAdd, 0, 7);
            tlpInput.Dock = DockStyle.Fill;
            tlpInput.Location = new Point(3, 23);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 9;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 32.608696F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 8.695652F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 7.60869551F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 7.60869551F));
            tlpInput.Size = new Size(331, 490);
            tlpInput.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(118, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(118, 171);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(210, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Dock = DockStyle.Fill;
            txtUnitPrice.Location = new Point(118, 129);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(210, 27);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(118, 45);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(210, 27);
            txtProductName.TabIndex = 6;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(3, 168);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Số lượng:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(3, 84);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Danh mục:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(3, 126);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(65, 20);
            lblUnitPrice.TabIndex = 3;
            lblUnitPrice.Text = "Đơn giá:";
            // 
            // txtProductId
            // 
            txtProductId.Dock = DockStyle.Fill;
            txtProductId.Location = new Point(118, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(210, 27);
            txtProductId.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.Dock = DockStyle.Fill;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(118, 87);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(210, 28);
            cboCategory.TabIndex = 7;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(3, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(53, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Mã SP:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(3, 42);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(55, 20);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Tên SP:";
            // 
            // picAvatar
            // 
            picAvatar.Dock = DockStyle.Fill;
            picAvatar.Location = new Point(118, 213);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(210, 153);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 10;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(118, 372);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(94, 29);
            btnChooseImage.TabIndex = 11;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(118, 451);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 451);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 414);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            pnlData.Controls.Add(tableLayoutPanel1);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(346, 3);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(633, 516);
            pnlData.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvProducts, 5, 1);
            tableLayoutPanel1.Controls.Add(pnlSearch, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(633, 516);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colCategory, colUnitPrice, colQuantity });
            dgvProducts.Location = new Point(3, 106);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(627, 322);
            dgvProducts.TabIndex = 9;
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
            // colCategory
            // 
            colCategory.DataPropertyName = "CategoryName";
            colCategory.HeaderText = "Danh Mục";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.Width = 125;
            // 
            // colUnitPrice
            // 
            colUnitPrice.DataPropertyName = "UnitPrice";
            colUnitPrice.HeaderText = "Đơn Giá";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Width = 125;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số Lượng";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.Width = 125;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(3, 3);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(627, 97);
            pnlSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(226, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 27);
            txtSearch.TabIndex = 7;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(108, 45);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 20);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 552);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(982, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(145, 20);
            lblStatus.Text = "Tổng số sản phẩm: 0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCsv, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuExportCsv
            // 
            mnuExportCsv.Name = "mnuExportCsv";
            mnuExportCsv.ShortcutKeys = Keys.Control | Keys.E;
            mnuExportCsv.Size = new Size(215, 26);
            mnuExportCsv.Text = "Export CSV";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.ShortcutKeys = Keys.Control | Keys.X;
            mnuExit.Size = new Size(215, 26);
            mnuExit.Text = "Exit";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 578);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tlpMain);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechMart Product Manager";
            Load += Form1_Load;
            tlpMain.ResumeLayout(false);
            grpProduct.ResumeLayout(false);
            tlpInput.ResumeLayout(false);
            tlpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlData.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private GroupBox grpProduct;
        private TableLayoutPanel tlpInput;
        private TextBox txtProductName;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblUnitPrice;
        private TextBox txtProductId;
        private ComboBox cboCategory;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private PictureBox picAvatar;
        private Button btnUpdate;
        private Button btnChooseImage;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private Panel pnlData;
        private TextBox txtSearch;
        private Label lblSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvProducts;
        private Panel pnlSearch;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuExportCsv;
        private ToolStripMenuItem mnuExit;
        private ErrorProvider errorProvider;
    }
}
