using System;
using System.Data;
using QuanLyBanHangMini.DAL;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL dal = new NhanVienDAL();
        public DataTable GetAll(string kw) { return dal.GetAll(kw); }
        public void Insert(NhanVienDTO n) { Validate(n); dal.Insert(n); }
        public void Update(NhanVienDTO n) { Validate(n); dal.Update(n); }
        public void Delete(int ma) { dal.Delete(ma); }
        private void Validate(NhanVienDTO n)
        { if (n == null || string.IsNullOrWhiteSpace(n.TenNV)) throw new Exception("Tên nhân viên không được để trống."); }
    }
}
