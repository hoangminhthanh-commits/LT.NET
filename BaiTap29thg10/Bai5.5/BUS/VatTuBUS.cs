using Bai5._5.DAL;
using System.Data;

namespace Bai5._5.BUS
{
    public class VatTuBUS
    {
        private VatTuDAL dal = new VatTuDAL();

        // Lấy tất cả vật tư
        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        // Thêm vật tư
        public void Them(
            string ma,
            string ten,
            string dvt,
            decimal soLuong)
        {
            dal.Them(
                ma,
                ten,
                dvt,
                soLuong);
        }

        // Sửa vật tư
        public void Sua(
            string ma,
            string ten,
            string dvt,
            decimal soLuong)
        {
            dal.Sua(
                ma,
                ten,
                dvt,
                soLuong);
        }

        // Xóa vật tư
        public void Xoa(string ma)
        {
            dal.Xoa(ma);
        }

        // Tìm kiếm vật tư
        public DataTable TimKiem(string tuKhoa)
        {
            return dal.TimKiem(tuKhoa);
        }
    }
}