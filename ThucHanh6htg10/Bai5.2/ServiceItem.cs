using System;
using System.Collections.Generic;
using System.Text;

namespace Bai5._2
{
    internal class ServiceItem
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price:N0} VNĐ";
        }
    }
}
