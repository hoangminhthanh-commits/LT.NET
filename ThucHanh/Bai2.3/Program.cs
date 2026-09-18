using System;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=System.Text.Encoding.UTF8;
        Console.Write("Nhập chuỗi: ");
        string input=Console.ReadLine();
        string chuanHoa=input.Replace(" ", "").ToLower();
        Console.WriteLine("Chuỗi chuẩn hóa: " + chuanHoa);
        char[] kyTu = chuanHoa.ToCharArray();
        Array.Reverse(kyTu);
        string daoNguoc = new string(kyTu);
        if(chuanHoa == daoNguoc)
        {
            Console.WriteLine("Chuỗi là Palindrome!");
        }
        else
        {
            Console.WriteLine("Chuỗi không phải là Palindrome!");
        }
        Console.ReadKey();
    }
}