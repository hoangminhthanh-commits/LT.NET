using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
        string chuoi = Console.ReadLine();
        char[] mangKyTu = chuoi.ToCharArray();
        Array.Reverse(mangKyTu);
        string daoNguoc = new string(mangKyTu);
        Console.WriteLine("Chuỗi sau khi đảo ngược: " + daoNguoc);
        Console.ReadKey();
    }
}