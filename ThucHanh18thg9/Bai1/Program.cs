using System;

class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine());
        }
        int tong=0;
        for(int i = 0; i < n; i++)
        {
            tong += a[i];
        }
        Console.WriteLine("Tổng các phần tử trong mảng là: " + tong);
        Console.ReadKey();
    }
}