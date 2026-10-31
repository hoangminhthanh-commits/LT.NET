using System;
using System.Data;
using QuanLyBanHangMini.DAL;

namespace QuanLyBanHangMini.BUS
{
    public class ThongKeBUS
    {
        private readonly HoaDonDAL dal = new HoaDonDAL();
        public decimal DoanhThu(DateTime tu, DateTime den) { return dal.TongDoanhThu(tu, den); }
        public DataTable Top5() { return dal.Top5(); }
        public DataTable DoanhThuTheoNgay(DateTime tu, DateTime den) { return dal.DoanhThu(tu, den); }
    }
}
