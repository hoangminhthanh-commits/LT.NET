namespace Calculator
{
    public partial class Form1 : Form
    {
        double soThuNhat = 0;
        string phepToan = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtDisplay.Text += btn.Text;
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepToan = "+";
            txtDisplay.Clear();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepToan = "-";
            txtDisplay.Clear();
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepToan = "*";
            txtDisplay.Clear();
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepToan = "/";
            txtDisplay.Clear();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
                return;

            double soThuHai = double.Parse(txtDisplay.Text);
            double ketQua = 0;

            switch (phepToan)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            txtDisplay.Text = ketQua.ToString();
        }
            private void btnClear_Click(object sender, EventArgs e)
            {
            txtDisplay.Clear();

            soThuNhat = 0;
            phepToan = "";
        }
    }
}
