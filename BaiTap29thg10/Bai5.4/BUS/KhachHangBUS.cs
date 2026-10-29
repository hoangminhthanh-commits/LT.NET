using Bai5._4.DAL;

namespace Bai5._4.BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL dal =
            new KhachHangDAL();

        public int TimKhachHangTheoCCCD(
            string cccd)
        {
            return dal.TimKhachHangTheoCCCD(cccd);
        }

        public object GetKhachHangTheoCCCD(
            string cccd)
        {
            return dal.GetKhachHangTheoCCCD(cccd);
        }

        public int ThemKhachHang(
            string hoTen,
            string cccd,
            string soDienThoai)
        {
            return dal.ThemKhachHang(
                hoTen,
                cccd,
                soDienThoai);
        }
    }
}