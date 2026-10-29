using Bai5._5.DAL;
using System.Data;

namespace Bai5._5.BUS
{
    public class PhieuKhoBUS
    {
        private PhieuKhoDAL dal =
            new PhieuKhoDAL();

        public int LuuPhieu(
            string loaiPhieu,
            int? maNCC,
            decimal tongTien,
            DataTable chiTiet)
        {
            return dal.LuuPhieu(
                loaiPhieu,
                maNCC,
                tongTien,
                chiTiet);
        }
    }
}