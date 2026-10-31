using System.Data;
using HRM_Payroll.DAL;

namespace HRM_Payroll.BUS
{
    public class BangLuongBUS
    {
        private readonly BangLuongDAL dal = new BangLuongDAL();
        public DataTable GetByMonth(string month) { return dal.GetByMonth(month); }
        public void ChotLuong(string month) { dal.ChotLuong(month); }
    }
}
