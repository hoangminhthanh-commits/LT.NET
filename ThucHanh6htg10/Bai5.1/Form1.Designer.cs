namespace Bai5._1;

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
        lblUsername = new Label();
        lblPassword = new Label();
        lblConfirmPassword = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        txtConfirmPassword = new TextBox();
        lblBirthDate = new Label();
        lblGioiTinh = new Label();
        dtpBirthDate = new DateTimePicker();
        rbMale = new RadioButton();
        rbFemale = new RadioButton();
        chkTerms = new CheckBox();
        btnRegister = new Button();
        btnReset = new Button();
        epCheck = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
        SuspendLayout();
        // 
        // lblUsername
        // 
        lblUsername.AutoSize = true;
        lblUsername.Location = new Point(84, 89);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(110, 20);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Tên đăng nhập:";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(84, 128);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(73, 20);
        lblPassword.TabIndex = 1;
        lblPassword.Text = "Mật khẩu:";
        // 
        // lblConfirmPassword
        // 
        lblConfirmPassword.AutoSize = true;
        lblConfirmPassword.Location = new Point(84, 175);
        lblConfirmPassword.Name = "lblConfirmPassword";
        lblConfirmPassword.Size = new Size(137, 20);
        lblConfirmPassword.TabIndex = 2;
        lblConfirmPassword.Text = "Xác nhận mật khẩu:";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(268, 82);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(227, 27);
        txtUsername.TabIndex = 3;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(268, 128);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(227, 27);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.Location = new Point(268, 172);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.Size = new Size(227, 27);
        txtConfirmPassword.TabIndex = 5;
        txtConfirmPassword.UseSystemPasswordChar = true;
        // 
        // lblBirthDate
        // 
        lblBirthDate.AutoSize = true;
        lblBirthDate.Location = new Point(84, 225);
        lblBirthDate.Name = "lblBirthDate";
        lblBirthDate.Size = new Size(77, 20);
        lblBirthDate.TabIndex = 6;
        lblBirthDate.Text = "Ngày sinh:";
        // 
        // lblGioiTinh
        // 
        lblGioiTinh.AutoSize = true;
        lblGioiTinh.Location = new Point(84, 270);
        lblGioiTinh.Name = "lblGioiTinh";
        lblGioiTinh.Size = new Size(68, 20);
        lblGioiTinh.TabIndex = 7;
        lblGioiTinh.Text = "Giới tính:";
        // 
        // dtpBirthDate
        // 
        dtpBirthDate.Format = DateTimePickerFormat.Short;
        dtpBirthDate.Location = new Point(268, 220);
        dtpBirthDate.Name = "dtpBirthDate";
        dtpBirthDate.Size = new Size(144, 27);
        dtpBirthDate.TabIndex = 8;
        // 
        // rbMale
        // 
        rbMale.AutoSize = true;
        rbMale.Location = new Point(268, 270);
        rbMale.Name = "rbMale";
        rbMale.Size = new Size(62, 24);
        rbMale.TabIndex = 9;
        rbMale.TabStop = true;
        rbMale.Text = "Nam";
        rbMale.UseVisualStyleBackColor = true;
        // 
        // rbFemale
        // 
        rbFemale.AutoSize = true;
        rbFemale.Location = new Point(362, 270);
        rbFemale.Name = "rbFemale";
        rbFemale.Size = new Size(50, 24);
        rbFemale.TabIndex = 10;
        rbFemale.TabStop = true;
        rbFemale.Text = "Nữ";
        rbFemale.UseVisualStyleBackColor = true;
        // 
        // chkTerms
        // 
        chkTerms.AutoSize = true;
        chkTerms.Location = new Point(242, 322);
        chkTerms.Name = "chkTerms";
        chkTerms.Size = new Size(253, 24);
        chkTerms.TabIndex = 11;
        chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
        chkTerms.UseVisualStyleBackColor = true;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(164, 384);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(94, 29);
        btnRegister.TabIndex = 12;
        btnRegister.Text = "Đăng Ký";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(318, 384);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(94, 29);
        btnReset.TabIndex = 13;
        btnReset.Text = "Làm Mới";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // epCheck
        // 
        epCheck.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        epCheck.ContainerControl = this;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(581, 505);
        Controls.Add(btnReset);
        Controls.Add(btnRegister);
        Controls.Add(chkTerms);
        Controls.Add(rbFemale);
        Controls.Add(rbMale);
        Controls.Add(dtpBirthDate);
        Controls.Add(lblGioiTinh);
        Controls.Add(lblBirthDate);
        Controls.Add(txtConfirmPassword);
        Controls.Add(txtPassword);
        Controls.Add(txtUsername);
        Controls.Add(lblConfirmPassword);
        Controls.Add(lblPassword);
        Controls.Add(lblUsername);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblUsername;
    private Label lblPassword;
    private Label lblConfirmPassword;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private TextBox txtConfirmPassword;
    private Label lblBirthDate;
    private Label lblGioiTinh;
    private DateTimePicker dtpBirthDate;
    private RadioButton rbMale;
    private RadioButton rbFemale;
    private CheckBox chkTerms;
    private Button btnRegister;
    private Button btnReset;
    private ErrorProvider epCheck;
}
