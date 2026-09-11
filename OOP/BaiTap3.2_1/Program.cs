using System;
public class BankAccount
{
    private static long _nextAccountNumber = 1000000001;
    public long AccountNumber { get; init; }
    public string AccountHolder { get; private set; }
    private decimal _balance;
    public decimal Balance
    {
        get
        {
            return _balance;
        }
    }
    public BankAccount(string accountHolder, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(accountHolder))
        {
            throw new ArgumentException("Tên chủ tài khoản không được để trống.\n");
        }
        if (initialBalance < 50000 || string.IsNullOrWhiteSpace(initialBalance.ToString()))
        {
            throw new ArgumentException("Số dư ban đầu không được nhỏ hơn 50.000 VNĐ.\n");
        }
        AccountNumber = _nextAccountNumber++;
        AccountHolder = accountHolder;
        _balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0 || string.IsNullOrWhiteSpace(amount.ToString()))
        {
            throw new ArgumentException("Số tiền gửi phải lớn hơn 0.\n");
        }
        _balance += amount;
    }
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance - 50000 || string.IsNullOrWhiteSpace(amount.ToString()))
        {
            return false;
        }
        _balance -= amount;
        return true;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Số tài khoản: {AccountNumber}");
        Console.WriteLine($"Tên chủ tài khoản: {AccountHolder}");
        Console.WriteLine($"Số dư hiện tại: {_balance:N0} VNĐ");
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        int luaChon;
        List<BankAccount> TaiKhoan = new List<BankAccount>();
        do
        {
            Console.WriteLine("Danh sách lựa chọn");
            Console.WriteLine("1. Tạo tài khoản ngân hàng");
            Console.WriteLine("2. Nạp tiền vào tài khoản");
            Console.WriteLine("3. Rút tiền từ tài khoản");
            Console.WriteLine("4. Hiển thị thông tin tài khoản");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.TryParse(Console.ReadLine(), out int _luaChon) ? _luaChon : -1;
            switch (luaChon)
            {
                case 1:
                    try
                    {
                        Console.Write($"Nhập tên chủ tài khoản: ");
                        string tenChuTaiKhoan = Console.ReadLine();
                        Console.Write($"Nhập số dư ban đầu cho tài khoản: ");
                        decimal soDuBanDau = decimal.TryParse(Console.ReadLine(), out decimal _soDuBanDau) ? _soDuBanDau : 0;
                        BankAccount taiKhoanMoi = new BankAccount(tenChuTaiKhoan, soDuBanDau);
                        TaiKhoan.Add(taiKhoanMoi);
                        Console.WriteLine("Tạo tài khoản thành công.\n");
                        taiKhoanMoi.DisplayInfo();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 2:
                    Console.Write("Nhập số tài khoản để nạp tiền: ");
                    long soTaiKhoanNapTien = long.TryParse(Console.ReadLine(), out long _soTaiKhoanNapTien) ? _soTaiKhoanNapTien : 0;
                    int timKiemNapTien = TaiKhoan.FindIndex(t => t.AccountNumber == soTaiKhoanNapTien);
                    if (timKiemNapTien < 0)
                    {
                        Console.WriteLine("Không tìm thấy tài khoản.\n");
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Nhap số tiền muốn nạp: ");
                            decimal soTienNap = decimal.TryParse(Console.ReadLine(), out decimal _soTienNap) ? _soTienNap : 0;
                            TaiKhoan[timKiemNapTien].Deposit(soTienNap);
                            Console.WriteLine("Nạp tiền thành công.");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Lỗi: {ex.Message}");
                        }
                    }
                    break;
                case 3:
                    Console.Write("Nhập số tài khoản để rút tiền: ");
                    long soTaiKhoanRutTien = long.TryParse(Console.ReadLine(), out long _soTaiKhoanRutTien) ? _soTaiKhoanRutTien : 0;
                    int timKiemRutTien = TaiKhoan.FindIndex(t => t.AccountNumber == soTaiKhoanRutTien);
                    if (timKiemRutTien < 0)
                    {
                        Console.WriteLine("Không tìm thấy tài khoản.\n");
                    }
                    else
                    {
                        try
                        {
                            Console.Write("Nhập số tiền muốn rút: ");
                            decimal soTienRut = decimal.TryParse(Console.ReadLine(), out decimal _soTienRut) ? _soTienRut : 0;
                            if (TaiKhoan[timKiemRutTien].Withdraw(soTienRut))
                            {
                                Console.WriteLine("Rút tiền thành công.\n");
                            }
                            else if(soTienRut <= 0)
                            {
                                throw new ArgumentException("Số tiền rút phải lớn hơn 0.\n");
                            }
                            else
                            {
                                throw new ArgumentException("Số dư tài khoản không được nhỏ hơn 50.000 VNĐ.\n");
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Lỗi: {ex.Message}");
                        }
                    }
                    break;
                case 4:
                    Console.Write("Nhập số tài khoản để hiển thị thông tin: ");
                    long soTaiKhoanHienThi = long.TryParse(Console.ReadLine(), out long _soTaiKhoanHienThi) ? _soTaiKhoanHienThi : 0;
                    int timKiemHienThi = TaiKhoan.FindIndex(t => t.AccountNumber == soTaiKhoanHienThi);
                    if (timKiemHienThi < 0)
                    {
                        Console.WriteLine("Không tìm thấy tài khoản.\n");
                    }
                    else
                    {
                        TaiKhoan[timKiemHienThi].DisplayInfo();
                    }
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.\n");
                    break;
            }
        } while (luaChon != 0);
        Console.ReadKey();
    }
}
