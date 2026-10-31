using System;
using System.Collections.Generic;
using QuanLyBanHangMini.DAL;
using QuanLyBanHangMini.DTO;

namespace QuanLyBanHangMini.BUS
{
    public class HoaDonBUS
    {
        private readonly HoaDonDAL dal = new HoaDonDAL();
        public int ThanhToan(int maNV, int? maKH, List<ChiTietHoaDonDTO> gioHang)
        {
            if (maNV <= 0) throw new Exception("Vui lòng chọn nhân viên.");
            return dal.ThanhToan(maNV, maKH, gioHang);
        }
    }
}
