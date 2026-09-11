public class Person
{
    public string Id { get; init; }
    public string FullName { get; set; }
    public int BirthYear { get; set; }
    public Person(string id, string fullName, int birthYear)
    {
        Id = id;
        FullName = fullName;
        BirthYear = birthYear;
    }
    public int GetAge(int currentYear)
    {
        return currentYear - BirthYear;
    }
}
public class Employee : Person
{
    public decimal BaseSalary { get; set; }
    public Employee(string id, string fullName, int birthYear, decimal baseSalary)
        : base(id, fullName, birthYear)
    {
        BaseSalary = baseSalary;
    }
    public virtual decimal CalculateIncome()
    {
        return BaseSalary;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"[NHÂN VIÊN] ID: {Id} | Họ tên: {FullName} | Năm sinh: {BirthYear} | Tuổi: {GetAge(DateTime.Now.Year)} | Lương cơ bản: {BaseSalary:N0} VNĐ | Thu nhập: {CalculateIncome():N0} VNĐ");
    }
}
public sealed class Manager : Employee
{
    public decimal ResponsibilityAllowance { get; set; }
    public Manager(string Id, string fullName, int birthYear, decimal baseSalary, decimal allowance)
        : base(Id, fullName, birthYear, baseSalary)
    {
        ResponsibilityAllowance = allowance;
    }
    public override decimal CalculateIncome()
    {
        return BaseSalary + ResponsibilityAllowance;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"[QUẢN LÝ]   ID: {Id} | Họ tên: {FullName} | Năm sinh: {BirthYear} | Tuổi: {GetAge(DateTime.Now.Year)} | Lương cơ bản: {BaseSalary:N0} VNĐ | Thu nhập: {CalculateIncome():N0} VNĐ (gồm phụ cấp: {ResponsibilityAllowance:N0} VNĐ)");
    }
}
class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<Employee> danhSach = new List<Employee>();
        int luaChon;
        do
        {
            Console.WriteLine("Danh sách lựa chọn");
            Console.WriteLine("1. Thêm nhân viên (Employee)");
            Console.WriteLine("2. Thêm quản lý (Manager)");
            Console.WriteLine("3. Hiển thị danh sách");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            luaChon = int.TryParse(Console.ReadLine(), out int _luaChon) ? _luaChon : -1;
            switch (luaChon)
            {
                case 1:
                    try
                    {
                        Console.Write("Nhập mã định danh: ");
                        string idNV = Console.ReadLine();
                        Console.Write("Nhập họ tên: ");
                        string tenNV = Console.ReadLine();
                        Console.Write("Nhập năm sinh: ");
                        int namSinhNV = int.TryParse(Console.ReadLine(), out int _namSinhNV) ? _namSinhNV : 0;
                        Console.Write("Nhập lương cơ bản: ");
                        decimal luongNV = decimal.TryParse(Console.ReadLine(), out decimal _luongNV) ? _luongNV : 0;

                        Employee nv = new Employee(idNV, tenNV, namSinhNV, luongNV);
                        danhSach.Add(nv);
                        Console.WriteLine("Thêm nhân viên thành công.");
                        nv.DisplayInfo();
                        Console.WriteLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Nhập mã định danh: ");
                        string idQL = Console.ReadLine();
                        Console.Write("Nhập họ tên: ");
                        string tenQL = Console.ReadLine();
                        Console.Write("Nhập năm sinh: ");
                        int namSinhQL = int.TryParse(Console.ReadLine(), out int _namSinhQL) ? _namSinhQL : 0;
                        Console.Write("Nhập lương cơ bản: ");
                        decimal luongQL = decimal.TryParse(Console.ReadLine(), out decimal _luongQL) ? _luongQL : 0;
                        Console.Write("Nhập phụ cấp trách nhiệm: ");
                        decimal phuCap = decimal.TryParse(Console.ReadLine(), out decimal _phuCap) ? _phuCap : 0;

                        Manager ql = new Manager(idQL, tenQL, namSinhQL, luongQL, phuCap);
                        danhSach.Add(ql);
                        Console.WriteLine("Thêm quản lý thành công.");
                        ql.DisplayInfo();
                        Console.WriteLine();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Lỗi: {ex.Message}");
                    }
                    break;
                case 3:
                    if (danhSach.Count == 0)
                    {
                        Console.WriteLine("Danh sách trống.\n");
                    }
                    else
                    {
                        Console.WriteLine("--- DANH SÁCH NHÂN SỰ ---");
                        foreach (Employee nguoi in danhSach)
                        {
                            nguoi.DisplayInfo(); // Đa hình: tự gọi đúng phiên bản Employee/Manager
                        }
                        Console.WriteLine();
                    }
                    break;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
        while (luaChon != 0);
    }
}