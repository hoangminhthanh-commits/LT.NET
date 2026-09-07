using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();
        string[] ten = hoTen.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );
        for( int i = 0; i < ten.Length; i++)
        {
            ten[i]=char.ToUpper(ten[i][0]) + ten[i].Substring(1).ToLower();
        }
        string tenChuanHoa = string.Join(" ", ten);
        Console.WriteLine("Họ tên đã chuẩn hóa: " + tenChuanHoa);
        Console.ReadKey();
    }
}