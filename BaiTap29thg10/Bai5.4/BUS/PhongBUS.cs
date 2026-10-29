using System.Data;
using Bai5._4.DAL;

namespace Bai5._4.BUS
{
    public class PhongBUS
    {
        private PhongDAL dal = new PhongDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public DataTable GetPhongTrong()
        {
            return dal.GetPhongTrong();
        }

        public void CapNhatTrangThai(
            string soPhong,
            string trangThai)
        {
            dal.CapNhatTrangThai(
                soPhong,
                trangThai);
        }
    }
}