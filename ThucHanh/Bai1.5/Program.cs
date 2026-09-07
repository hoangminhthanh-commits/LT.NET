using System;
class Program
{
    static void Main(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập lương Gross (VNĐ): ");
        int luongGross = int.Parse(Console.ReadLine());
        Console.Write("Nhập số người phụ thuộc: ");
        int soNguoiPhuThuoc = int.Parse(Console.ReadLine());
        int tongGiamTru = 11000000 + 4400000 * soNguoiPhuThuoc;
        Console.WriteLine($"Tổng giảm trừ gia cảnh: {tongGiamTru} VNĐ");
        int thuNhapChiuThue = luongGross - tongGiamTru;
        Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue} VNĐ");
        double thue;
        int soTruCoDinh;
        if (thuNhapChiuThue <= 5000000)
        {
            thue = 0.05;
            soTruCoDinh = 0;
        }
        else if (thuNhapChiuThue > 5000000 && thuNhapChiuThue <= 10000000)
        {
            thue = 0.1;
            soTruCoDinh = 250000;
        }
        else if (thuNhapChiuThue > 10000000 && thuNhapChiuThue <= 18000000)
        {
            thue = 0.15;
            soTruCoDinh = 750000;
        }
        else if (thuNhapChiuThue > 18000000 && thuNhapChiuThue <= 32000000)
        {
            thue = 0.2;
            soTruCoDinh = 1650000;
        }
        else if (thuNhapChiuThue > 32000000 && thuNhapChiuThue <= 52000000)
        {
            thue = 0.25;
            soTruCoDinh = 3250000;
        }
        else if (thuNhapChiuThue > 52000000 && thuNhapChiuThue <= 80000000)
        {
            thue = 0.3;
            soTruCoDinh = 5850000;
        }
        else
        {
            thue = 0.35;
            soTruCoDinh = 9850000;
        }
        int thueTNCN = (int)(thuNhapChiuThue * thue - soTruCoDinh);
        Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN} VNĐ");
        Console.ReadKey();
    }
}