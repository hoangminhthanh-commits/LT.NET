using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số điện (kWh): ");
        double soDien = double.Parse(Console.ReadLine());
        double tienDien = 0;
        if (soDien <= 50)
        {
            tienDien = soDien * 1678;
        }
        else if (soDien <= 100)
        {
            tienDien = 50 * 1678 + (soDien - 50) * 1734;
        }
        else
        {
            tienDien = 50 * 1678 + 50 * 1734 + (soDien - 100) * 2014;
        }
        Console.WriteLine($"Tiền điện trước thuế : {tienDien} VND");
        double thueVAT = tienDien * 0.08;
        Console.WriteLine($"Thuế VAT (8%): {thueVAT} VND");
        Console.WriteLine($"Tổng tiền phải trả : {tienDien + thueVAT} VND");
        Console.ReadKey();
    }
}