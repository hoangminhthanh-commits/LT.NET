using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập cân nặng (kg): ");
        double canNang = double.Parse(Console.ReadLine());
        Console.Write("Nhap chiều cao (m): ");
        double chieuCao = double.Parse(Console.ReadLine());
        double BMI = canNang / (chieuCao * chieuCao);
        Console.WriteLine($"Chỉ số BMI: {BMI:F2}");
        if (BMI < 18.5)
        {
            Console.WriteLine("Phân loại WHO: Gầy");
        }
        else if(BMI>=18.5 && BMI < 23)
        {
            Console.WriteLine("Phân loại WHO: Bình thường");
        }
        else if(BMI>=23 && BMI < 25)
        {
            Console.WriteLine("Phân loại WHO: Thừa cân");
        }
        else
        {
            Console.WriteLine("Phân loại WHO: Béo phì");
        }
        Console.ReadKey();
    }
}