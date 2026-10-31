using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanHangMini.BUS;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.GUI
{
    public class FrmSanPham : Form
    {
        SanPhamBUS bus = new SanPhamBUS();
        TextBox txtMa = new TextBox(), txtTen = new TextBox(), txtGia = new TextBox(), txtTon = new TextBox(), txtTim = new TextBox();
        DataGridView dgv = new DataGridView();
        public FrmSanPham()
        {
            Text = "Quản lý sản phẩm"; BackColor = Color.White;
            Label title = new Label { Text = "QUẢN LÝ SẢN PHẨM", Left = 20, Top = 15, Width = 500, Height = 35,
                Font = new Font("Segoe UI", 18, FontStyle.Bold) }; Controls.Add(title);
            AddLabel("Mã sản phẩm", 25, 75); AddInput(txtMa, 145, 72);
            AddLabel("Tên sản phẩm", 350, 75); AddInput(txtTen, 470, 72);
            AddLabel("Giá bán", 25, 120); AddInput(txtGia, 145, 117);
            AddLabel("Số lượng tồn", 350, 120); AddInput(txtTon, 470, 117);
            AddLabel("Tìm kiếm", 25, 170); AddInput(txtTim, 145, 167);
            Button bTim = Btn("Tìm", 370, 165), bThem = Btn("Thêm", 25, 215),
                bSua = Btn("Sửa", 125, 215), bXoa = Btn("Xóa", 225, 215), bMoi = Btn("Làm mới", 325, 215);
            Controls.AddRange(new Control[] { bTim,bThem,bSua,bXoa,bMoi });
            dgv.Left=25; dgv.Top=270; dgv.Width=900; dgv.Height=350; dgv.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            dgv.ReadOnly=true; dgv.SelectionMode=DataGridViewSelectionMode.FullRowSelect; dgv.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            Controls.Add(dgv);
            bTim.Click += (s,e)=>LoadData();
            bThem.Click += (s,e)=>Run(()=>bus.Insert(ReadForm()));
            bSua.Click += (s,e)=>Run(()=>bus.Update(ReadForm()));
            bXoa.Click += (s,e)=>Run(()=>bus.Delete(txtMa.Text.Trim()));
            bMoi.Click += (s,e)=>Clear();
            dgv.CellClick += (s,e)=>{ if(e.RowIndex>=0){ var r=dgv.Rows[e.RowIndex]; txtMa.Text=Convert.ToString(r.Cells["MaSP"].Value); txtTen.Text=Convert.ToString(r.Cells["TenSP"].Value); txtGia.Text=Convert.ToString(r.Cells["GiaBan"].Value); txtTon.Text=Convert.ToString(r.Cells["SoLuongTon"].Value); } };
            LoadData();
        }
        void AddLabel(string t,int x,int y){Controls.Add(new Label{Text=t,Left=x,Top=y+4,Width=115});}
        void AddInput(TextBox t,int x,int y){t.SetBounds(x,y,180,27);Controls.Add(t);}
        Button Btn(string t,int x,int y){return new Button{Text=t,Left=x,Top=y,Width=85,Height=32};}
        SanPhamDTO ReadForm(){return new SanPhamDTO{MaSP=txtMa.Text.Trim(),TenSP=txtTen.Text.Trim(),GiaBan=decimal.Parse(txtGia.Text),SoLuongTon=int.Parse(txtTon.Text)};}
        void LoadData()
        {
            var dt = bus.GetAll(txtTim.Text.Trim());

            dgv.DataSource = null;
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = dt;

            if (dgv.Columns.Contains("SoLuongTon"))
            {
                dgv.Columns["SoLuongTon"].Visible = true;
                dgv.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            }

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        void Run(Action a){try{a();LoadData();MessageBox.Show("Thực hiện thành công.");}catch(Exception ex){MessageBox.Show(ex.Message,"Lỗi");}}
        void Clear(){txtMa.Clear();txtTen.Clear();txtGia.Clear();txtTon.Clear();txtTim.Clear();LoadData();}
    }
}
