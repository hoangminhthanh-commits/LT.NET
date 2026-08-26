using System;
public class BaiTap3_1
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số thứ nhất a: ");
        double a=double.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập phép toán (+, -, *, /, %): ");
        char phepToan = char.Parse(Console.ReadLine());
        try
        {   
            if(phepToan == '/' || phepToan == '%' && b == 0)
            {
                throw new DivideByZeroException();
            }
            double ketQua = phepToan switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                '%' => a % b,
                _ => throw new InvalidOperationException("Phép toán không hợp lệ")
            };
            Console.WriteLine($"Kết quả: {ketQua:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0!");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
        Console.ReadKey();
    }
}