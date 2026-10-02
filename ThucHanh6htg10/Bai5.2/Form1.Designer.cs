namespace Bai5._2
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
            cboCategory = new ComboBox();
            lblLoaiDichVu = new Label();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            lblSubtotal = new Label();
            lblDiscount = new Label();
            lblTotal = new Label();
            lblS = new Label();
            lblService = new Label();
            lblServiceSelected = new Label();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(261, 79);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(214, 28);
            cboCategory.TabIndex = 0;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblLoaiDichVu
            // 
            lblLoaiDichVu.AutoSize = true;
            lblLoaiDichVu.Location = new Point(151, 82);
            lblLoaiDichVu.Name = "lblLoaiDichVu";
            lblLoaiDichVu.Size = new Size(91, 20);
            lblLoaiDichVu.TabIndex = 1;
            lblLoaiDichVu.Text = "Loại dịch vụ:";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(151, 163);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(189, 204);
            lstAvailableServices.TabIndex = 2;
            lstAvailableServices.DoubleClick += lstAvailableServices_DoubleClick;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(444, 163);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(191, 204);
            lstSelectedServices.TabIndex = 3;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(368, 216);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(47, 29);
            btnSelect.TabIndex = 4;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(368, 251);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(47, 29);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(367, 286);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(48, 29);
            btnClearAll.TabIndex = 6;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(151, 376);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(149, 20);
            lblSubtotal.TabIndex = 7;
            lblSubtotal.Text = "Tổng tiền chưa giảm:\n";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(151, 414);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(114, 20);
            lblDiscount.TabIndex = 8;
            lblDiscount.Text = "Tỷ lệ chiết khấu:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(151, 450);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(156, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Thành tiền thanh toán:";
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Location = new Point(266, 19);
            lblS.Name = "lblS";
            lblS.Size = new Size(184, 20);
            lblS.TabIndex = 10;
            lblS.Text = "BẢNG TÍNH TIỀN DỊCH VỤ";
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(151, 140);
            lblService.Name = "lblService";
            lblService.Size = new Size(61, 20);
            lblService.TabIndex = 11;
            lblService.Text = "Dịch vụ:";
            // 
            // lblServiceSelected
            // 
            lblServiceSelected.AutoSize = true;
            lblServiceSelected.Location = new Point(444, 140);
            lblServiceSelected.Name = "lblServiceSelected";
            lblServiceSelected.Size = new Size(118, 20);
            lblServiceSelected.TabIndex = 12;
            lblServiceSelected.Text = "Dịch vụ đã chọn:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(lblServiceSelected);
            Controls.Add(lblService);
            Controls.Add(lblS);
            Controls.Add(lblTotal);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubtotal);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(lblLoaiDichVu);
            Controls.Add(cboCategory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategory;
        private Label lblLoaiDichVu;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private Label lblSubtotal;
        private Label lblDiscount;
        private Label lblTotal;
        private Label lblS;
        private Label lblService;
        private Label lblServiceSelected;
    }
}
