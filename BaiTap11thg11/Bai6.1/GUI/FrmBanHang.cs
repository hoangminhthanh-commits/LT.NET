using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyBanHangMini.BUS;
using QuanLyBanHangMini.DAL;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.GUI
{
    public class FrmBanHang : Form
    {
        SanPhamBUS spBus=new SanPhamBUS(); HoaDonBUS hdBus=new HoaDonBUS();
        TextBox txtMaSP=new TextBox(),txtSL=new TextBox{Text="1"};
        ComboBox cboNV=new ComboBox(),cboKH=new ComboBox();
        DataGridView dgv=new DataGridView();
        Label lblTong=new Label();
        List<ChiTietHoaDonDTO> gio=new List<ChiTietHoaDonDTO>();
        public FrmBanHang()
        {
            Text="Bán hàng";BackColor=Color.White;
            Controls.Add(new Label{Text="LẬP HÓA ĐƠN BÁN HÀNG",Left=20,Top=15,Width=600,Height=38,Font=new Font("Segoe UI",18,FontStyle.Bold)});
            AddLabel("Mã nhân viên",25,70);cboNV.SetBounds(130,67,220,28);cboNV.DropDownStyle=ComboBoxStyle.DropDownList;Controls.Add(cboNV);
            AddLabel("Khách hàng",390,70);cboKH.SetBounds(490,67,250,28);cboKH.DropDownStyle=ComboBoxStyle.DropDownList;Controls.Add(cboKH);
            AddLabel("Mã sản phẩm",25,115);txtMaSP.SetBounds(130,112,220,28);Controls.Add(txtMaSP);
            AddLabel("Số lượng",390,115);txtSL.SetBounds(490,112,100,28);Controls.Add(txtSL);
            Button add=new Button{Text="Thêm vào giỏ",Left=610,Top=110,Width=130,Height=32};Controls.Add(add);
            dgv.SetBounds(25,165,850,330);dgv.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgv.AutoGenerateColumns=false;dgv.ReadOnly=true;dgv.AllowUserToAddRows=false;dgv.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgv.Columns.Add(new DataGridViewTextBoxColumn{HeaderText="Mã SP",DataPropertyName="MaSP",Name="MaSP"});
            dgv.Columns.Add(new DataGridViewTextBoxColumn{HeaderText="Tên sản phẩm",DataPropertyName="TenSP",Name="TenSP",Width=250});
            dgv.Columns.Add(new DataGridViewTextBoxColumn{HeaderText="Số lượng",DataPropertyName="SoLuong",Name="SoLuong"});
            dgv.Columns.Add(new DataGridViewTextBoxColumn{HeaderText="Đơn giá",DataPropertyName="DonGia",Name="DonGia"});
            dgv.Columns.Add(new DataGridViewTextBoxColumn{HeaderText="Thành tiền",DataPropertyName="ThanhTien",Name="ThanhTien",Width=150});
            Controls.Add(dgv);
            lblTong.SetBounds(25,510,400,40);lblTong.Font=new Font("Segoe UI",16,FontStyle.Bold);lblTong.Text="Tổng tiền: 0 đ";Controls.Add(lblTong);
            Button pay=new Button{Text="THANH TOÁN",Left=620,Top=510,Width=150,Height=42,BackColor=Color.LightGreen};
            Button remove=new Button{Text="Xóa dòng",Left=460,Top=510,Width=120,Height=42};Controls.Add(pay);Controls.Add(remove);
            LoadCombos();
            add.Click+=(s,e)=>AddCart();
            remove.Click+=(s,e)=>{if(dgv.CurrentRow!=null){string ma=Convert.ToString(dgv.CurrentRow.Cells["MaSP"].Value);gio.RemoveAll(x=>x.MaSP==ma);RefreshCart();}};
            pay.Click+=(s,e)=>Pay();
        }
        void AddLabel(string t,int x,int y){Controls.Add(new Label{Text=t,Left=x,Top=y+5,Width=105});}
        void LoadCombos()
        {
            using(var cn=Database.GetConnection())
            {
                cn.Open();
                DataTable nv=new DataTable();using(var da=new Microsoft.Data.SqlClient.SqlDataAdapter("SELECT MaNV,TenNV FROM NhanVien",cn))da.Fill(nv);
                cboNV.DataSource=nv;cboNV.DisplayMember="TenNV";cboNV.ValueMember="MaNV";
                DataTable kh=new DataTable();using(var da=new Microsoft.Data.SqlClient.SqlDataAdapter("SELECT MaKH,TenKH FROM KhachHang",cn))da.Fill(kh);
                DataRow r=kh.NewRow();r["MaKH"]=DBNull.Value;r["TenKH"]="Khách lẻ";kh.Rows.InsertAt(r,0);
                cboKH.DataSource=kh;cboKH.DisplayMember="TenKH";cboKH.ValueMember="MaKH";
            }
        }
        void AddCart()
        {
            try
            {
                int sl=int.Parse(txtSL.Text);if(sl<=0)throw new Exception("Số lượng phải lớn hơn 0.");
                DataTable dt=spBus.GetAll(txtMaSP.Text.Trim());
                DataRow found=null;
                foreach(DataRow r in dt.Rows)if(Convert.ToString(r["MaSP"]).Equals(txtMaSP.Text.Trim(),StringComparison.OrdinalIgnoreCase)){found=r;break;}
                if(found==null)throw new Exception("Không tìm thấy mã sản phẩm.");
                string ma=Convert.ToString(found["MaSP"]);
                ChiTietHoaDonDTO old=gio.Find(x=>x.MaSP==ma);
                if(old==null)gio.Add(new ChiTietHoaDonDTO{MaSP=ma,TenSP=Convert.ToString(found["TenSP"]),DonGia=Convert.ToDecimal(found["GiaBan"]),SoLuong=sl});
                else old.SoLuong+=sl;
                RefreshCart();
            }catch(Exception ex){MessageBox.Show(ex.Message,"Thông báo");}
        }
        void RefreshCart(){dgv.DataSource=null;dgv.DataSource=gio;lblTong.Text="Tổng tiền: "+TongTien().ToString("N0")+" đ";}
        decimal TongTien(){decimal t=0;foreach(var x in gio)t+=x.ThanhTien;return t;}
        void Pay()
        {
            try
            {
                if(gio.Count==0)throw new Exception("Giỏ hàng đang trống.");
                int maNV=Convert.ToInt32(cboNV.SelectedValue);
                int? maKH=(cboKH.SelectedValue==null||cboKH.SelectedValue==DBNull.Value)?(int?)null:Convert.ToInt32(cboKH.SelectedValue);
                int maHD=hdBus.ThanhToan(maNV,maKH,gio);
                MessageBox.Show("Thanh toán thành công. Mã hóa đơn: "+maHD+"\nTổng tiền: "+TongTien().ToString("N0")+" đ");
                gio.Clear();RefreshCart();
            }catch(Exception ex){MessageBox.Show(ex.Message,"Thanh toán thất bại");}
        }
    }
}
