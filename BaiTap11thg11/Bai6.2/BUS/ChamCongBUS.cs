using System;
using System.Data;
using HRM_Payroll.DAL;

namespace HRM_Payroll.BUS
{
    public class ChamCongBUS
    {
        private readonly ChamCongDAL dal = new ChamCongDAL();
        public DataTable LoadMonth(string month) { return dal.LoadMonth(month); }
        public void SaveMonth(DataTable dt, string month)
        {
            foreach (DataRow r in dt.Rows)
            {
                double ngay = Convert.ToDouble(r["SoNgayCong"]);
                double ot = Convert.ToDouble(r["SoGioOT"]);
                if (ngay < 0 || ngay > 31) throw new ArgumentException("Số ngày công phải từ 0 đến 31.");
                if (ot < 0) throw new ArgumentException("Số giờ OT không được âm.");
            }
            dal.SaveMonth(dt, month);
        }
    }
}
