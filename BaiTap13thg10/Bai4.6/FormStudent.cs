using System.ComponentModel;
using System.Text;

namespace Bai4._6
{
    public partial class FormStudent : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        BindingSource bindingSource = new BindingSource();
        public FormStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            
            bindingSource.DataSource = students;

            dgvStudents.DataSource = bindingSource;

            txtStudentId.DataBindings.Add(
                "Text",
                bindingSource,
                "StudentId",
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            txtFullName.DataBindings.Add(
                "Text",
                bindingSource,
                "FullName",
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            cboGender.DataBindings.Add(
                "Text",
                bindingSource,
                "Gender",
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            bindingSource.PositionChanged += BindingSource_PositionChanged; 
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student student)
            {
                txtAge.Text = student.Age.ToString();
                LoadAvatar(student.AvatarPath);
            }
        }

        private void LoadAvatar(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                picAvatar.Image = Image.FromFile(path);
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Tuổi phải là số!");
                return;
            }

            Student student = new Student
            {
                StudentId = txtStudentId.Text,
                FullName = txtFullName.Text,
                Age = age,
                Gender = cboGender.Text,
                AvatarPath = ""
            };

            students.Add(student);

            bindingSource.Position = students.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student student)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa sinh viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    students.Remove(student);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student student)
            {
                if (!int.TryParse(txtAge.Text, out int age))
                {
                    MessageBox.Show("Tuổi phải là số!");
                    return;
                }

                student.Age = age;

                bindingSource.ResetCurrentItem();

                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "CSV Files|*.csv";
            dialog.FileName = "DanhSachSinhVien.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csv = new StringBuilder();

                csv.AppendLine("StudentId,FullName,Age,Gender,AvatarPath");

                foreach (Student student in students)
                {
                    csv.AppendLine(
                        $"{student.StudentId}," +
                        $"{student.FullName}," +
                        $"{student.Age}," +
                        $"{student.Gender}," +
                        $"{student.AvatarPath}");
                }

                File.WriteAllText(
                    dialog.FileName,
                    csv.ToString(),
                    Encoding.UTF8);

                MessageBox.Show("Xuất file CSV thành công!");
            }
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not Student student)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên!");
                return;
            }

            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                student.AvatarPath = dialog.FileName;

                LoadAvatar(student.AvatarPath);

                bindingSource.ResetCurrentItem();
            }
        }
    }
}
