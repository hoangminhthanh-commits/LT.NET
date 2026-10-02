using System;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Linq;

public abstract class PhuongTien
{
    private string _maPT;
    private string _tenHang;
    private int _namSanXuat;
    private decimal _giaGoc;
    public string MaPT
    {
        get => _maPT;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Mã phương tiện không được để trống.");
            _maPT = value;
        }
    }
    public string TenHang
    {
        get => _tenHang;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên hãng không được để trống.");
            _tenHang = value;
        }
    }
    public int NamSanXuat
    {
        get => _namSanXuat;
        set
        {
            int namHienTai = DateTime.Now.Year;
            if (value <= 1900 || value > namHienTai)
                throw new ArgumentException($"Năm sản xuất phải từ 1900 den {namHienTai}.");
            _namSanXuat = value;
        }
    }
    public decimal GiaGoc
    {
        get => _giaGoc;
        set
        {
            if(value <= 0)
                throw new ArgumentException("Giá gốc phải lớn hơn 0.");
            _giaGoc = value;
        }
    }
    public PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
    {
        MaPT = string.IsNullOrWhiteSpace(maPT) ? "PT000" : maPT;
        TenHang = tenHang;
        NamSanXuat = namSanXuat;
        GiaGoc = giaGoc;
    }
    public abstract decimal TinhGiaLanBanh();
    public virtual string GetInfo()
    {
        return $"Mã PT: {MaPT} | " + 
            $"Hãng: {TenHang} | " + 
            $"Năm SX: {NamSanXuat} | " + 
            $"GiaGoc: {GiaGoc:N0} VNĐ";
    }
}

public class OTo : PhuongTien
{
    private int _soChoNgoi;
    private double _dungTichDongCo;

    public int SoChoNgoi
    {
        get => _soChoNgoi;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0!");
            _soChoNgoi = value;
        }
    }
    public double DungTichDongCo
    {
        get => _dungTichDongCo;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Dung tích động cơ phải lớn hơn 0!");
            _dungTichDongCo = value;
        }
    }
    public OTo(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc,
        int soChoNgoi,
        double dungTichDongCo) : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        SoChoNgoi = soChoNgoi;
        DungTichDongCo = dungTichDongCo;
    }
    public override decimal TinhGiaLanBanh()
    {
        if (SoChoNgoi <= 9)
        {
            return GiaGoc + GiaGoc * 0.12m + GiaGoc * 0.30m;
        }
        return GiaGoc + GiaGoc * 0.10m;
    }
    public override string GetInfo()
    {
        return base.GetInfo()
               + $" | Số chỗ: {SoChoNgoi}"
               + $" | Dung tích động cơ: {DungTichDongCo} L";
    }
}
public class XeMay : PhuongTien
{
    private int _dungTichXyLanh;
    public int DungTichXyLanh
    {
        get => _dungTichXyLanh;
        set
        {
            if(value <= 0)
                throw new ArgumentException("Dung tích xy lanh phải lớn hơn 0!");
            _dungTichXyLanh = value;
        }
    }
    public XeMay(
        string maPT,
        string tenHang,
        int namSanXuat,
        decimal giaGoc,
        int dungTichXyLanh) : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        DungTichXyLanh = dungTichXyLanh;
    }
    public override decimal TinhGiaLanBanh()
    {
        if (DungTichXyLanh < 175)
        {
            return GiaGoc + GiaGoc * 0.02m;
        }
        return GiaGoc + GiaGoc * 0.05m;
    }
    public override string GetInfo()
    {
        return base.GetInfo()
               + $" | Dung tích xy-lanh: {DungTichXyLanh} cc";
    }
}
public class  QuanLyPhuongTien
{
    private List<PhuongTien> danhSach = new List<PhuongTien>();
    public void AddPhuongTien(PhuongTien pt)
    {
        if (pt == null)
            throw new ArgumentNullException(nameof(pt));
        danhSach.Add(pt);
    }
    public void DisplayAll()
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sách phương tiện trống.");
            return;
        }
        Console.WriteLine("Danh sách phương tiện:");
        foreach (PhuongTien pt in danhSach)
        {
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine($"Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ");
            Console.WriteLine(new string('-', 20));
        }
    }
    public PhuongTien FindMaxGiaLanBanh()
    {
        if (danhSach.Count == 0)
            return null;

        return danhSach.OrderByDescending(pt => pt.TinhGiaLanBanh()).First();
    }
    public List<PhuongTien> SearchByName(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
            return new List<PhuongTien>();
        return danhSach.Where(pt => pt.TenHang.Contains(keyword,StringComparison.OrdinalIgnoreCase)).ToList();
    }
}

