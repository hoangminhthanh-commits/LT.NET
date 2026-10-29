using System;
using System.Data;
using Bai5._4.DAL;

namespace Bai5._4.BUS
{
    public class PhieuDatPhongBUS
    {
        private PhieuDatPhongDAL dal =
            new PhieuDatPhongDAL();

        public int GetPhieuDangO(
            string soPhong)
        {
            return dal.GetPhieuDangO(
                soPhong);
        }

        public int CheckIn(
            string soPhong,
            int maKH)
        {
            return dal.CheckIn(
                soPhong,
                maKH);
        }

        public void ThemDichVu(
            int maPhieu,
            int maDV,
            int soLuong)
        {
            dal.ThemDichVu(
                maPhieu,
                maDV,
                soLuong);
        }

        public DataTable GetDichVuDaDung(
            int maPhieu)
        {
            return dal.GetDichVuDaDung(
                maPhieu);
        }

        public DateTime GetNgayNhanPhong(
            int maPhieu)
        {
            return dal.GetNgayNhanPhong(
                maPhieu);
        }

        public decimal GetGiaPhong(
            string soPhong)
        {
            return dal.GetGiaPhong(
                soPhong);
        }

        public decimal TinhTienDichVu(
            int maPhieu)
        {
            return dal.TinhTienDichVu(
                maPhieu);
        }

        public void CheckOut(
            int maPhieu,
            string soPhong,
            decimal tongTien)
        {
            dal.CheckOut(
                maPhieu,
                soPhong,
                tongTien);
        }
    }
}