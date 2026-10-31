using System;
using System.Data;
using QuanLyBanHangMini.DAL;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL dal = new SanPhamDAL();
        public DataTable GetAll(string kw) { return dal.GetAll(kw); }
        public void Insert(SanPhamDTO p) { Validate(p); dal.Insert(p); }
        public void Update(SanPhamDTO p) { Validate(p); dal.Update(p); }
        public void Delete(string ma) { if (string.IsNullOrWhiteSpace(ma)) throw new Exception("Chọn sản phẩm cần xóa."); dal.Delete(ma); }
        private void Validate(SanPhamDTO p)
        {
            if (p == null || string.IsNullOrWhiteSpace(p.MaSP) || string.IsNullOrWhiteSpace(p.TenSP))
                throw new Exception("Mã và tên sản phẩm không được để trống.");
            if (p.GiaBan <= 0 || p.SoLuongTon < 0) throw new Exception("Giá phải > 0 và tồn kho phải >= 0.");
        }
    }
}
