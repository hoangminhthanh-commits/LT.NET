using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace BaiTap1
{
    public partial class MainForm : Form
    {
        private BindingList<Appointment> appointments = new BindingList<Appointment>();
        private BindingList<Appointment> displayedAppointments = new BindingList<Appointment>();
        private bool isLoading = false;
        private Appointment editingAppointment = null;
        public MainForm()
        {
            InitializeComponent();

            SetupComboBoxes();
            ConfigureGrid();
            SetupDataBinding();
            SetupEvents();
            SetupStatusStrip();

            errorProvider1.ContainerControl = this;

            dtpAppointmentDate.Format = DateTimePickerFormat.Custom;
            dtpAppointmentDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpAppointmentDate.ShowUpDown = true;

            dtpFilterDate.Format = DateTimePickerFormat.Custom;
            dtpFilterDate.CustomFormat = "dd/MM/yyyy";

            errorProvider1.ContainerControl = this;

            RefreshGrid();
        }
        private void SetupComboBoxes()
        {
            cboDoctor.Items.Clear();
            cboDoctor.Items.AddRange(new object[]
            {
                "Nguyễn Văn An",
                "Trần Thị Bình",
                "Lê Văn Cường",
                "Phạm Thị Dung"
            });
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.SelectedIndex = 0;

            cboStatus.Items.Clear();
            cboStatus.Items.AddRange(new object[]
            {
                "Chờ khám",
                "Đang khám",
                "Hoàn tất",
                "Đã hủy"
            });
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.SelectedIndex = 0;

            cboFilterStatus.Items.Clear();
            cboFilterStatus.Items.AddRange(new object[]
            {
                "Tất cả",
                "Chờ khám",
                "Đang khám",
                "Hoàn tất",
                "Đã hủy"
            });
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.SelectedIndex = 0;
        }
        private void ConfigureGrid()
        {
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.MultiSelect = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.AllowUserToAddRows = false;
        }

        private void SetupDataBinding()
        {
            bindingSourceAppointments.DataSource = appointments;
            dgvAppointments.DataSource = bindingSourceAppointments;
        }
        private void SetupEvents()
        {
            chkFilterDate.CheckedChanged += (s, e) => RefreshGrid();
            btnAdd.Click += (s, e) => AddAppointment();
            btnEdit.Click += (s, e) => EditAppointment();
            btnUpdate.Click += (s, e) => UpdateAppointment();
            btnDelete.Click += (s, e) => DeleteAppointment();

            dgvAppointments.SelectionChanged +=
                dgvAppointments_SelectionChanged;

            txtSearch.TextChanged += (s, e) => RefreshGrid();
            cboFilterStatus.SelectedIndexChanged +=
                (s, e) => RefreshGrid();
            dtpFilterDate.ValueChanged +=
                (s, e) => RefreshGrid();

            mnuExportCsv.Click += (s, e) => ExportToCsv();
            mnuExit.Click += (s, e) => Close();
        }
        private void SetupStatusStrip()
        {
            UpdateStatusStrip(appointments.Count);
        }

        private void UpdateStatusStrip(int count)
        {
            lblCount.Text = $"Số lịch hẹn đang hiển thị: {count}";
        }

        private void RefreshGrid()
        {
            string keyword = txtSearch.Text.Trim();

            string status = cboFilterStatus.SelectedItem?.ToString()
                            ?? "Tất cả";

            DateTime filterDate = dtpFilterDate.Value.Date;

            var result = appointments.Where(a =>
                (string.IsNullOrWhiteSpace(keyword) ||
                 a.PatientName.Contains(
                     keyword, StringComparison.OrdinalIgnoreCase) ||
                 a.Phone.Contains(keyword))

                && (status == "Tất cả" || a.Status == status)

                && (!chkFilterDate.Checked ||
                    a.AppointmentDate.Date == filterDate)
            ).ToList();

            displayedAppointments = new BindingList<Appointment>(result);
            bindingSourceAppointments.DataSource = displayedAppointments;

            UpdateStatusStrip(result.Count);
        }
        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;

            if (dgvAppointments.Rows.Count == 0)
                return;

            if (dgvAppointments.CurrentRow == null)
                return;

            if (dgvAppointments.CurrentRow.IsNewRow)
                return;

            Appointment a = null;

            try
            {
                a = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            }
            catch (IndexOutOfRangeException)
            {
                return;
            }

            if (a == null)
                return;

            isLoading = true;

            try
            {
                txtAppointmentId.Text = a.AppointmentId;
                txtPatientName.Text = a.PatientName;
                txtPhone.Text = a.Phone;
                dtpAppointmentDate.Value = a.AppointmentDate;
                cboDoctor.SelectedItem = a.Doctor;
                txtReason.Text = a.Reason;
                cboStatus.SelectedItem = a.Status;
            }
            finally
            {
                isLoading = false;
            }
        }
        private bool ValidateInput(bool isAdding)
        {
            errorProvider1.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txtAppointmentId.Text))
            {
                errorProvider1.SetError(txtAppointmentId, "Vui lòng nhập mã lịch hẹn.");
                valid = false;
            }
            else if (isAdding && appointments.Any(a =>
                a.AppointmentId.Equals(
                    txtAppointmentId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn đã tồn tại.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errorProvider1.SetError(txtPatientName, "Vui lòng nhập họ tên.");
                valid = false;
            }

            string phone = txtPhone.Text.Trim();

            if (!Regex.IsMatch(phone, @"^0\d{9}$"))
            {
                errorProvider1.SetError(
                    txtPhone,
                    "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng 0.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider1.SetError(txtReason, "Vui lòng nhập lý do khám.");
                valid = false;
            }

            if (dtpAppointmentDate.Value < DateTime.Now)
            {
                errorProvider1.SetError(
                    dtpAppointmentDate,
                    "Ngày giờ hẹn không được ở trong quá khứ.");
                valid = false;
            }

            if (cboDoctor.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboDoctor, "Vui lòng chọn bác sĩ.");
                valid = false;
            }

            if (cboStatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(cboStatus, "Vui lòng chọn trạng thái.");
                valid = false;
            }

            return valid;
        }

        private Appointment ReadInput()
        {
            return new Appointment
            {
                AppointmentId = txtAppointmentId.Text.Trim(),
                PatientName = txtPatientName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                AppointmentDate = dtpAppointmentDate.Value,
                Doctor = cboDoctor.Text,
                Reason = txtReason.Text.Trim(),
                Status = cboStatus.Text
            };
        }
        private void AddAppointment()
        {
            if (!ValidateInput(true))
                return;

            Appointment newAppointment = ReadInput();

            appointments.Add(newAppointment);

            dtpFilterDate.Value = newAppointment.AppointmentDate.Date;

            cboFilterStatus.SelectedIndex = 0;

            txtSearch.Clear();

            RefreshGrid();

            MessageBox.Show("Thêm lịch hẹn thành công.");
        }

        private void UpdateAppointment()
        {
            if (editingAppointment == null)
            {
                MessageBox.Show("Vui lòng bấm Sửa và chọn lịch hẹn trước.");
                return;
            }

            if (!ValidateInput(false))
                return;

            string newId = txtAppointmentId.Text.Trim();

            if (appointments.Any(a =>
                !ReferenceEquals(a, editingAppointment) &&
                a.AppointmentId.Equals(
                    newId, StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(
                    txtAppointmentId, "Mã lịch hẹn đã tồn tại.");
                return;
            }

            editingAppointment.AppointmentId = newId;
            editingAppointment.PatientName = txtPatientName.Text.Trim();
            editingAppointment.Phone = txtPhone.Text.Trim();
            editingAppointment.AppointmentDate = dtpAppointmentDate.Value;
            editingAppointment.Doctor = cboDoctor.Text;
            editingAppointment.Reason = txtReason.Text.Trim();
            editingAppointment.Status = cboStatus.Text;

            Appointment updated = editingAppointment;
            editingAppointment = null;

            txtAppointmentId.Enabled = true;

            chkFilterDate.Checked = false;
            cboFilterStatus.SelectedIndex = 0;
            txtSearch.Clear();

            bindingSourceAppointments.ResetBindings(false);
            RefreshGrid();

            MessageBox.Show("Cập nhật lịch hẹn thành công.");
        }

        private void EditAppointment()
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is not Appointment selected)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần sửa.");
                return;
            }

            editingAppointment = selected;

            isLoading = true;
            try
            {
                txtAppointmentId.Text = selected.AppointmentId;
                txtPatientName.Text = selected.PatientName;
                txtPhone.Text = selected.Phone;
                dtpAppointmentDate.Value = selected.AppointmentDate;
                cboDoctor.SelectedItem = selected.Doctor;
                txtReason.Text = selected.Reason;
                cboStatus.SelectedItem = selected.Status;
            }
            finally
            {
                isLoading = false;
            }

            txtAppointmentId.Enabled = false;

            MessageBox.Show("Đã chọn lịch hẹn. Hãy chỉnh sửa thông tin rồi bấm Cập nhật.");
        }
        private void DeleteAppointment()
        {
            Appointment selected =
                dgvAppointments.CurrentRow?.DataBoundItem as Appointment;

            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                $"Bạn có chắc muốn xóa lịch hẹn {selected.AppointmentId}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
                return;

            appointments.Remove(selected);

            RefreshGrid();
            errorProvider1.Clear();

            MessageBox.Show("Đã xóa lịch hẹn.");
        }
        private void ExportToCsv()
        {
            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "DanhSachLichHen.csv",
                Title = "Xuất danh sách lịch hẹn"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var rows = bindingSourceAppointments
                .Cast<Appointment>()
                .ToList();

            StringBuilder csv = new StringBuilder();

            csv.AppendLine(
                "Ma lich hen,Ho ten benh nhan,So dien thoai,Ngay gio hen,Bac si,Ly do,Trang thai");

            foreach (Appointment a in rows)
            {
                string[] values =
                {
            a.AppointmentId,
            a.PatientName,
            a.Phone,
            a.AppointmentDate.ToString("dd/MM/yyyy HH:mm"),
            a.Doctor,
            a.Reason,
            a.Status
        };

                csv.AppendLine(string.Join(",",
                    values.Select(EscapeCsv)));
            }

            File.WriteAllText(
                dialog.FileName,
                "\uFEFF" + csv.ToString(),
                Encoding.UTF8);

            MessageBox.Show("Xuất CSV thành công.");
        }

        private string EscapeCsv(string value)
        {
            value ??= "";
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
