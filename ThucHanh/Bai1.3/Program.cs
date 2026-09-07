using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int ngoaiTe;
        do
        {
            Console.WriteLine("Chọn loại tiền tệ:");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. JPY");
            Console.Write("Nhập lựa chọn của bạn (1-3): ");
            ngoaiTe = int.Parse(Console.ReadLine());
            switch(ngoaiTe)
            {
                case 1:
                    Console.WriteLine("Đổi USD sang VND");
                    Console.Write("Nhập số tiền USD: ");
                    double usd = double.Parse(Console.ReadLine());
                    Console.WriteLine("Số tiền sau khi đổi sang VND: " + (usd * 25000) + " VND");
                    break;
                case 2:
                    Console.WriteLine("Đổi EUR sang VND");
                    Console.Write("Nhập số tiền EUR: ");
                    double eur = double.Parse(Console.ReadLine());
                    Console.WriteLine("Số tiền sau khi đổi sang VND: " + (eur * 30000) + " VND");
                    break;
                case 3:
                    Console.WriteLine("Đổi JPY sang VND");
                    Console.Write("Nhập số tiền JPY: ");
                    double jpy = double.Parse(Console.ReadLine());
                    Console.WriteLine("Số tiền sau khi đổi sang VND: " + (jpy * 166) + " VND");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        } while (ngoaiTe < 1 || ngoaiTe > 3);
        Console.ReadKey();
    }
}