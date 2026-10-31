using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHangMini.BUS;

namespace QuanLyBanHangMini.GUI
{
    public class FrmThongKe : Form
    {
        ThongKeBUS bus=new ThongKeBUS();
        DateTimePicker tu=new DateTimePicker(),den=new DateTimePicker();
        Label tong=new Label();
        DataGridView dgv=new DataGridView();
        public FrmThongKe()
        {
            Text="Thống kê";BackColor=Color.White;
            Controls.Add(new Label{Text="THỐNG KÊ - BÁO CÁO",Left=20,Top=15,Width=500,Height=35,Font=new Font("Segoe UI",18,FontStyle.Bold)});
            Controls.Add(new Label{Text="Từ ngày",Left=25,Top=75,Width=70});
            tu.SetBounds(95,72,180,28);tu.Value=DateTime.Today;Controls.Add(tu);
            Controls.Add(new Label{Text="Đến ngày",Left=300,Top=75,Width=70});
            den.SetBounds(375,72,180,28);den.Value=DateTime.Today;Controls.Add(den);
            Button b=new Button{Text="Thống kê doanh thu",Left=580,Top=70,Width=160,Height=32};Controls.Add(b);
            tong.SetBounds(25,120,600,35);tong.Font=new Font("Segoe UI",14,FontStyle.Bold);Controls.Add(tong);
            dgv.SetBounds(25,170,850,400);dgv.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;Controls.Add(dgv);
            b.Click+=(s,e)=>LoadReport();LoadReport();
        }
        void LoadReport()
        {
            try
            {
                tong.Text="Tổng doanh thu: "+bus.DoanhThu(tu.Value,den.Value).ToString("N0")+" đ";
                dgv.DataSource=bus.Top5();
            }
            catch(Exception ex){MessageBox.Show(ex.Message);}
        }
    }
}
