namespace Bai5._4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            imageListSmall = new ImageList(components);
            lsvEmployees = new ListView();
            panelTop = new Panel();
            cboViewMode = new ComboBox();
            lblView = new Label();
            imageListLarge = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Panel2.Controls.Add(panelTop);
            splitContainer1.Size = new Size(1043, 693);
            splitContainer1.SplitterDistance = 376;
            splitContainer1.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = imageListSmall;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(376, 693);
            tvDepartments.TabIndex = 0;
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            // 
            // imageListSmall
            // 
            imageListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imageListSmall.ImageStream = (ImageListStreamer)resources.GetObject("imageListSmall.ImageStream");
            imageListSmall.TransparentColor = Color.Transparent;
            imageListSmall.Images.SetKeyName(0, "congty.png");
            imageListSmall.Images.SetKeyName(1, "phongban.png");
            imageListSmall.Images.SetKeyName(2, "nhom.png");
            imageListSmall.Images.SetKeyName(3, "folder.png");
            // 
            // lsvEmployees
            // 
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imageListLarge;
            lsvEmployees.Location = new Point(0, 45);
            lsvEmployees.MultiSelect = false;
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(663, 648);
            lsvEmployees.SmallImageList = imageListSmall;
            lsvEmployees.TabIndex = 1;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(cboViewMode);
            panelTop.Controls.Add(lblView);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(663, 45);
            panelTop.TabIndex = 0;
            // 
            // cboViewMode
            // 
            cboViewMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cboViewMode.FormattingEnabled = true;
            cboViewMode.Location = new Point(308, 8);
            cboViewMode.Name = "cboViewMode";
            cboViewMode.Size = new Size(174, 28);
            cboViewMode.TabIndex = 1;
            cboViewMode.SelectedIndexChanged += cboViewMode_SelectedIndexChanged;
            // 
            // lblView
            // 
            lblView.AutoSize = true;
            lblView.Location = new Point(192, 11);
            lblView.Name = "lblView";
            lblView.Size = new Size(91, 20);
            lblView.TabIndex = 0;
            lblView.Text = "Chế độ xem:";
            // 
            // imageListLarge
            // 
            imageListLarge.ColorDepth = ColorDepth.Depth32Bit;
            imageListLarge.ImageStream = (ImageListStreamer)resources.GetObject("imageListLarge.ImageStream");
            imageListLarge.TransparentColor = Color.Transparent;
            imageListLarge.Images.SetKeyName(0, "congty.png");
            imageListLarge.Images.SetKeyName(1, "phongban.png");
            imageListLarge.Images.SetKeyName(2, "nhom.png");
            imageListLarge.Images.SetKeyName(3, "folder.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 693);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private ListView lsvEmployees;
        private Panel panelTop;
        private ComboBox cboViewMode;
        private Label lblView;
        private ImageList imageListSmall;
        private ImageList imageListLarge;
    }
}
