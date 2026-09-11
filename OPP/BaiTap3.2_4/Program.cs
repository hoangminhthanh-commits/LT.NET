public interface IPayable
{
    bool ProcessPayment(decimal amount);
}
public interface IRefundable
{
    bool ProcessRefund(decimal amount, string reason);
}
public abstract class PaymentGateway
{
    public string TransactionId { get; init; }
    public DateTime CreationDate { get; init; }
    public string Status { get; protected set; }
    protected PaymentGateway(string transactionId)
    {
        if (string.IsNullOrWhiteSpace(transactionId))
            throw new ArgumentException("Mã giao dịch không được để trống.");

        TransactionId = transactionId;
        CreationDate = DateTime.Now;
        Status = "Pending";
    }
    public abstract void ValidateConnection();
    public virtual void LogTransaction(string message)
    {
        Console.WriteLine($"[LOG {CreationDate:dd/MM/yyyy HH:mm:ss}] Giao dịch {TransactionId}: {message}");
    }
}
public class MomoPayment : PaymentGateway, IPayable, IRefundable
{
    public string PhoneNumber { get; set; }
    public MomoPayment(string transactionId, string phoneNumber)
        : base(transactionId)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("Số điện thoại không được để trống.");
        PhoneNumber = phoneNumber;
    }
    public override void ValidateConnection()
    {
        Console.WriteLine($"Đang kiểm tra kết nối API MoMo (số điện thoại: {PhoneNumber})...");
        Console.WriteLine("Kết nối API MoMo thành công.");
    }
    public bool ProcessPayment(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Số tiền thanh toán phải lớn hơn 0.");
        if (string.IsNullOrWhiteSpace(PhoneNumber))
        {
            Status = "Failed";
            return false;
        }
        Status = "Success";
        LogTransaction($"Thanh toán {amount:N0} VNĐ qua MoMo thành công.");
        return true;
    }
    public bool ProcessRefund(decimal amount, string reason)
    {
        if (Status != "Success")
        {
            Console.WriteLine("Chỉ hoàn tiền được khi giao dịch đã thanh toán thành công.");
            return false;
        }
        if (amount <= 0)
            throw new ArgumentException("Số tiền hoàn phải lớn hơn 0.");
        Status = "Refunded";
        LogTransaction($"Hoàn tiền {amount:N0} VNĐ. Lý do: {reason}");
        return true;
    }
}
class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        MomoPayment giaoDich = null;
        int luaChon;
        do
        {
            Console.WriteLine("Danh sách lựa chọn");
            Console.WriteLine("1. Tạo giao dịch MoMo");
            Console.WriteLine("2. Kiểm tra kết nối API");
            Console.WriteLine("3. Thanh toán (qua IPayable)");
            Console.WriteLine("4. Hoàn tiền (qua IRefundable)");
            Console.WriteLine("5. Xem trạng thái giao dịch");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.TryParse(Console.ReadLine(), out int _luaChon) ? _luaChon : -1;
            switch (luaChon)
            {
                case 1:
                    try
                    {
                        Console.Write("Nhập mã giao dịch: ");
                        string maGD = Console.ReadLine();
                        Console.Write("Nhập số điện thoại MoMo: ");
                        string sdt = Console.ReadLine();
                        giaoDich = new MomoPayment(maGD, sdt);
                        Console.WriteLine("Tạo giao dịch thành công.");
                        Console.WriteLine($"Mã: {giaoDich.TransactionId} | Ngày tạo: {giaoDich.CreationDate:dd/MM/yyyy HH:mm:ss} | Trạng thái: {giaoDich.Status}\n");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 2:
                    if (giaoDich == null)
                    {
                        Console.WriteLine("Chưa tạo giao dịch. Hãy chọn mục 1 trước.\n");
                        break;
                    }
                    giaoDich.ValidateConnection();
                    Console.WriteLine();
                    break;
                case 3:
                    if (giaoDich == null)
                    {
                        Console.WriteLine("Chưa tạo giao dịch. Hãy chọn mục 1 trước.\n");
                        break;
                    }
                    try
                    {
                        IPayable boThanhToan = (IPayable)giaoDich;
                        Console.Write("Nhập số tiền thanh toán: ");
                        decimal soTienThanhToan = decimal.TryParse(Console.ReadLine(), out decimal _sttt) ? _sttt : 0;
                        if (boThanhToan.ProcessPayment(soTienThanhToan))
                            Console.WriteLine($"Thanh toán thành công. Trạng thái: {giaoDich.Status}\n");
                        else
                            Console.WriteLine($"Thanh toán thất bại. Trạng thái: {giaoDich.Status}\n");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 4:
                    if (giaoDich == null)
                    {
                        Console.WriteLine("Chưa tạo giao dịch. Hãy chọn mục 1 trước.\n");
                        break;
                    }
                    try
                    {
                        IRefundable boHoanTien = (IRefundable)giaoDich;
                        Console.Write("Nhập số tiền hoàn: ");
                        decimal soTienHoan = decimal.TryParse(Console.ReadLine(), out decimal _sth) ? _sth : 0;
                        Console.Write("Nhập lý do hoàn tiền: ");
                        string lyDo = Console.ReadLine();

                        if (boHoanTien.ProcessRefund(soTienHoan, lyDo))
                            Console.WriteLine($"Hoàn tiền thành công. Trạng thái: {giaoDich.Status}\n");
                        else
                            Console.WriteLine($"Hoàn tiền thất bại. Trạng thái: {giaoDich.Status}\n");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 5:
                    if (giaoDich == null)
                    {
                        Console.WriteLine("Chưa tạo giao dịch. Hãy chọn mục 1 trước.\n");
                        break;
                    }
                    Console.WriteLine($"Mã: {giaoDich.TransactionId} | Ngày tạo: {giaoDich.CreationDate:dd/MM/yyyy HH:mm:ss} | Trạng thái: {giaoDich.Status}");
                    giaoDich.LogTransaction("In thông tin giao dịch theo yêu cầu.");
                    Console.WriteLine();
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.\n");
                    break;
            }
        } while (luaChon != 0);
    }
}