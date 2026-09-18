using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        double[] diem = { 8.5, 4.0, 9.2, 6.5, 3.5, 7.8, 10.0, 5.0 };
        int soLuongHocSinh = diem.Length;
        double tongDiem = 0;
        double diemCaoNhat = diem[0];
        double diemThapNhat = diem[0];
        int soHocSinhDat = 0;
        foreach (double d in diem)
        {
            tongDiem += d;
            if (d > diemCaoNhat)
                diemCaoNhat = d;
            else if (d < diemThapNhat)
                diemThapNhat = d;
            if (d >= 5.0)
                soHocSinhDat++;
        }
        double diemTrungBinh = tongDiem / soLuongHocSinh;
        Console.WriteLine("Số lượng học sinh: " + soLuongHocSinh);
        Console.WriteLine("Điểm trung bình: " + diemTrungBinh.ToString("F2"));
        Console.WriteLine("Điểm cao nhất: " + diemCaoNhat);
        Console.WriteLine("Điểm thấp nhất: " + diemThapNhat);
        Console.WriteLine("Số học sinh đạt: " + soHocSinhDat);
        Console.ReadKey();
    }
}