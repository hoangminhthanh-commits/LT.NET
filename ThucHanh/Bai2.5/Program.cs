using System;

class Program
{
    interface IHinhHoc
    {
        double TinhChuVi();
        double TinhDienTich();
    }
    class HinhChuNhat : IHinhHoc
    {
        private double chieuDai;
        private double chieuRong;
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public double TinhChuVi()
        {
            return 2 * (chieuDai + chieuRong);
        }
        public double TinhDienTich()
        {
            return chieuDai * chieuRong;
        }
    }
    class HinhTron : IHinhHoc
    {
        private double banKinh;
        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }
        public double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
    class HinhTamGiac : IHinhHoc
    {
        private double canhA;
        private double canhB;
        private double canhC;
        public HinhTamGiac(double canhA, double canhB, double canhC)
        {
            this.canhA = canhA;
            this.canhB = canhB;
            this.canhC = canhC;
        }
        public double TinhChuVi()
        {
            return canhA + canhB + canhC;
        }
        public double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC));
        }
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<IHinhHoc> danhSach = new List<IHinhHoc>();
        danhSach.Add(new HinhChuNhat(5.0, 3.0));
        danhSach.Add(new HinhTron(4.0));
        danhSach.Add(new HinhTamGiac(3.0, 4.0, 5.0));

        double tongDienTich = 0;
        double tongChuVi = 0;

        foreach (IHinhHoc hinh in danhSach)
        {
            double dienTich = hinh.TinhDienTich();
            double chuVi = hinh.TinhChuVi();

            Console.WriteLine(
                "Diện tích: " + dienTich.ToString("F2")
                + " | Chu vi: " + chuVi.ToString("F2"));

            tongDienTich += dienTich;
            tongChuVi += chuVi;
        }

        Console.WriteLine();
        Console.WriteLine("Tổng Diện Tích: " + tongDienTich.ToString("F2"));
        Console.WriteLine("Tổng Chu Vi: " + tongChuVi.ToString("F2"));

        Console.ReadKey();
    }
}