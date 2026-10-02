namespace Bai5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Employee> employees = new List<Employee>();
        private void CreateEmployees()
        {
            employees.Add(new Employee(
                "NV001",
                "Nguyễn Văn An",
                "Lập trình viên",
                new DateTime(2022, 3, 15),
                "Phòng Kỹ thuật",
                "Nhóm Dev"
            ));

            employees.Add(new Employee(
                "NV002",
                "Trần Văn Bình",
                "Lập trình viên",
                new DateTime(2023, 5, 10),
                "Phòng Kỹ thuật",
                "Nhóm Dev"
            ));

            employees.Add(new Employee(
                "NV003",
                "Lê Thị Hoa",
                "Tester",
                new DateTime(2021, 8, 20),
                "Phòng Kỹ thuật",
                "Nhóm Tester"
            ));

            employees.Add(new Employee(
                "NV004",
                "Phạm Văn Nam",
                "Tester",
                new DateTime(2024, 1, 12),
                "Phòng Kỹ thuật",
                "Nhóm Tester"
            ));

            employees.Add(new Employee(
                "NV005",
                "Hoàng Minh Đức",
                "Nhân viên Sales",
                new DateTime(2022, 7, 5),
                "Phòng Kinh doanh",
                "Nhóm Sales"
            ));

            employees.Add(new Employee(
                "NV006",
                "Nguyễn Thị Lan",
                "Nhân viên Sales",
                new DateTime(2023, 9, 18),
                "Phòng Kinh doanh",
                "Nhóm Sales"
            ));

            employees.Add(new Employee(
                "NV007",
                "Vũ Thị Mai",
                "Marketing",
                new DateTime(2021, 11, 25),
                "Phòng Kinh doanh",
                "Nhóm Marketing"
            ));
        }
        private void CreateTree()
        {
            tvDepartments.Nodes.Clear();

            TreeNode companyNode = new TreeNode("Công ty");
            companyNode.Tag = "COMPANY";

            TreeNode technicalNode = new TreeNode("Phòng Kỹ thuật");
            technicalNode.Tag = "Phòng Kỹ thuật";
            technicalNode.ImageIndex = 1;
            technicalNode.SelectedImageIndex = 1;

            TreeNode devNode = new TreeNode("Nhóm Dev");
            devNode.Tag = "Nhóm Dev";
            devNode.ImageIndex = 2;
            devNode.SelectedImageIndex = 2;

            TreeNode testerNode = new TreeNode("Nhóm Tester");
            testerNode.Tag = "Nhóm Tester";
            testerNode.ImageIndex = 2;
            testerNode.SelectedImageIndex = 2;

            technicalNode.Nodes.Add(devNode);
            technicalNode.Nodes.Add(testerNode);

            TreeNode businessNode = new TreeNode("Phòng Kinh doanh");
            businessNode.Tag = "Phòng Kinh doanh";
            businessNode.ImageIndex = 1;
            businessNode.SelectedImageIndex = 1;

            TreeNode salesNode = new TreeNode("Nhóm Sales");
            salesNode.Tag = "Nhóm Sales";
            salesNode.ImageIndex = 2;
            salesNode.SelectedImageIndex = 2;

            TreeNode marketingNode = new TreeNode("Nhóm Marketing");
            marketingNode.Tag = "Nhóm Marketing";
            marketingNode.ImageIndex = 2;
            marketingNode.SelectedImageIndex = 2;   

            businessNode.Nodes.Add(salesNode);
            businessNode.Nodes.Add(marketingNode);

            companyNode.Nodes.Add(technicalNode);
            companyNode.Nodes.Add(businessNode);

            tvDepartments.Nodes.Add(companyNode);

            companyNode.Expand();
        }
        private void SetupListView()
        {
            lsvEmployees.View = View.Details;

            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.HideSelection = false;

            lsvEmployees.TileSize = new Size(400, 70);

            lsvEmployees.Columns.Clear();

            lsvEmployees.Columns.Add("Mã NV", 100);
            lsvEmployees.Columns.Add("Họ Tên", 180);
            lsvEmployees.Columns.Add("Chức vụ", 180);
            lsvEmployees.Columns.Add("Ngày vào làm", 120);
        }

        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsvEmployees.Items.Clear();

            string selectedValue = e.Node.Tag?.ToString();

            if (selectedValue == null)
                return;

            foreach (Employee employee in employees)
            {
                bool match = false;

                if (selectedValue == "COMPANY")
                {
                    match = true;
                }
                else if (employee.Department == selectedValue)
                {
                    match = true;
                }
                else if (employee.Group == selectedValue)
                {
                    match = true;
                }

                if (match)
                {
                    ListViewItem item = new ListViewItem(employee.MaNV);
                    item.ImageIndex = 3;

                    item.SubItems.Add(employee.HoTen);
                    item.SubItems.Add(employee.ChucVu);
                    item.SubItems.Add(
                        employee.NgayVaoLam.ToString("dd/MM/yyyy")
                    );

                    lsvEmployees.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboViewMode.Items.Add("Details");
            cboViewMode.Items.Add("LargeIcon");
            cboViewMode.Items.Add("SmallIcon");
            cboViewMode.Items.Add("List");
            cboViewMode.Items.Add("Tile");

            cboViewMode.SelectedIndex = 0;

            CreateEmployees();
            CreateTree();
            SetupListView();
        }

        private void cboViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboViewMode.SelectedItem?.ToString())
            {
                case "Details":
                    lsvEmployees.View = View.Details;
                    break;

                case "LargeIcon":
                    lsvEmployees.View = View.LargeIcon;
                    break;

                case "SmallIcon":
                    lsvEmployees.View = View.SmallIcon;
                    break;

                case "List":
                    lsvEmployees.View = View.List;
                    break;

                case "Tile":
                    lsvEmployees.View = View.Tile;
                    break;
            }
        }
    }
}
