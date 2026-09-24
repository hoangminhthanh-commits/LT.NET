namespace Bai4._2
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
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSoDienThoai = new TextBox();
            btnSubmit = new Button();
            lblHoTen = new Label();
            lblEmail = new Label();
            lblSoDienThoai = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(292, 108);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(186, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(292, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(186, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(292, 206);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(186, 27);
            txtSoDienThoai.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(292, 265);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(182, 111);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(57, 20);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Họ tên:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(182, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(182, 209);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số điện thoại:";
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
            ClientSize = new Size(800, 450);
            Controls.Add(lblSoDienThoai);
            Controls.Add(lblEmail);
            Controls.Add(lblHoTen);
            Controls.Add(btnSubmit);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtSoDienThoai;
        private Button btnSubmit;
        private Label lblHoTen;
        private Label lblEmail;
        private Label lblSoDienThoai;
        private ErrorProvider errorProvider;
    }
}
