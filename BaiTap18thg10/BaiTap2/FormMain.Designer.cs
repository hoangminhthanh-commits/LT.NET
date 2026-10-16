namespace BaiTap2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuOpenCSV = new ToolStripMenuItem();
            mnuSaveCSV = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuAdd = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            mnuSearch = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblTotalBooks = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblCurrentTime = new ToolStripStatusLabel();
            toolStrip = new ToolStrip();
            btnOpenCSV = new ToolStripButton();
            btnSaveCSV = new ToolStripButton();
            btnAddNew = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblBookCover = new Label();
            btnLoadCover = new Button();
            picBookCover = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            numPrice = new NumericUpDown();
            txtCategory = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            lblBookId = new Label();
            lblBookName = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            txtBookId = new TextBox();
            numQuantity = new NumericUpDown();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lblBook = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSearch = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            lblBookList = new Label();
            dgvBooks = new DataGridView();
            colBookId = new DataGridViewTextBoxColumn();
            colBookName = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            ofdCSV = new OpenFileDialog();
            sfdCSV = new SaveFileDialog();
            timer = new System.Windows.Forms.Timer(components);
            ofdCover = new OpenFileDialog();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(995, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenCSV, mnuSaveCSV, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuOpenCSV
            // 
            mnuOpenCSV.Name = "mnuOpenCSV";
            mnuOpenCSV.Size = new Size(171, 26);
            mnuOpenCSV.Text = "Mở file CSV";
            mnuOpenCSV.Click += mnuOpenCSV_Click;
            // 
            // mnuSaveCSV
            // 
            mnuSaveCSV.Name = "mnuSaveCSV";
            mnuSaveCSV.Size = new Size(171, 26);
            mnuSaveCSV.Text = "Lưu file CSV";
            mnuSaveCSV.Click += mnuSaveCSV_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(171, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuEdit
            // 
            mnuEdit.DropDownItems.AddRange(new ToolStripItem[] { mnuAdd, mnuDelete, mnuSearch });
            mnuEdit.Margin = new Padding(15, 0, 0, 0);
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(49, 24);
            mnuEdit.Text = "Edit";
            // 
            // mnuAdd
            // 
            mnuAdd.Name = "mnuAdd";
            mnuAdd.Size = new Size(153, 26);
            mnuAdd.Text = "Thêm";
            mnuAdd.Click += mnuAdd_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Size = new Size(153, 26);
            mnuDelete.Text = "Xóa";
            mnuDelete.Click += mnuDelete_Click;
            // 
            // mnuSearch
            // 
            mnuSearch.Name = "mnuSearch";
            mnuSearch.Size = new Size(153, 26);
            mnuSearch.Text = "Tìm kiếm";
            mnuSearch.Click += mnuSearch_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTotalBooks, lblTotalValue, lblCurrentTime });
            statusStrip.Location = new Point(0, 694);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(995, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(120, 20);
            lblTotalBooks.Text = "Tổng đầu sách: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Margin = new Padding(50, 4, 0, 2);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(129, 20);
            lblTotalValue.Text = "Tổng giá trị kho: 0";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Margin = new Padding(50, 4, 0, 2);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(86, 20);
            lblCurrentTime.Text = "Thời gian: 0";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { btnOpenCSV, btnSaveCSV, btnAddNew });
            toolStrip.Location = new Point(0, 28);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(995, 27);
            toolStrip.TabIndex = 2;
            toolStrip.Text = "toolStrip1";
            // 
            // btnOpenCSV
            // 
            btnOpenCSV.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOpenCSV.Image = (Image)resources.GetObject("btnOpenCSV.Image");
            btnOpenCSV.ImageTransparentColor = Color.Magenta;
            btnOpenCSV.Name = "btnOpenCSV";
            btnOpenCSV.Size = new Size(60, 24);
            btnOpenCSV.Text = "Mở file";
            btnOpenCSV.Click += btnOpenCSV_Click;
            // 
            // btnSaveCSV
            // 
            btnSaveCSV.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSaveCSV.Image = (Image)resources.GetObject("btnSaveCSV.Image");
            btnSaveCSV.ImageTransparentColor = Color.Magenta;
            btnSaveCSV.Margin = new Padding(20, 1, 0, 2);
            btnSaveCSV.Name = "btnSaveCSV";
            btnSaveCSV.Size = new Size(62, 24);
            btnSaveCSV.Text = "Lưu file";
            btnSaveCSV.Click += btnSaveCSV_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAddNew.Image = (Image)resources.GetObject("btnAddNew.Image");
            btnAddNew.ImageTransparentColor = Color.Magenta;
            btnAddNew.Margin = new Padding(20, 1, 0, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(80, 24);
            btnAddNew.Text = "Thêm mới";
            btnAddNew.Click += btnAddNew_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.4514656F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.39599371F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1525421F));
            tableLayoutPanel1.Size = new Size(995, 639);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(989, 271);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(lblBookCover, 0, 0);
            tableLayoutPanel4.Controls.Add(btnLoadCover, 0, 2);
            tableLayoutPanel4.Controls.Add(picBookCover, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(497, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 75.92593F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Size = new Size(489, 265);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // lblBookCover
            // 
            lblBookCover.AutoSize = true;
            lblBookCover.Dock = DockStyle.Fill;
            lblBookCover.Location = new Point(3, 0);
            lblBookCover.Name = "lblBookCover";
            lblBookCover.Size = new Size(483, 20);
            lblBookCover.TabIndex = 3;
            lblBookCover.Text = "ẢNH BÌA SÁCH";
            lblBookCover.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoadCover
            // 
            btnLoadCover.Dock = DockStyle.Fill;
            btnLoadCover.Location = new Point(100, 225);
            btnLoadCover.Margin = new Padding(100, 5, 100, 5);
            btnLoadCover.Name = "btnLoadCover";
            btnLoadCover.Size = new Size(289, 35);
            btnLoadCover.TabIndex = 4;
            btnLoadCover.Text = "Chọn ảnh";
            btnLoadCover.UseVisualStyleBackColor = true;
            btnLoadCover.Click += btnLoadCover_Click;
            // 
            // picBookCover
            // 
            picBookCover.Dock = DockStyle.Fill;
            picBookCover.Location = new Point(3, 23);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(483, 194);
            picBookCover.TabIndex = 5;
            picBookCover.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(lblBook, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75.81967F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.803278F));
            tableLayoutPanel3.Size = new Size(488, 265);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6722F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.3278046F));
            tableLayoutPanel5.Controls.Add(numPrice, 1, 5);
            tableLayoutPanel5.Controls.Add(txtCategory, 1, 3);
            tableLayoutPanel5.Controls.Add(txtAuthor, 1, 2);
            tableLayoutPanel5.Controls.Add(txtBookName, 1, 1);
            tableLayoutPanel5.Controls.Add(lblBookId, 0, 0);
            tableLayoutPanel5.Controls.Add(lblBookName, 0, 1);
            tableLayoutPanel5.Controls.Add(lblAuthor, 0, 2);
            tableLayoutPanel5.Controls.Add(lblCategory, 0, 3);
            tableLayoutPanel5.Controls.Add(lblQuantity, 0, 4);
            tableLayoutPanel5.Controls.Add(lblPrice, 0, 5);
            tableLayoutPanel5.Controls.Add(txtBookId, 1, 0);
            tableLayoutPanel5.Controls.Add(numQuantity, 1, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 23);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel5.Size = new Size(482, 194);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            numPrice.Location = new Point(110, 163);
            numPrice.Margin = new Padding(20, 3, 3, 3);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(150, 27);
            numPrice.TabIndex = 14;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCategory.Location = new Point(110, 99);
            txtCategory.Margin = new Padding(20, 3, 3, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 12;
            // 
            // txtAuthor
            // 
            txtAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAuthor.Location = new Point(110, 67);
            txtAuthor.Margin = new Padding(20, 3, 3, 3);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 11;
            // 
            // txtBookName
            // 
            txtBookName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBookName.Location = new Point(110, 35);
            txtBookName.Margin = new Padding(20, 3, 3, 3);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(125, 27);
            txtBookName.TabIndex = 10;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Dock = DockStyle.Fill;
            lblBookId.Location = new Point(3, 0);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(84, 32);
            lblBookId.TabIndex = 3;
            lblBookId.Text = "Mã sách:";
            lblBookId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Dock = DockStyle.Fill;
            lblBookName.Location = new Point(3, 32);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(84, 32);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Tên sách:";
            lblBookName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Dock = DockStyle.Fill;
            lblAuthor.Location = new Point(3, 64);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(84, 32);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Tác giả:";
            lblAuthor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 96);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 32);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Thể loại:";
            lblCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(3, 128);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 32);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Số lượng:";
            lblQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 160);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(84, 34);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Đơn giá:";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBookId
            // 
            txtBookId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBookId.Location = new Point(110, 3);
            txtBookId.Margin = new Padding(20, 3, 3, 3);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(125, 27);
            txtBookId.TabIndex = 9;
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            numQuantity.Location = new Point(110, 131);
            numQuantity.Margin = new Padding(20, 3, 3, 3);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 13;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.Controls.Add(btnClear, 3, 0);
            tableLayoutPanel6.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel6.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel6.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 223);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(482, 39);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(380, 5);
            btnClear.Margin = new Padding(20, 5, 20, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(260, 5);
            btnDelete.Margin = new Padding(20, 5, 20, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(140, 5);
            btnEdit.Margin = new Padding(20, 5, 20, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(80, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(20, 5);
            btnAdd.Margin = new Padding(20, 5, 20, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(3, 0);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(129, 20);
            lblBook.TabIndex = 2;
            lblBook.Text = "THÔNG TIN SÁCH";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel7.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanel7.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanel7.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 280);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(989, 41);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(153, 5);
            txtSearch.Margin = new Padding(5);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(682, 31);
            txtSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Padding = new Padding(0, 0, 10, 0);
            lblSearch.Size = new Size(142, 41);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Tìm kiếm:";
            lblSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(865, 5);
            btnSearch.Margin = new Padding(25, 5, 25, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(lblBookList, 0, 0);
            tableLayoutPanel8.Controls.Add(dgvBooks, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 327);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 9.265176F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 90.7348251F));
            tableLayoutPanel8.Size = new Size(989, 309);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Location = new Point(3, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(136, 20);
            lblBookList.TabIndex = 3;
            lblBookList.Text = "DANH SÁCH SÁCH";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colBookId, colBookName, colAuthor, colCategory, colQuantity, colPrice });
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(3, 31);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(983, 275);
            dgvBooks.TabIndex = 4;
            // 
            // colBookId
            // 
            colBookId.DataPropertyName = "BookId";
            colBookId.HeaderText = "Mã sách";
            colBookId.MinimumWidth = 6;
            colBookId.Name = "colBookId";
            colBookId.ReadOnly = true;
            // 
            // colBookName
            // 
            colBookName.DataPropertyName = "BookName";
            colBookName.HeaderText = "Tên sách";
            colBookName.MinimumWidth = 6;
            colBookName.Name = "colBookName";
            colBookName.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.DataPropertyName = "Author";
            colAuthor.HeaderText = "Tác giả";
            colAuthor.MinimumWidth = 6;
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Thể loại";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Số lượng";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Đơn giá";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // ofdCSV
            // 
            ofdCSV.FileName = "openFileDialog1";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // ofdCover
            // 
            ofdCover.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 720);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            Text = "Quản lý tài liệu sách";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private StatusStrip statusStrip;
        private ToolStrip toolStrip;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblBookCover;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtCategory;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private Label lblBookId;
        private Label lblBookName;
        private Label lblAuthor;
        private Label lblCategory;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox txtBookId;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblBook;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblSearch;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lblBookList;
        private Button btnLoadCover;
        private PictureBox picBookCover;
        private NumericUpDown numPrice;
        private NumericUpDown numQuantity;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private OpenFileDialog ofdCSV;
        private SaveFileDialog sfdCSV;
        private System.Windows.Forms.Timer timer;
        private ToolStripStatusLabel lblTotalBooks;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblCurrentTime;
        private OpenFileDialog ofdCover;
        private DataGridView dgvBooks;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuOpenCSV;
        private ToolStripMenuItem mnuSaveCSV;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuAdd;
        private ToolStripMenuItem mnuDelete;
        private ToolStripMenuItem mnuSearch;
        private ToolStripButton btnOpenCSV;
        private ToolStripButton btnSaveCSV;
        private ToolStripButton btnAddNew;
        private DataGridViewTextBoxColumn colBookId;
        private DataGridViewTextBoxColumn colBookName;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
    }
}
