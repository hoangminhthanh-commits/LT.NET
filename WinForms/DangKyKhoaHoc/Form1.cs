namespace DangKyKhoaHoc
{
    public partial class Form1 : Form
    {
        class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            List<Course> courses = new List<Course>()
            {
                new Course { Id = 1, Name = "C# cơ bản" },
                new Course { Id = 2, Name = "C# nâng cao" },
                new Course { Id = 3, Name = "ASP.NET Core" }
            };
            cboCourse.DataSource = courses;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool hopLe = true;

            if (!mtxtPhone.MaskCompleted)
            {
                errorProvider.SetError(mtxtPhone, "Vui lòng nhập đầy đủ số điện thoại!");
                hopLe = false;
            }
            if (dtpBirthDate.Value > DateTime.Now)
            {
                errorProvider.SetError(
                    dtpBirthDate,
                    "Ngày sinh không được lớn hơn ngày hiện tại!"
                );

                hopLe = false;
            }
            if (cboCourse.SelectedIndex == -1)
            {
                errorProvider.SetError(
                    cboCourse,
                    "Vui lòng chọn khóa học!"
                );

                hopLe = false;
            }
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                errorProvider.SetError(rdoMale, "Vui lòng chọn giới tính!");
                hopLe = false;
            }
            if (!chkOnline.Checked && !chkOffline.Checked)
            {
                errorProvider.SetError(chkOnline, "Vui lòng chọn hình thức học!");
                hopLe = false;
            }
            if (!hopLe)
            {
                return;
            }
            MessageBox.Show("Đăng ký thành công!");

            string phone = mtxtPhone.Text;
            string birthDate = dtpBirthDate.Value.ToString("dd/MM/yyyy");

            string course = cboCourse.Text;

            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Nam";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Nữ";
            }

            string form = "";

            if (chkOnline.Checked)
            {
                form += "Online ";
            }

            if (chkOffline.Checked)
            {
                form += "Offline";
            }

            MessageBox.Show(
                "THÔNG TIN ĐĂNG KÝ\n\n" +
                "Số điện thoại: " + phone + "\n" +
                "Ngày sinh: " + birthDate + "\n" +
                "Khóa học: " + course + "\n" +
                "Giới tính: " + gender + "\n" +
                "Hình thức: " + form
            );
        }
    }
}
