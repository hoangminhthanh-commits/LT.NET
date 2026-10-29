using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._3.DTO
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaBan { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime? GioRa { get; set; }
        public decimal TongTien { get; set; }
        public bool TrangThai { get; set; }
    }
}
