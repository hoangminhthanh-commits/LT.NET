namespace Bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "CSV Files|*.csv";
            saveFileDialog.Title = "Lưu file CSV";
            saveFileDialog.FileName = "DanhSach.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string duongDan = saveFileDialog.FileName;

                File.WriteAllText(
                    duongDan,
                    "Mã SP,Tên sản phẩm,Giá\r\n"
                );

                MessageBox.Show(
                    "Đã chọn nơi lưu file:\n" + duongDan,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
