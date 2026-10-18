using Bai5._2;
using Microsoft.Data.SqlClient;
using System.Data;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDangKy();
        }

        private void LoadDangKy()
        {
            try
            {
                Database db = new Database();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    SoDienThoai,
                    NgaySinh,
                    KhoaHoc,
                    GioiTinh,
                    HinhThuc
                FROM DangKy
                ORDER BY MaDK DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvDangKy.DataSource = dt;

                    dgvDangKy.ReadOnly = true;
                    dgvDangKy.AllowUserToAddRows = false;
                    dgvDangKy.AllowUserToDeleteRows = false;
                    dgvDangKy.MultiSelect = false;

                    dgvDangKy.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dgvDangKy.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dgvDangKy.Columns["SoDienThoai"].HeaderText =
                        "Số điện thoại";

                    dgvDangKy.Columns["NgaySinh"].HeaderText =
                        "Ngày sinh";

                    dgvDangKy.Columns["KhoaHoc"].HeaderText =
                        "Khóa học";

                    dgvDangKy.Columns["GioiTinh"].HeaderText =
                        "Giới tính";

                    dgvDangKy.Columns["HinhThuc"].HeaderText =
                        "Hình thức";

                    dgvDangKy.Columns["NgaySinh"]
                        .DefaultCellStyle.Format = "dd/MM/yyyy";

                    dgvDangKy.Columns["NgaySinh"]
                        .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    dgvDangKy.Columns["GioiTinh"]
                        .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    dgvDangKy.Columns["HinhThuc"]
                        .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            bool hopLe = true;

            if (!mtxtPhone.MaskCompleted)
            {
                errorProvider.SetError(
                    mtxtPhone,
                    "Vui lòng nhập đầy đủ số điện thoại!"
                );

                hopLe = false;
            }

            if (dtpBirthDate.Value.Date > DateTime.Now.Date)
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
                errorProvider.SetError(
                    rdoMale,
                    "Vui lòng chọn giới tính!"
                );

                hopLe = false;
            }

            if (!chkOnline.Checked && !chkOffline.Checked)
            {
                errorProvider.SetError(
                    chkOnline,
                    "Vui lòng chọn hình thức học!"
                );

                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            string phone = mtxtPhone.Text;

            DateTime birthDate = dtpBirthDate.Value.Date;

            string course = cboCourse.Text;

            string gender = rdoMale.Checked ? "Nam" : "Nữ";

            string hinhThuc = "";

            if (chkOnline.Checked)
            {
                hinhThuc = "Online";
            }

            if (chkOffline.Checked)
            {
                if (hinhThuc != "")
                {
                    hinhThuc += " + ";
                }

                hinhThuc += "Offline";
            }

            try
            {
                Database db = new Database();

                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO DangKy
                (
                    SoDienThoai,
                    NgaySinh,
                    KhoaHoc,
                    GioiTinh,
                    HinhThuc
                )
                VALUES
                (
                    @SoDienThoai,
                    @NgaySinh,
                    @KhoaHoc,
                    @GioiTinh,
                    @HinhThuc
                )";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@SoDienThoai",
                            SqlDbType.VarChar,
                            20
                        ).Value = phone;

                        cmd.Parameters.Add(
                            "@NgaySinh",
                            SqlDbType.Date
                        ).Value = birthDate;

                        cmd.Parameters.Add(
                            "@KhoaHoc",
                            SqlDbType.NVarChar,
                            100
                        ).Value = course;

                        cmd.Parameters.Add(
                            "@GioiTinh",
                            SqlDbType.NVarChar,
                            10
                        ).Value = gender;

                        cmd.Parameters.Add(
                            "@HinhThuc",
                            SqlDbType.NVarChar,
                            20
                        ).Value = hinhThuc;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Đăng ký thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadDangKy();

                MessageBox.Show(
                    "THÔNG TIN ĐĂNG KÝ\n\n" +
                    "Số điện thoại: " + phone + "\n" +
                    "Ngày sinh: " + birthDate.ToString("dd/MM/yyyy") + "\n" +
                    "Khóa học: " + course + "\n" +
                    "Giới tính: " + gender + "\n" +
                    "Hình thức: " + hinhThuc,
                    "Thông tin đăng ký",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                mtxtPhone.Clear();

                cboCourse.SelectedIndex = -1;

                rdoMale.Checked = false;
                rdoFemale.Checked = false;

                chkOnline.Checked = false;
                chkOffline.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi đăng ký: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
