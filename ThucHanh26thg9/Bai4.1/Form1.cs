namespace Bai4._1
{
    public partial class Form1 : Form
    {
        double soThuNhat = 0;
        string phepToan = "";
        bool anBang = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (anBang)
            {
                txtDisplay.Clear();
                anBang = false;
            }

            txtDisplay.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            soThuNhat = 0;
            phepToan = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            chonPhepToan("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            chonPhepToan("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            chonPhepToan("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            chonPhepToan("/");
        }
        private void chonPhepToan(string phep)
        {
            if (txtDisplay.Text == "")
                return;

            soThuNhat = double.Parse(txtDisplay.Text);
            phepToan = phep;

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
                        MessageBox.Show(
                            "Không thể chia cho 0!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                        return;
                    }
                    ketQua = soThuNhat / soThuHai;
                    break;
            }
            txtDisplay.Text = ketQua.ToString();
            anBang = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
