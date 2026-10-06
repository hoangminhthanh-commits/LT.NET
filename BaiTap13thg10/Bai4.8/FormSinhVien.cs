using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Bai4._8
{
    public partial class FormSinhVien : Form
    {
        private readonly FormMain _formMain;
        public FormSinhVien(FormMain formMain)
        {
            InitializeComponent();

            _formMain = formMain;

            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            lblPhanTram.Text = "0%";

            dgvSinhVien.AutoGenerateColumns = true;
        }

        private async Task<List<SinhVien>> NapDuLieuAsync(IProgress<int> progress)
        {
            return await Task.Run(async () =>
            {
                List<SinhVien> danhSach = new List<SinhVien>();

                int tongSo = 100;

                for (int i = 1; i <= tongSo; i++)
                {
                    await Task.Delay(50);

                    danhSach.Add(new SinhVien
                    {
                        MaSV = "SV" + i.ToString("D3"),
                        HoTen = "Sinh viên " + i,
                        Lop = "CNTT" + ((i % 3) + 1)
                    });

                    int phanTram = i * 100 / tongSo;
                    progress.Report(phanTram);
                }

                return danhSach;
            });
        }
        private async void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            btnNapDuLieu.Enabled = false;

            progressBar1.Value = 0;
            lblPhanTram.Text = "0%";

            _formMain.CapNhatTienTrinh(0);

            try
            {
                IProgress<int> progress = new Progress<int>(
                    phanTram =>
                    {
                        progressBar1.Value = phanTram;
                        lblPhanTram.Text = phanTram + "%";

                        _formMain.CapNhatTienTrinh(phanTram);
                    });

                List<SinhVien> danhSach = await NapDuLieuAsync(progress);

                dgvSinhVien.DataSource = danhSach;

                _formMain.CapNhatTrangThai("Nạp dữ liệu hoàn tất!");

                MessageBox.Show(
                    "Đã nạp thành công " + danhSach.Count + " sinh viên!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _formMain.CapNhatTrangThai("Nạp dữ liệu thất bại!");

                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnNapDuLieu.Enabled = true;
            }
        }
    }
}
