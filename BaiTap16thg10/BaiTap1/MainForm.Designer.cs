namespace BaiTap1
{
    partial class MainForm
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mnuExportCsv = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblStatus2 = new Label();
            dtpFilterDate = new DateTimePicker();
            chkFilterDate = new CheckBox();
            cboFilterStatus = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPhone = new TextBox();
            txtPatientName = new TextBox();
            lblAppointmentId = new Label();
            lblPhone = new Label();
            lblDoctor = new Label();
            lblPatientName = new Label();
            lblAppointmentDate = new Label();
            lblStatus1 = new Label();
            txtAppointmentId = new TextBox();
            cboDoctor = new ComboBox();
            cboStatus = new ComboBox();
            dtpAppointmentDate = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblReason = new Label();
            txtReason = new TextBox();
            tableLayoutMain = new TableLayoutPanel();
            dgvAppointments = new DataGridView();
            colAppointmentId = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAppointmentDate = new DataGridViewTextBoxColumn();
            colDoctor = new DataGridViewTextBoxColumn();
            colReason = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            bindingSourceAppointments = new BindingSource(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAppointments).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1182, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCsv, mnuExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // mnuExportCsv
            // 
            mnuExportCsv.Name = "mnuExportCsv";
            mnuExportCsv.Size = new Size(222, 26);
            mnuExportCsv.Text = "Xuất danh sách CSV";
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(222, 26);
            mnuExit.Text = "Thoát";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblCount });
            statusStrip.Location = new Point(0, 677);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1182, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(96, 20);
            lblCount.Text = "Số lịch hẹn: 0";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 216);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1176, 97);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.Controls.Add(lblStatus2, 2, 0);
            tableLayoutPanel7.Controls.Add(dtpFilterDate, 1, 0);
            tableLayoutPanel7.Controls.Add(chkFilterDate, 0, 0);
            tableLayoutPanel7.Controls.Add(cboFilterStatus, 3, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 51);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1170, 43);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // lblStatus2
            // 
            lblStatus2.AutoSize = true;
            lblStatus2.Location = new Point(587, 0);
            lblStatus2.Name = "lblStatus2";
            lblStatus2.Size = new Size(78, 20);
            lblStatus2.TabIndex = 13;
            lblStatus2.Text = "Trạng thái:";
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(295, 3);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(250, 27);
            dtpFilterDate.TabIndex = 12;
            // 
            // chkFilterDate
            // 
            chkFilterDate.AutoSize = true;
            chkFilterDate.Location = new Point(3, 3);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(93, 24);
            chkFilterDate.TabIndex = 0;
            chkFilterDate.Text = "Lọc ngày:";
            chkFilterDate.UseVisualStyleBackColor = true;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(879, 3);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(151, 28);
            cboFilterStatus.TabIndex = 14;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel6.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanel6.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1170, 42);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(295, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 20);
            lblSearch.TabIndex = 7;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btnDelete, 3, 0);
            tableLayoutPanel4.Controls.Add(btnEdit, 2, 0);
            tableLayoutPanel4.Controls.Add(btnUpdate, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 165);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1176, 45);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(885, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(591, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(297, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1176, 156);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(txtPhone, 1, 1);
            tableLayoutPanel2.Controls.Add(txtPatientName, 3, 0);
            tableLayoutPanel2.Controls.Add(lblAppointmentId, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPhone, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDoctor, 0, 2);
            tableLayoutPanel2.Controls.Add(lblPatientName, 2, 0);
            tableLayoutPanel2.Controls.Add(lblAppointmentDate, 2, 1);
            tableLayoutPanel2.Controls.Add(lblStatus1, 2, 2);
            tableLayoutPanel2.Controls.Add(txtAppointmentId, 1, 0);
            tableLayoutPanel2.Controls.Add(cboDoctor, 1, 2);
            tableLayoutPanel2.Controls.Add(cboStatus, 3, 2);
            tableLayoutPanel2.Controls.Add(dtpAppointmentDate, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel2.Size = new Size(1170, 118);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(178, 42);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(762, 3);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(125, 27);
            txtPatientName.TabIndex = 7;
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.AutoSize = true;
            lblAppointmentId.Location = new Point(3, 0);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(88, 20);
            lblAppointmentId.TabIndex = 0;
            lblAppointmentId.Text = "Mã lịch hẹn:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 39);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 20);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Số điện thoại:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(3, 78);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(50, 20);
            lblDoctor.TabIndex = 2;
            lblDoctor.Text = "Bác sĩ:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(587, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(57, 20);
            lblPatientName.TabIndex = 3;
            lblPatientName.Text = "Họ tên:";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new Point(587, 39);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(73, 20);
            lblAppointmentDate.TabIndex = 4;
            lblAppointmentDate.Text = "Ngày giờ:";
            // 
            // lblStatus1
            // 
            lblStatus1.AutoSize = true;
            lblStatus1.Location = new Point(587, 78);
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(78, 20);
            lblStatus1.TabIndex = 5;
            lblStatus1.Text = "Trạng thái:";
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.Location = new Point(178, 3);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.Size = new Size(125, 27);
            txtAppointmentId.TabIndex = 6;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(178, 81);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(151, 28);
            cboDoctor.TabIndex = 9;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(762, 81);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 10;
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Format = DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new Point(762, 42);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 27);
            dtpAppointmentDate.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.Controls.Add(lblReason, 0, 0);
            tableLayoutPanel3.Controls.Add(txtReason, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 127);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1170, 26);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new Point(3, 0);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(87, 20);
            lblReason.TabIndex = 6;
            lblReason.Text = "Lý do khám:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(178, 3);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(125, 20);
            txtReason.TabIndex = 9;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 1;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(dgvAppointments, 0, 3);
            tableLayoutMain.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 28);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 4;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 51F));
            tableLayoutMain.Size = new Size(1182, 649);
            tableLayoutMain.TabIndex = 4;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { colAppointmentId, colPatientName, colPhone, colAppointmentDate, colDoctor, colReason, colStatus });
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(3, 319);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1176, 327);
            dgvAppointments.TabIndex = 5;
            // 
            // colAppointmentId
            // 
            colAppointmentId.DataPropertyName = "AppointmentId";
            colAppointmentId.HeaderText = "Mã lịch hẹn";
            colAppointmentId.MinimumWidth = 6;
            colAppointmentId.Name = "colAppointmentId";
            colAppointmentId.ReadOnly = true;
            // 
            // colPatientName
            // 
            colPatientName.DataPropertyName = "PatientName";
            colPatientName.HeaderText = "Họ tên bệnh nhân";
            colPatientName.MinimumWidth = 6;
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Số điện thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colAppointmentDate
            // 
            colAppointmentDate.DataPropertyName = "AppointmentDate";
            colAppointmentDate.HeaderText = "Ngày giờ hẹn";
            colAppointmentDate.MinimumWidth = 6;
            colAppointmentDate.Name = "colAppointmentDate";
            colAppointmentDate.ReadOnly = true;
            // 
            // colDoctor
            // 
            colDoctor.DataPropertyName = "Doctor";
            colDoctor.HeaderText = "Bác sĩ";
            colDoctor.MinimumWidth = 6;
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            // 
            // colReason
            // 
            colReason.DataPropertyName = "Reason";
            colReason.HeaderText = "Lý do khám";
            colReason.MinimumWidth = 6;
            colReason.Name = "colReason";
            colReason.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(tableLayoutMain);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1000, 650);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mnuExportCsv;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblCount;
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutMain;
        private DataGridView dgvAppointments;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPhone;
        private TextBox txtPatientName;
        private Label lblAppointmentId;
        private Label lblPhone;
        private Label lblDoctor;
        private Label lblPatientName;
        private Label lblAppointmentDate;
        private Label lblStatus1;
        private TextBox txtAppointmentId;
        private ComboBox cboDoctor;
        private ComboBox cboStatus;
        private DateTimePicker dtpAppointmentDate;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblReason;
        private TextBox txtReason;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnUpdate;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblStatus2;
        private DateTimePicker dtpFilterDate;
        private CheckBox chkFilterDate;
        private ComboBox cboFilterStatus;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtSearch;
        private Label lblSearch;
        private BindingSource bindingSourceAppointments;
        private ToolStripMenuItem mnuExit;
        private DataGridViewTextBoxColumn colAppointmentId;
        private DataGridViewTextBoxColumn colPatientName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAppointmentDate;
        private DataGridViewTextBoxColumn colDoctor;
        private DataGridViewTextBoxColumn colReason;
        private DataGridViewTextBoxColumn colStatus;
    }
}