public class Program
{
    public static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        QuanLyPhuongTien quanLy = new QuanLyPhuongTien();
        int luaChon;
        do
        {
            Console.WriteLine("\nQuản lý phương tiện");
            Console.WriteLine("1. Thêm ô tô");
            Console.WriteLine("2. Thêm xe máy");
            Console.WriteLine("3. Hiển thị tất cả phương tiện");
            Console.WriteLine("4. Tìm phương tiện có giá lăn bánh cao nhất");
            Console.WriteLine("5. Tìm phương tiện theo tên hãng");
            Console.WriteLine("0. Thoát");
            Console.WriteLine();
            Console.Write("Nhập lựa chọn: ");
            int.TryParse(Console.ReadLine(), out luaChon);
            try
            {
                switch (luaChon)
                {
                    case 1:
                        NhapOTo(quanLy);
                        break;
                    case 2:
                        NhapXeMay(quanLy);
                        break;
                    case 3:
                        quanLy.DisplayAll();
                        break;
                    case 4:
                        TimGiaCaoNhat(quanLy);
                        break;
                    case 5:
                        TimTheoTenHang(quanLy);
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

        } while (luaChon != 0);
    }

    static void NhapOTo(QuanLyPhuongTien quanLy)
    {
        Console.WriteLine("\nNhập thông tin ô tô");
        Console.Write("Nhập mã phương tiện: ");
        string maPT = Console.ReadLine() ?? "";
        Console.Write("Nhập tên hãng: ");
        string tenHang = Console.ReadLine() ?? "";
        Console.Write("Nhập năm sản xuất: ");
        int namSanXuat = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập giá gốc: ");
        decimal giaGoc = decimal.Parse(Console.ReadLine()!);
        Console.Write("Nhập số chỗ ngồi: ");
        int soChoNgoi = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập dung tích động cơ (L): ");
        double dungTichDongCo = double.Parse(Console.ReadLine()!);
        OTo oto = new OTo(maPT, tenHang, namSanXuat, giaGoc, soChoNgoi, dungTichDongCo);
        quanLy.AddPhuongTien(oto);
        Console.WriteLine("Đã thêm ô tô thành công!");
    }
    static void NhapXeMay(QuanLyPhuongTien quanLy)
    {
        Console.WriteLine("\nNhập thông tin xe máy");
        Console.Write("Nhập mã phương tiện: ");
        string maPT = Console.ReadLine() ?? "";
        Console.Write("Nhập tên hãng: ");
        string tenHang = Console.ReadLine() ?? "";
        Console.Write("Nhập năm sản xuất: ");
        int namSanXuat = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập giá gốc: ");
        decimal giaGoc = decimal.Parse(Console.ReadLine()!);
        Console.Write("Nhập dung tích xy-lanh (cc): ");
        int dungTichXylanh = int.Parse(Console.ReadLine()!);
        XeMay xeMay = new XeMay(maPT, tenHang, namSanXuat, giaGoc, dungTichXylanh);
        quanLy.AddPhuongTien(xeMay);
        Console.WriteLine("Đã thêm xe máy thành công!");
    }

    static void TimGiaCaoNhat(QuanLyPhuongTien quanLy)
    {
        PhuongTien? pt = quanLy.FindMaxGiaLanBanh();
        Console.WriteLine("\nPhương tiên có giá lăn bánh cao nhất:");

        if (pt == null)
        {
            Console.WriteLine("Danh sách phương tiện đang trống!");
            return;
        }
        Console.WriteLine(pt.GetInfo());
        Console.WriteLine(
            $"Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ"
        );
    }
    static void TimTheoTenHang(QuanLyPhuongTien quanLy)
    {
        Console.Write("\nNhập tên hãng cần tìm: ");
        string keyword = Console.ReadLine() ?? "";
        List<PhuongTien> ketQua =
            quanLy.SearchByName(keyword);
        Console.WriteLine("\nKết quả tìm kiếm");
        if (ketQua.Count == 0)
        {
            Console.WriteLine("Không tìm thấy phương tiện!");
            return;
        }
        foreach (PhuongTien pt in ketQua)
        {
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine(
                $"Giá lăn bánh: {pt.TinhGiaLanBanh():N0} VNĐ"
            );
            Console.WriteLine("--------------------------------");
        }
    }
}