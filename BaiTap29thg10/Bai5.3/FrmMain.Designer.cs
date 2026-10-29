namespace Bai5._3
{
    partial class FrmMain
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
            pnlMain = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblQuanLyQuanCafe = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblHoaDon = new Label();
            dgvHoaDon = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnXoaMon = new Button();
            btnSuaMon = new Button();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnThemMon = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            cboMon = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            flpBan = new FlowLayoutPanel();
            lblBan = new Label();
            pnlMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(tableLayoutPanel1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(861, 687);
            pnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblQuanLyQuanCafe, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93F));
            tableLayoutPanel1.Size = new Size(861, 687);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblQuanLyQuanCafe
            // 
            lblQuanLyQuanCafe.AutoSize = true;
            lblQuanLyQuanCafe.Dock = DockStyle.Fill;
            lblQuanLyQuanCafe.Font = new Font("Segoe UI", 12F);
            lblQuanLyQuanCafe.Location = new Point(3, 0);
            lblQuanLyQuanCafe.Name = "lblQuanLyQuanCafe";
            lblQuanLyQuanCafe.Size = new Size(855, 48);
            lblQuanLyQuanCafe.TabIndex = 4;
            lblQuanLyQuanCafe.Text = "QUẢN LÝ QUÁN CAFE";
            lblQuanLyQuanCafe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(855, 633);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lblHoaDon, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvHoaDon, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(345, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.Size = new Size(507, 627);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblHoaDon
            // 
            lblHoaDon.AutoSize = true;
            lblHoaDon.Dock = DockStyle.Fill;
            lblHoaDon.Font = new Font("Segoe UI", 12F);
            lblHoaDon.Location = new Point(3, 0);
            lblHoaDon.Name = "lblHoaDon";
            lblHoaDon.Size = new Size(501, 43);
            lblHoaDon.TabIndex = 0;
            lblHoaDon.Text = "HÓA ĐƠN";
            lblHoaDon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(3, 46);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(501, 439);
            dgvHoaDon.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 491);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(501, 88);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8947372F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.7368431F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel6.Controls.Add(btnXoaMon, 4, 0);
            tableLayoutPanel6.Controls.Add(btnSuaMon, 3, 0);
            tableLayoutPanel6.Controls.Add(lblSoLuong, 0, 0);
            tableLayoutPanel6.Controls.Add(txtSoLuong, 1, 0);
            tableLayoutPanel6.Controls.Add(btnThemMon, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 47);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(495, 38);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnXoaMon
            // 
            btnXoaMon.Dock = DockStyle.Fill;
            btnXoaMon.Location = new Point(418, 3);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(74, 32);
            btnXoaMon.TabIndex = 5;
            btnXoaMon.Text = "Xóa";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnSuaMon
            // 
            btnSuaMon.Dock = DockStyle.Fill;
            btnSuaMon.Location = new Point(340, 3);
            btnSuaMon.Name = "btnSuaMon";
            btnSuaMon.Size = new Size(72, 32);
            btnSuaMon.TabIndex = 4;
            btnSuaMon.Text = "Sửa";
            btnSuaMon.UseVisualStyleBackColor = true;
            btnSuaMon.Click += btnSuaMon_Click;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Dock = DockStyle.Fill;
            lblSoLuong.Location = new Point(3, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(82, 38);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "Số lượng:";
            lblSoLuong.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Location = new Point(91, 3);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(165, 27);
            txtSoLuong.TabIndex = 2;
            // 
            // btnThemMon
            // 
            btnThemMon.Dock = DockStyle.Fill;
            btnThemMon.Location = new Point(262, 3);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(72, 32);
            btnThemMon.TabIndex = 3;
            btnThemMon.Text = "Thêm";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(cboMon, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(495, 38);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 38);
            label2.TabIndex = 1;
            label2.Text = "Món:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboMon
            // 
            cboMon.Dock = DockStyle.Fill;
            cboMon.FormattingEnabled = true;
            cboMon.Location = new Point(87, 3);
            cboMon.Name = "cboMon";
            cboMon.Size = new Size(405, 28);
            cboMon.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(lblTongTien, 0, 0);
            tableLayoutPanel7.Controls.Add(btnThanhToan, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 585);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(501, 39);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(3, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(87, 20);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền: 0";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(253, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(flpBan, 0, 1);
            tableLayoutPanel8.Controls.Add(lblBan, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 93F));
            tableLayoutPanel8.Size = new Size(336, 627);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.Dock = DockStyle.Fill;
            flpBan.Location = new Point(3, 46);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(330, 578);
            flpBan.TabIndex = 2;
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Dock = DockStyle.Fill;
            lblBan.Font = new Font("Segoe UI", 12F);
            lblBan.Location = new Point(3, 0);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(330, 43);
            lblBan.TabIndex = 3;
            lblBan.Text = "SƠ ĐỒ BÀN";
            lblBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 687);
            Controls.Add(pnlMain);
            Name = "FrmMain";
            Text = "FrmMain";
            pnlMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblHoaDon;
        private DataGridView dgvHoaDon;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Button btnThemMon;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private ComboBox cboMon;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblTongTien;
        private Button btnThanhToan;
        private TableLayoutPanel tableLayoutPanel8;
        private FlowLayoutPanel flpBan;
        private Label lblBan;
        private Label lblQuanLyQuanCafe;
        private Button btnXoaMon;
        private Button btnSuaMon;
    }
}
