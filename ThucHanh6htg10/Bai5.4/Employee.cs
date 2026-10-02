using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._4
{
    internal class Employee
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public DateTime NgayVaoLam { get; set; }

        public string Department { get; set; }
        public string Group { get; set; }

        public Employee(
            string maNV,
            string hoTen,
            string chucVu,
            DateTime ngayVaoLam,
            string department,
            string group)
        {
            MaNV = maNV;
            HoTen = hoTen;
            ChucVu = chucVu;
            NgayVaoLam = ngayVaoLam;
            Department = department;
            Group = group;
        }
    }
}
