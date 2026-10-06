namespace Bai4._6
{
    partial class FormStudent
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
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            btnChooseAvatar = new Button();
            lblFullName = new Label();
            lblAge = new Label();
            lblGender = new Label();
            txtFullName = new TextBox();
            txtAge = new TextBox();
            cboGender = new ComboBox();
            picAvatar = new PictureBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnExport = new Button();
            dgvStudents = new DataGridView();
            colStudentId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colAvatarPath = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(123, 97);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(94, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã sinh viên:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(223, 90);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 1;
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(292, 324);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(94, 29);
            btnChooseAvatar.TabIndex = 2;
            btnChooseAvatar.Text = "Chọn ảnh";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(123, 131);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(57, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Họ tên:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(123, 167);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(123, 199);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 5;
            lblGender.Text = "Giới tính:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(223, 124);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(223, 160);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 7;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(223, 199);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 8;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(123, 263);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(151, 116);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 9;
            picAvatar.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(154, 416);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 416);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(270, 416);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(396, 416);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 13;
            btnExport.Text = "Xuất CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colStudentId, colFullName, colAge, colGender, colAvatarPath });
            dgvStudents.Location = new Point(27, 494);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(711, 188);
            dgvStudents.TabIndex = 14;
            // 
            // colStudentId
            // 
            colStudentId.DataPropertyName = "StudentId";
            colStudentId.HeaderText = "Mã SV";
            colStudentId.MinimumWidth = 6;
            colStudentId.Name = "colStudentId";
            colStudentId.Width = 125;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ tên";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.Width = 125;
            // 
            // colAge
            // 
            colAge.DataPropertyName = "Age";
            colAge.HeaderText = "Tuổi";
            colAge.MinimumWidth = 6;
            colAge.Name = "colAge";
            colAge.Width = 125;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Giới tính";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.Width = 125;
            // 
            // colAvatarPath
            // 
            colAvatarPath.DataPropertyName = "AvatarPath";
            colAvatarPath.HeaderText = "Đường dẫn Avatar";
            colAvatarPath.MinimumWidth = 6;
            colAvatarPath.Name = "colAvatarPath";
            colAvatarPath.Width = 160;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 718);
            Controls.Add(dgvStudents);
            Controls.Add(btnExport);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(picAvatar);
            Controls.Add(cboGender);
            Controls.Add(txtAge);
            Controls.Add(txtFullName);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblFullName);
            Controls.Add(btnChooseAvatar);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Name = "FormStudent";
            Text = "FormStudent";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private TextBox txtStudentId;
        private Button btnChooseAvatar;
        private Label lblFullName;
        private Label lblAge;
        private Label lblGender;
        private TextBox txtFullName;
        private TextBox txtAge;
        private ComboBox cboGender;
        private PictureBox picAvatar;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnExport;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colStudentId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colAvatarPath;
    }
}
