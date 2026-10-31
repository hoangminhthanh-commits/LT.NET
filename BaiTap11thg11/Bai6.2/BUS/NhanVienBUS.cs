using System;
using System.Data;
using HRM_Payroll.DAL;

namespace HRM_Payroll.BUS
{
    public class NhanVienBUS
    {
        private readonly NhanVienDAL dal = new NhanVienDAL();
        public DataTable GetAll(string key) { return dal.GetAll(key); }
        public DataTable GetPhongBan() { return dal.GetPhongBan(); }
        public void Insert(string ten, DateTime? ns, string cccd, int pb, decimal luong, double hs)
        {
            Validate(ten, luong, hs); dal.Insert(ten, ns, cccd, pb, luong, hs);
        }
        public void Update(int ma, string ten, DateTime? ns, string cccd, int pb, decimal luong, double hs)
        {
            Validate(ten, luong, hs); dal.Update(ma, ten, ns, cccd, pb, luong, hs);
        }
        public void Delete(int ma) { dal.Delete(ma); }
        private void Validate(string ten, decimal luong, double hs)
        {
            if (string.IsNullOrWhiteSpace(ten)) throw new ArgumentException("Họ tên không được để trống.");
            if (luong <= 0) throw new ArgumentException("Lương cơ bản phải lớn hơn 0.");
            if (hs <= 0) throw new ArgumentException("Hệ số lương phải lớn hơn 0.");
        }
    }
}
