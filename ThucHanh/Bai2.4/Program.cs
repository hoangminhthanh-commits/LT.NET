using System;

class Project
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random random = new Random();
        int target = random.Next(1, 101);
        int soLanDoan = 0;
        int duDoan;
        do
        {
            Console.Write("Nhập số dự đoán: ");
            duDoan = int.Parse(Console.ReadLine());
            soLanDoan++;
            if (duDoan < target)
            {
                Console.WriteLine("Số dự đoán nhỏ hơn số cần tìm!");
            }
            else if (duDoan > target)
            {
                Console.WriteLine("Số dự đoán lớn hơn số cần tìm!");
            }
        } while (duDoan != target);
        if(duDoan == target)
        {
            Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng số {target} sau {soLanDoan} lần dự đoán.");
        }
    }
}