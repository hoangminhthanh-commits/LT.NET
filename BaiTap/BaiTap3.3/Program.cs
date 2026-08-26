using System;
public class BaiTap3_3
{
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static bool IsPerfectNumber(int n)
    {
        if(n <= 1) return false;
        int tong = 0;
        for(int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                tong += i;
            }
        }
        return tong == n;
    }
    static void Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        Console.Write($"{n} so dau tien cua day Fibonacci : ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(a);
            if(i < n - 1)
            {
                Console.Write(", ");
            }
            int c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());
        if (IsPrime(n))
        {
            Console.WriteLine($"{n} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số nguyên tố.");
        }
        if (IsPerfectNumber(n))
        {
            Console.WriteLine($"{n} là số hoàn hảo.");
        }
        else
        {
            Console.WriteLine($"{n} không phải là số hoàn hảo.");
        }
        Fibonacci(n);
        Console.ReadKey();
    }
}