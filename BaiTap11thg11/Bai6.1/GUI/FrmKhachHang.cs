using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHangMini.BUS;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.GUI
{
    public class FrmKhachHang : Form
    {
        KhachHangBUS bus=new KhachHangBUS();
        TextBox txtMa=new TextBox(),txtTen=new TextBox(),txtDT=new TextBox(),txtTim=new TextBox();
        DataGridView dgv=new DataGridView();
        public FrmKhachHang()
        {
            Text="Quản lý khách hàng"; BackColor=Color.White;
            Controls.Add(new Label{Text="QUẢN LÝ KHÁCH HÀNG",Left=20,Top=15,Width=500,Height=35,Font=new Font("Segoe UI",18,FontStyle.Bold)});
            Add("Mã KH",txtMa,25,75); txtMa.ReadOnly=true; Add("Tên khách hàng",txtTen,350,75);
            Add("Điện thoại",txtDT,25,120); Add("Tìm kiếm",txtTim,350,120);
            Button tim=B("Tìm",550,117),them=B("Thêm",25,165),sua=B("Sửa",125,165),xoa=B("Xóa",225,165),moi=B("Làm mới",325,165);
            Controls.AddRange(new Control[]{tim,them,sua,xoa,moi});
            dgv.SetBounds(25,215,900,400); dgv.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgv.ReadOnly=true; dgv.SelectionMode=DataGridViewSelectionMode.FullRowSelect; dgv.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill; Controls.Add(dgv);
            tim.Click+=(s,e)=>LoadData(); them.Click+=(s,e)=>Run(()=>bus.Insert(Read()));
            sua.Click+=(s,e)=>Run(()=>bus.Update(Read())); xoa.Click+=(s,e)=>Run(()=>bus.Delete(int.Parse(txtMa.Text)));
            moi.Click+=(s,e)=>{txtMa.Clear();txtTen.Clear();txtDT.Clear();txtTim.Clear();LoadData();};
            dgv.CellClick+=(s,e)=>{if(e.RowIndex>=0){var r=dgv.Rows[e.RowIndex];txtMa.Text=""+r.Cells["MaKH"].Value;txtTen.Text=""+r.Cells["TenKH"].Value;txtDT.Text=""+r.Cells["DienThoai"].Value;}};
            LoadData();
        }
        void Add(string label,TextBox t,int x,int y){Controls.Add(new Label{Text=label,Left=x,Top=y+4,Width=120});t.SetBounds(x+125,y,180,27);Controls.Add(t);}
        Button B(string t,int x,int y){return new Button{Text=t,Left=x,Top=y,Width=85,Height=32};}
        KhachHangDTO Read(){return new KhachHangDTO{MaKH=string.IsNullOrEmpty(txtMa.Text)?0:int.Parse(txtMa.Text),TenKH=txtTen.Text.Trim(),DienThoai=txtDT.Text.Trim()};}
        void LoadData(){dgv.DataSource=bus.GetAll(txtTim.Text.Trim());}
        void Run(Action a){try{a();LoadData();MessageBox.Show("Thành công.");}catch(Exception ex){MessageBox.Show(ex.Message,"Lỗi");}}
    }
}
