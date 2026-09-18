using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
        string chuoi = Console.ReadLine();
        int dem = 0;
        for(int i=0; i < chuoi.Length; i++)
        {
            if(!char.IsWhiteSpace(chuoi[i])&& !char.IsPunctuation(chuoi[i]))
            {
                dem++;
            }
        }
        Console.WriteLine("Số ký tự trong chuỗi là: " + dem);
        Console.ReadKey();
    }
}