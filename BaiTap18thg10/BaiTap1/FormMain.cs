using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BaiTap1
{
    public partial class FormMain : Form
    {
        private BindingList<MemberModel> members = new BindingList<MemberModel>();

        private BindingSource bsMembers = new BindingSource();

        private MemberModel selectedMember = null;

        public FormMain()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupComboBox();
            SetupBinding();

            GenerateMemberId();

            dtpStartDate.Value = DateTime.Now;

            errorProvider.Clear();

            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
        }

        private void SetupComboBox()
        {
            cboPackage.Items.Clear();

            cboPackage.Items.Add("Theo tháng");
            cboPackage.Items.Add("6 tháng");
            cboPackage.Items.Add("1 năm");

            cboPackage.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cboPackage.Items.Count > 0)
            {
                cboPackage.SelectedIndex = 0;
            }
        }

        private void SetupDataGridView()
        {
            dgvMembers.AutoGenerateColumns = false;

            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvMembers.MultiSelect = false;

            dgvMembers.ReadOnly = true;

            dgvMembers.AllowUserToAddRows = false;

            dgvMembers.AllowUserToDeleteRows = false;

            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupBinding()
        {
            bsMembers.DataSource = members;

            dgvMembers.DataSource = bsMembers;
        }

        private void GenerateMemberId()
        {
            int nextNumber = members.Count + 1;

            string newId = "HV" + nextNumber.ToString("D3");

            txtMemberId.Text = newId;
        }

        private bool ValidateFullName()
        {
            string name = txtFullName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(
                    txtFullName,
                    "Họ và tên không được để trống."
                );

                return false;
            }

            bool valid = Regex.IsMatch(
                name,
                @"^[\p{L}\s]+$"
            );

            if (!valid)
            {
                errorProvider.SetError(
                    txtFullName,
                    "Họ và tên không được chứa số hoặc ký tự đặc biệt."
                );

                return false;
            }

            errorProvider.SetError(txtFullName, "");

            return true;
        }

        private bool ValidatePhone()
        {
            string phone = txtPhone.Text.Trim();

            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                errorProvider.SetError(
                    txtPhone,
                    "Số điện thoại phải gồm đúng 10 chữ số."
                );

                return false;
            }

            errorProvider.SetError(txtPhone, "");

            return true;
        }

        private bool ValidateFee(out decimal fee)
        {
            fee = 0;

            string value = txtFee.Text.Trim();

            if (!decimal.TryParse(value, out fee))
            {
                errorProvider.SetError(
                    txtFee,
                    "Phí dịch vụ phải là số."
                );

                return false;
            }

            if (fee <= 0 || fee != Math.Truncate(fee))
            {
                errorProvider.SetError(
                    txtFee,
                    "Phí dịch vụ phải là số nguyên dương."
                );

                return false;
            }

            errorProvider.SetError(txtFee, "");

            return true;
        }

        private bool ValidateForm(out decimal fee)
        {
            fee = 0;

            errorProvider.Clear();

            bool valid = true;

            if (!ValidateFullName())
            {
                valid = false;
            }

            if (!ValidatePhone())
            {
                valid = false;
            }

            if (!ValidateFee(out fee))
            {
                valid = false;
            }

            if (cboPackage.SelectedIndex < 0)
            {
                errorProvider.SetError(
                    cboPackage,
                    "Vui lòng chọn gói tập."
                );

                valid = false;
            }

            return valid;
        }

        private MemberModel GetMemberFromForm()
        {
            decimal fee;

            decimal.TryParse(
                txtFee.Text.Trim(),
                out fee
            );

            return new MemberModel
            {
                MemberId = txtMemberId.Text.Trim(),

                FullName = txtFullName.Text.Trim(),

                Phone = txtPhone.Text.Trim(),

                Package = cboPackage.Text,

                StartDate = dtpStartDate.Value.Date,

                Fee = fee
            };
        }

        private void DisplayMember(MemberModel member)
        {
            if (member == null)
            {
                return;
            }

            txtMemberId.Text = member.MemberId;

            txtFullName.Text = member.FullName;

            txtPhone.Text = member.Phone;

            cboPackage.SelectedItem = member.Package;

            dtpStartDate.Value = member.StartDate;

            txtFee.Text = member.Fee.ToString("0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal fee;

            if (!ValidateForm(out fee))
            {
                return;
            }

            MemberModel member = GetMemberFromForm();

            if (members.Any(
                x => x.MemberId == member.MemberId))
            {
                GenerateMemberId();

                member.MemberId = txtMemberId.Text;
            }

            members.Add(member);

            MessageBox.Show(
                "Thêm hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedMember == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            decimal fee;

            if (!ValidateForm(out fee))
            {
                return;
            }

            selectedMember.FullName =
                txtFullName.Text.Trim();

            selectedMember.Phone =
                txtPhone.Text.Trim();

            selectedMember.Package =
                cboPackage.Text;

            selectedMember.StartDate =
                dtpStartDate.Value.Date;

            selectedMember.Fee = fee;

            bsMembers.ResetCurrentItem();

            MessageBox.Show(
                "Cập nhật hội viên thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMember == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn hội viên cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hội viên " +
                selectedMember.FullName +
                " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                members.Remove(selectedMember);

                MessageBox.Show(
                    "Xóa hội viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearForm();
            }
        }
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            ClearForm();
        }

        private void dgvMembers_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                selectedMember = null;

                return;
            }

            if (dgvMembers.CurrentRow.DataBoundItem
                is MemberModel member)
            {
                selectedMember = member;

                DisplayMember(member);
            }
        }

        private void ClearForm()
        {
            selectedMember = null;

            txtFullName.Clear();

            txtPhone.Clear();

            txtFee.Clear();

            if (cboPackage.Items.Count > 0)
            {
                cboPackage.SelectedIndex = 0;
            }

            dtpStartDate.Value = DateTime.Now;

            errorProvider.Clear();

            GenerateMemberId();

            dgvMembers.ClearSelection();
        }
    }
}
