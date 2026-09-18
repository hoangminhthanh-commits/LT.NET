using System;

class Program
{
    static bool doiXung(string chuoi, char[] mangKyTu)
    {
        for (int i = 0; i < chuoi.Length / 2; i++)
        {
            if (mangKyTu[i] != mangKyTu[mangKyTu.Length - 1 - i])
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
        string chuoi = Console.ReadLine();
        char[] mangKyTu = chuoi.ToCharArray();
        if (doiXung(chuoi, mangKyTu))
            Console.WriteLine("Chuỗi đối xứng!");
        else
            Console.WriteLine("Chuỗi không đối xứng!");
        Console.ReadKey();
    }
}