namespace BaiTap1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvMembers = new DataGridView();
            colMemberId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colPackage = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colFee = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            lblMemberId = new Label();
            lblPhone = new Label();
            lblFullName = new Label();
            lblPackage = new Label();
            lblStartDate = new Label();
            lblFee = new Label();
            txtMemberId = new TextBox();
            txtFee = new TextBox();
            cboPackage = new ComboBox();
            dtpStartDate = new DateTimePicker();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            lblTitle = new Label();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvMembers, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.645161F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.6720428F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 68.68279F));
            tableLayoutPanel1.Size = new Size(823, 744);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvMembers
            // 
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colMemberId, colFullName, colPhone, colPackage, colStartDate, colFee });
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.Location = new Point(3, 236);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(817, 505);
            dgvMembers.TabIndex = 3;
            // 
            // colMemberId
            // 
            colMemberId.DataPropertyName = "MemberId";
            colMemberId.HeaderText = "Mã hội viên";
            colMemberId.MinimumWidth = 6;
            colMemberId.Name = "colMemberId";
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Tên hội viên";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Số điện thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            // 
            // colPackage
            // 
            colPackage.DataPropertyName = "Package";
            colPackage.HeaderText = "Gói tập";
            colPackage.MinimumWidth = 6;
            colPackage.Name = "colPackage";
            // 
            // colStartDate
            // 
            colStartDate.DataPropertyName = "StartDate";
            colStartDate.HeaderText = "Ngày đăng ký";
            colStartDate.MinimumWidth = 6;
            colStartDate.Name = "colStartDate";
            // 
            // colFee
            // 
            colFee.DataPropertyName = "Fee";
            colFee.HeaderText = "Phí dịch vụ";
            colFee.MinimumWidth = 6;
            colFee.Name = "colFee";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 45);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.558136F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.44186F));
            tableLayoutPanel2.Size = new Size(817, 185);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.Controls.Add(txtPhone, 1, 1);
            tableLayoutPanel3.Controls.Add(txtFullName, 3, 0);
            tableLayoutPanel3.Controls.Add(lblMemberId, 0, 0);
            tableLayoutPanel3.Controls.Add(lblPhone, 0, 1);
            tableLayoutPanel3.Controls.Add(lblFullName, 2, 0);
            tableLayoutPanel3.Controls.Add(lblPackage, 2, 1);
            tableLayoutPanel3.Controls.Add(lblStartDate, 0, 2);
            tableLayoutPanel3.Controls.Add(lblFee, 2, 2);
            tableLayoutPanel3.Controls.Add(txtMemberId, 1, 0);
            tableLayoutPanel3.Controls.Add(txtFee, 3, 2);
            tableLayoutPanel3.Controls.Add(cboPackage, 3, 1);
            tableLayoutPanel3.Controls.Add(dtpStartDate, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(811, 128);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(124, 45);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(528, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 9;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(3, 0);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(89, 20);
            lblMemberId.TabIndex = 2;
            lblMemberId.Text = "Mã hội viên:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 42);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(407, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Họ và tên:";
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Location = new Point(407, 42);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(61, 20);
            lblPackage.TabIndex = 5;
            lblPackage.Text = "Gói tập:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(3, 84);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(103, 20);
            lblStartDate.TabIndex = 6;
            lblStartDate.Text = "Ngày đăng ký:";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.Location = new Point(407, 84);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(83, 20);
            lblFee.TabIndex = 7;
            lblFee.Text = "Phí dịch vụ:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(124, 3);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(125, 27);
            txtMemberId.TabIndex = 8;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(528, 87);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(125, 27);
            txtFee.TabIndex = 11;
            // 
            // cboPackage
            // 
            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPackage.FormattingEnabled = true;
            cboPackage.Location = new Point(528, 45);
            cboPackage.Name = "cboPackage";
            cboPackage.Size = new Size(151, 28);
            cboPackage.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(124, 87);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 13;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnRefresh, 3, 0);
            tableLayoutPanel4.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel4.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 137);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(811, 45);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Location = new Point(656, 7);
            btnRefresh.Margin = new Padding(50, 7, 50, 7);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += this.btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(454, 7);
            btnDelete.Margin = new Padding(50, 7, 50, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa hội viên";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += this.btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(252, 7);
            btnEdit.Margin = new Padding(50, 7, 50, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 31);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa thông tin";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += this.btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(50, 7);
            btnAdd.Margin = new Padding(50, 7, 50, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(817, 42);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "QUẢN LÝ HỘI VIÊN PHÒNG GYM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 744);
            Controls.Add(tableLayoutPanel1);
            Name = "FormMain";
            Text = "Quản lý hội viên phòng gym";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblMemberId;
        private Label lblPhone;
        private Label lblFullName;
        private Label lblPackage;
        private Label lblStartDate;
        private Label lblFee;
        private Label lblTitle;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private TextBox txtMemberId;
        private TextBox txtFee;
        private ComboBox cboPackage;
        private DateTimePicker dtpStartDate;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvMembers;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn colMemberId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colPackage;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colFee;
    }
}
