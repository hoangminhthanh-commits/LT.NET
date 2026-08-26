using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int luaChon;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Chạy bài tập 1 (Calculator)");
            Console.WriteLine("2. Chạy bài tập 2 (Phương trình bậc 2)");
            Console.WriteLine("3. Chạy bài tập 3 (Số nguyên tố, số hoàn hào và Fibonacci)");
            Console.WriteLine("0. Thoát chương trình");
            Console.Write("Chọn một tùy chọn: ");
            luaChon = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (luaChon)
            {
                case 1:
                    Console.WriteLine("Bài tập 1: Calculator");
                    BaiTap3_1.Main();
                    break;
                case 2:
                    Console.WriteLine("Bài tập 2: Phương trình bậc 2");
                    BaiTap3_2.Main();
                    break;
                case 3:
                    Console.WriteLine("Bài tập 3: Số nguyên tố, số hoàn hảo và Fibonacci");
                    BaiTap3_3.Main();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ.");
                    break;
            }
            if (luaChon != 0)
            {
                Console.WriteLine("Nhấn phím bất kỳ để quay lại menu!");
                Console.ReadKey();
            }
        } while (luaChon != 0);
    }
}