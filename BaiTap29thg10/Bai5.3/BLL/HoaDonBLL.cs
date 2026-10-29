using System.Data;
using Bai5._3.DAL;

namespace Bai5._3.BLL
{
    public class HoaDonBLL
    {
        private HoaDonDAL dal =
            new HoaDonDAL();

        public DataTable GetChiTietHoaDon(
            int maBan)
        {
            return dal.GetChiTietHoaDon(maBan);
        }

        public void ThemMon(
            int maBan,
            int maMon,
            int soLuong)
        {
            dal.ThemMon(
                maBan,
                maMon,
                soLuong);
        }

        public void SuaMon(
            int maBan,
            int maMon,
            int soLuong)
        {
            dal.SuaMon(
                maBan,
                maMon,
                soLuong);
        }

        public void XoaMon(
            int maBan,
            int maMon)
        {
            dal.XoaMon(
                maBan,
                maMon);
        }

        public void ThanhToan(
            int maBan,
            decimal tongTien)
        {
            dal.ThanhToan(
                maBan,
                tongTien);
        }
    }
}