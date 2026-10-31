using System;
using System.Data;
using QuanLyBanHangMini.DAL;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.BUS
{
    public class KhachHangBUS
    {
        private readonly KhachHangDAL dal = new KhachHangDAL();
        public DataTable GetAll(string kw) { return dal.GetAll(kw); }
        public void Insert(KhachHangDTO k) { Validate(k); dal.Insert(k); }
        public void Update(KhachHangDTO k) { Validate(k); dal.Update(k); }
        public void Delete(int ma) { dal.Delete(ma); }
        private void Validate(KhachHangDTO k)
        { if (k == null || string.IsNullOrWhiteSpace(k.TenKH)) throw new Exception("Tên khách hàng không được để trống."); }
    }
}
