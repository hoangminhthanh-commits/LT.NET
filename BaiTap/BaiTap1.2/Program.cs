using System;
using System.Reflection;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Phiên bản CLR / .NET đang chạy
        Console.WriteLine("Phiên bản CLR/.NET:");
        Console.WriteLine($"   Environment.Version: {Environment.Version}");
        //Tên máy tính
        Console.WriteLine("\nTên máy tính:");
        Console.WriteLine($"   {Environment.MachineName}");
        //Tên người dùng đăng nhập
        Console.WriteLine("\nTên người dùng:");
        Console.WriteLine($"   {Environment.UserName}");
        //Hệ điều hành
        Console.WriteLine("\nHệ điều hành:");
        Console.WriteLine($"   {Environment.OSVersion}");
        //Kiến trúc hệ điều hành
        Console.WriteLine("\nKiến trúc hệ điều hành:");
        Console.WriteLine($"   {(Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit")}");
        //Kiến trúc tiến trình
        Console.WriteLine("\nKiến trúc tiến trình:");
        Console.WriteLine($"   {(Environment.Is64BitProcess ? "64-bit" : "32-bit")}");
        //Bộ nhớ GC đang quản lý
        Console.WriteLine("\nBộ nhớ GC đang quản lý:");
        long memory = GC.GetTotalMemory(false);
        Console.WriteLine($"   {memory:N0} bytes");
        Console.WriteLine($"   {memory / 1024.0:N2} KB");
        Console.WriteLine($"   {memory / (1024.0 * 1024.0):N2} MB");
        //Thông tin Assembly bằng Reflection
        Console.WriteLine("\nThông tin Assembly:");
        Assembly assembly = Assembly.GetExecutingAssembly();
        Console.WriteLine($"   Tên Assembly: {assembly.GetName().Name}");
        Console.WriteLine($"   Phiên bản: {assembly.GetName().Version}");
        Console.ReadKey();
    }
}