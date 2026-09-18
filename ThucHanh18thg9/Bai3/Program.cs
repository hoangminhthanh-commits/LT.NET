using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }
        int max = a[0];
        for(int i = 1; i < n; i++)
        {
            if (max < a[i])
            {
                max = a[i];
            }
        }
        Console.WriteLine("Phần tử lớn nhất trong mảng là: " + max);
        Console.ReadKey();
    }
}