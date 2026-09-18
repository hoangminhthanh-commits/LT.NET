using System;
class Program
{
    static bool IsPrime(int Number)
    {
        if (Number < 2)
            return false;
        for(int i=2; i< Number; i++)
        {
            if(Number%i==0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] a= { 12, 7, 19, 4, 23, 15, 2, 8, 11 };
        Console.WriteLine("Mảng đầu vào là: " + string.Join(", ", a));
        Console.WriteLine("Các số nguyên tố trong mảng là: ");

        int i = 0;
        foreach (int number in a)
        {
            i++;
            if (IsPrime(number))
            {
                Console.Write(number);
                if (i < a.Length - 1)
                    Console.Write(", ");
            }
        }
        Console.WriteLine();
        Array.Sort(a);
        Console.WriteLine("Mảng sau khi sắp xếp là: " + string.Join(", ", a));
        Console.ReadKey();
    }
}