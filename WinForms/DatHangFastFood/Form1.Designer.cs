namespace DatHangFastFood
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
            grpMenu = new GroupBox();
            lstMenu = new ListBox();
            grpSelected = new GroupBox();
            lstSelected = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblTotal = new Label();
            grpMenu.SuspendLayout();
            grpSelected.SuspendLayout();
            SuspendLayout();
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(lstMenu);
            grpMenu.Location = new Point(114, 103);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(230, 255);
            grpMenu.TabIndex = 0;
            grpMenu.TabStop = false;
            grpMenu.Text = "Món ăn";
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(0, 31);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(230, 224);
            lstMenu.TabIndex = 0;
            // 
            // grpSelected
            // 
            grpSelected.Controls.Add(lstSelected);
            grpSelected.Location = new Point(472, 103);
            grpSelected.Name = "grpSelected";
            grpSelected.Size = new Size(230, 255);
            grpSelected.TabIndex = 1;
            grpSelected.TabStop = false;
            grpSelected.Text = "Đã chọn";
            // 
            // lstSelected
            // 
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(0, 31);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(230, 224);
            lstSelected.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 50);
            btnAdd.TabIndex = 2;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(360, 253);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(95, 50);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(457, 412);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(122, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền: 0 VNĐ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(grpSelected);
            Controls.Add(grpMenu);
            Name = "Form1";
            Text = "Form1";
            grpMenu.ResumeLayout(false);
            grpSelected.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpMenu;
        private ListBox lstMenu;
        private GroupBox grpSelected;
        private ListBox lstSelected;
        private Button btnRemove;
        private Label lblTotal;
        private Button btnAdd;
    }
}
