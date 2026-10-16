
using System;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmPatientProfiles : Form
    {
        public frmPatientProfiles()
        {
            InitializeComponent();

            this.Text = "Quản lý hồ sơ bệnh nhân";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 500);
            this.Visible = true;
        }
    }
}
