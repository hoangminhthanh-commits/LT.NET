namespace Bai4._1
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
            txtDisplay = new TextBox();
            btn0 = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            btnPlus = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiply = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDivide = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            txtDisplay.Location = new Point(42, 34);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(435, 100);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.Location = new Point(42, 322);
            btn0.Name = "btn0";
            btn0.Size = new Size(95, 50);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNum_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(159, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 50);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(273, 322);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(95, 50);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(382, 322);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(95, 50);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(42, 266);
            btn1.Name = "btn1";
            btn1.Size = new Size(95, 50);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(159, 266);
            btn2.Name = "btn2";
            btn2.Size = new Size(95, 50);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(273, 266);
            btn3.Name = "btn3";
            btn3.Size = new Size(95, 50);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNum_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(382, 266);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(95, 50);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(42, 210);
            btn4.Name = "btn4";
            btn4.Size = new Size(95, 50);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(159, 210);
            btn5.Name = "btn5";
            btn5.Size = new Size(95, 50);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(273, 210);
            btn6.Name = "btn6";
            btn6.Size = new Size(95, 50);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNum_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(382, 210);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(95, 50);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(42, 154);
            btn7.Name = "btn7";
            btn7.Size = new Size(95, 50);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(159, 154);
            btn8.Name = "btn8";
            btn8.Size = new Size(95, 50);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(273, 154);
            btn9.Name = "btn9";
            btn9.Size = new Size(95, 50);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNum_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(382, 154);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(95, 50);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(btnDivide);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btn0);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn0;
        private Button btnClear;
        private Button btnEqual;
        private Button btnPlus;
        private Button btn1;
        private Button btn;
        private Button button7;
        private Button btnMinus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiply;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDivide;
        private Button btn2;
        private Button btn3;
    }
}
