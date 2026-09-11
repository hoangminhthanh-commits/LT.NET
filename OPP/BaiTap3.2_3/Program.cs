public class DiscountCalculator
{
    public static decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount * 0.95m;
    }
    public static decimal ApplyDiscount(decimal totalAmount, double percentage)
    {
        if (percentage < 0 || percentage > 100)
            throw new ArgumentException("Phần trăm giảm giá phải từ 0 đến 100.");
        return totalAmount * (decimal)(1 - percentage / 100);
    }
    public static decimal ApplyDiscount(decimal totalAmount, decimal fixedVoucher, decimal minimumOrder)
    {
        if (totalAmount >= minimumOrder)
            return totalAmount - fixedVoucher;
        return totalAmount;
    }
}
public class DeliveryService
{
    public string OrderId { get; set; }
    public double DistanceKm { get; set; }
    public DeliveryService(string ordersId, double distanceKm)
    {
        OrderId = ordersId;
        DistanceKm = distanceKm;
    }
    public virtual decimal CalculateDeliveryFee()
    {
        return (decimal)DistanceKm * 5000;
    }
}
public class ExpressDelivery : DeliveryService
{
    public ExpressDelivery(string ordersId, double distanceKm) : base(ordersId, distanceKm)
    {
    }
    public override decimal CalculateDeliveryFee()
    {
        return base.CalculateDeliveryFee() * 1.5m + 20000m;
    }
}
public class EcoDelivery : DeliveryService
{
    public EcoDelivery(string ordersId, double distanceKm) : base(ordersId, distanceKm)
    {
    }
    public override decimal CalculateDeliveryFee()
    {
        if(DistanceKm > 10)
            return base.CalculateDeliveryFee() * 0.9m;
        return base.CalculateDeliveryFee();
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        List<DeliveryService> donVanChuyen = new List<DeliveryService>();
        int luaChon;
        do
        {
            Console.WriteLine("Danh sách lựa chọn");
            Console.WriteLine("1. Tạo đơn hàng vận chuyển");
            Console.WriteLine("2. Hiển thị danh sách đơn hàng & phí vận chuyển");
            Console.WriteLine("3. Tính giá sau giảm giá cho đơn hàng");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.TryParse(Console.ReadLine(), out int _luaChon) ? _luaChon : -1;
            switch (luaChon)
            {
                case 1:
                    try
                    {
                        Console.Write("Nhập mã đơn hàng: ");
                        string orderId = Console.ReadLine();
                        Console.Write("Nhập quãng đường giao (km): ");
                        double km = double.TryParse(Console.ReadLine(), out double _km) ? _km : 0;
                        Console.WriteLine("Chọn loại dịch vụ: 1. Giao thường | 2. Giao hỏa tốc | 3. Giao tiết kiệm");
                        Console.Write("Nhập loại dịch vụ: ");
                        int loaiDichVu = int.TryParse(Console.ReadLine(), out int _loaiDichVu) ? _loaiDichVu : -1;

                        if (loaiDichVu < 1 || loaiDichVu > 3)
                        {
                            Console.WriteLine("Loại dịch vụ không hợp lệ.\n");
                            break;
                        }

                        DeliveryService donMoi;
                        switch (loaiDichVu)
                        {
                            case 2:
                                donMoi = new ExpressDelivery(orderId, km);
                                break;
                            case 3:
                                donMoi = new EcoDelivery(orderId, km);
                                break;
                            default:
                                donMoi = new DeliveryService(orderId, km);
                                break;
                        }
                        donVanChuyen.Add(donMoi);
                        Console.WriteLine("Tạo đơn hàng thành công.");
                        Console.WriteLine($"Mã: {donMoi.OrderId} | Loại: {donMoi.GetType().Name} | Phí vận chuyển: {donMoi.CalculateDeliveryFee():N0} VNĐ\n");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 2:
                    if (donVanChuyen.Count == 0)
                    {
                        Console.WriteLine("Danh sách đơn hàng trống.\n");
                    }
                    else
                    {
                        Console.WriteLine("--- DANH SÁCH ĐƠN HÀNG VẬN CHUYỂN ---");
                        Console.WriteLine($"{"Mã ĐH",-8} | {"Quãng đường",10} | {"Loại dịch vụ",-16} | {"Phí vận chuyển",15}");
                        foreach (DeliveryService don in donVanChuyen)
                        {
                            Console.WriteLine($"{don.OrderId,-8} | {don.DistanceKm,9:0.0} km | {don.GetType().Name,-16} | {don.CalculateDeliveryFee(),12:N0} VNĐ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                     Console.Write("Nhập mã đơn hàng cần áp dụng giảm giá: ");
                    string idGiamGia = Console.ReadLine();
                    int viTri = donVanChuyen.FindIndex(d => d.OrderId == idGiamGia);
                    if (viTri < 0)
                    {
                        Console.WriteLine("Không tìm thấy đơn hàng.\n");
                        break;
                    }

                    Console.WriteLine($"Phí vận chuyển hiện tại ({donVanChuyen[viTri].GetType().Name}): {donVanChuyen[viTri].CalculateDeliveryFee():N0} VNĐ");
                    Console.Write("Nhập tổng giá trị đơn hàng (VNĐ): ");
                    decimal tongTien = decimal.TryParse(Console.ReadLine(), out decimal _tongTien) ? _tongTien : 0;

                    Console.WriteLine("Chọn hình thức giảm giá:");
                    Console.WriteLine("1. Giảm mặc định 5%");
                    Console.WriteLine("2. Giảm theo phần trăm tùy biến");
                    Console.WriteLine("3. Áp dụng voucher tiền mặt");
                    Console.Write("Nhập lựa chọn: ");
                    int chonGiamGia = int.TryParse(Console.ReadLine(), out int _chonGiamGia) ? _chonGiamGia : -1;

                    try
                    {
                        switch (chonGiamGia)
                        {
                            case 1:
                                // Compiler chọn overload 1 tham số ngay lúc biên dịch
                                Console.WriteLine($"Giá sau giảm mặc định 5%: {DiscountCalculator.ApplyDiscount(tongTien):N0} VNĐ\n");
                                break;
                            case 2:
                                Console.Write("Nhập phần trăm giảm giá (0 - 100): ");
                                double phanTram = double.TryParse(Console.ReadLine(), out double _phanTram) ? _phanTram : -1;
                                Console.WriteLine($"Giá sau giảm {phanTram}%: {DiscountCalculator.ApplyDiscount(tongTien, phanTram):N0} VNĐ\n");
                                break;
                            case 3:
                                Console.Write("Nhập giá trị voucher (VNĐ): ");
                                decimal voucher = decimal.TryParse(Console.ReadLine(), out decimal _voucher) ? _voucher : 0;
                                Console.Write("Nhập giá trị đơn tối thiểu để áp voucher (VNĐ): ");
                                decimal toiThieu = decimal.TryParse(Console.ReadLine(), out decimal _toiThieu) ? _toiThieu : 0;

                                decimal giaSauGiam = DiscountCalculator.ApplyDiscount(tongTien, voucher, toiThieu);
                                if (tongTien >= toiThieu)
                                    Console.WriteLine($"Áp voucher thành công. Giá sau giảm: {giaSauGiam:N0} VNĐ\n");
                                else
                                    Console.WriteLine($"Đơn không đủ điều kiện áp voucher (cần tối thiểu {toiThieu:N0} VNĐ). Giá giữ nguyên: {giaSauGiam:N0} VNĐ\n");
                                break;
                            default:
                                Console.WriteLine("Hình thức giảm giá không hợp lệ.\n");
                                break;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.\n");
                    break;
            }
        } while(luaChon != 0);
    }
}