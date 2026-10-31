using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHangMini.BUS;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.GUI
{
    public class FrmNhanVien : Form
    {
        NhanVienBUS bus=new NhanVienBUS();
        TextBox txtMa=new TextBox(),txtTen=new TextBox(),txtDT=new TextBox(),txtCV=new TextBox(),txtTim=new TextBox();
        DataGridView dgv=new DataGridView();
        public FrmNhanVien()
        {
            Text="Quản lý nhân viên"; BackColor=Color.White;
            Controls.Add(new Label{Text="QUẢN LÝ NHÂN VIÊN",Left=20,Top=15,Width=500,Height=35,Font=new Font("Segoe UI",18,FontStyle.Bold)});
            Add("Mã NV",txtMa,25,75);txtMa.ReadOnly=true;Add("Tên nhân viên",txtTen,350,75);
            Add("Điện thoại",txtDT,25,120);Add("Chức vụ",txtCV,350,120);Add("Tìm kiếm",txtTim,25,165);
            Button tim=B("Tìm",350,162),them=B("Thêm",25,210),sua=B("Sửa",125,210),xoa=B("Xóa",225,210),moi=B("Làm mới",325,210);
            Controls.AddRange(new Control[]{tim,them,sua,xoa,moi});
            dgv.SetBounds(25,260,900,350);dgv.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgv.ReadOnly=true;dgv.SelectionMode=DataGridViewSelectionMode.FullRowSelect;dgv.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;Controls.Add(dgv);
            tim.Click+=(s,e)=>LoadData();them.Click+=(s,e)=>Run(()=>bus.Insert(Read()));sua.Click+=(s,e)=>Run(()=>bus.Update(Read()));
            xoa.Click+=(s,e)=>Run(()=>bus.Delete(int.Parse(txtMa.Text)));
            moi.Click+=(s,e)=>{txtMa.Clear();txtTen.Clear();txtDT.Clear();txtCV.Clear();txtTim.Clear();LoadData();};
            dgv.CellClick+=(s,e)=>{if(e.RowIndex>=0){var r=dgv.Rows[e.RowIndex];txtMa.Text=""+r.Cells["MaNV"].Value;txtTen.Text=""+r.Cells["TenNV"].Value;txtDT.Text=""+r.Cells["SoDienThoai"].Value;txtCV.Text=""+r.Cells["ChucVu"].Value;}};
            LoadData();
        }
        void Add(string l,TextBox t,int x,int y){Controls.Add(new Label{Text=l,Left=x,Top=y+4,Width=120});t.SetBounds(x+125,y,180,27);Controls.Add(t);}
        Button B(string t,int x,int y){return new Button{Text=t,Left=x,Top=y,Width=85,Height=32};}
        NhanVienDTO Read(){return new NhanVienDTO{MaNV=string.IsNullOrEmpty(txtMa.Text)?0:int.Parse(txtMa.Text),TenNV=txtTen.Text.Trim(),SoDienThoai=txtDT.Text.Trim(),ChucVu=txtCV.Text.Trim()};}
        void LoadData(){dgv.DataSource=bus.GetAll(txtTim.Text.Trim());}
        void Run(Action a){try{a();LoadData();MessageBox.Show("Thành công.");}catch(Exception ex){MessageBox.Show(ex.Message,"Lỗi");}}
    }
}
