namespace Bai4._4
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
            picAvatar = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnChonAnh = new Button();
            btnXuatCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(236, 20);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(225, 300);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(236, 354);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 1;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.Location = new Point(367, 354);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(94, 29);
            btnXuatCSV.TabIndex = 2;
            btnXuatCSV.Text = "Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            btnXuatCSV.Click += btnXuatCSV_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnXuatCSV);
            Controls.Add(btnChonAnh);
            Controls.Add(picAvatar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picAvatar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnChonAnh;
        private Button btnXuatCSV;
    }
}
