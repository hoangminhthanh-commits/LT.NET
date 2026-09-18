using System;

class Program
{
    static int DemKyTu(string chuoi, char kyTu)
    {
        int dem = 0;
        for (int i = 0; i < chuoi.Length; i++)
        {
            if (chuoi[i] == kyTu)
            {
                dem++;
            }
        }
        return dem;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
        string chuoi = Console.ReadLine();
        Console.Write("Nhập ký tự cần đếm: ");
        char kyTu = Convert.ToChar(Console.ReadLine());
        int soLan= DemKyTu(chuoi, kyTu);
        Console.WriteLine("Ký tự '" + kyTu + "' xuất hiện " + soLan + " lần.");
        Console.ReadKey();
    }
}