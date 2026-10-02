namespace Bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadServices();
            LoadCategories();
        }
        private List<ServiceItem> services = new List<ServiceItem>();

        private void LoadServices()
        {
            services.Add(new ServiceItem
            {
                Category = "Khám bệnh",
                Name = "Khám tổng quát",
                Price = 200000
            });

            services.Add(new ServiceItem
            {
                Category = "Khám bệnh",
                Name = "Khám chuyên khoa",
                Price = 300000
            });

            services.Add(new ServiceItem
            {
                Category = "Khám bệnh",
                Name = "Tái khám",
                Price = 100000
            });

            services.Add(new ServiceItem
            {
                Category = "Xét nghiệm",
                Name = "Xét nghiệm máu",
                Price = 150000
            });

            services.Add(new ServiceItem
            {
                Category = "Xét nghiệm",
                Name = "Xét nghiệm nước tiểu",
                Price = 100000
            });

            services.Add(new ServiceItem
            {
                Category = "Chụp X-Quang",
                Name = "X-Quang phổi",
                Price = 250000
            });

            services.Add(new ServiceItem
            {
                Category = "Chụp X-Quang",
                Name = "X-Quang xương",
                Price = 300000
            });

            services.Add(new ServiceItem
            {
                Category = "Vắc-xin",
                Name = "Vắc-xin cúm",
                Price = 350000
            });

            services.Add(new ServiceItem
            {
                Category = "Vắc-xin",
                Name = "Vắc-xin viêm gan B",
                Price = 400000
            });
        }
        private void LoadCategories()
        {
            cboCategory.Items.Clear();

            cboCategory.Items.Add("Khám bệnh");
            cboCategory.Items.Add("Xét nghiệm");
            cboCategory.Items.Add("Chụp X-Quang");
            cboCategory.Items.Add("Vắc-xin");

            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

            if (cboCategory.SelectedItem == null)
                return;

            string category = cboCategory.SelectedItem.ToString();

            foreach (ServiceItem service in services)
            {
                if (service.Category == category)
                {
                    lstAvailableServices.Items.Add(service);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem == null)
            {
                return;
            }

            ServiceItem service =
                (ServiceItem)lstAvailableServices.SelectedItem;

            lstSelectedServices.Items.Add(service);

            lstAvailableServices.Items.Remove(service);

            CalculateTotal();
        }

        private void lstAvailableServices_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem == null)
            {
                return;
            }

            ServiceItem service =
                (ServiceItem)lstSelectedServices.SelectedItem;

            lstSelectedServices.Items.Remove(service);

            lstAvailableServices.Items.Add(service);

            CalculateTotal();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();

            cboCategory_SelectedIndexChanged(null, null);

            CalculateTotal();
        }
        private void CalculateTotal()
        {
            decimal subtotal = 0;

            foreach (ServiceItem service in lstSelectedServices.Items)
            {
                subtotal += service.Price;
            }

            decimal discountRate = GetDiscountRate(subtotal);

            decimal discountAmount = subtotal * discountRate / 100;

            decimal total = subtotal - discountAmount;

            lblSubtotal.Text = $"Tổng tiền chưa giảm: {subtotal:N0} VND";
            lblDiscount.Text = $"Tỷ lệ chiết khấu (%): {discountRate:N0}%";
            lblTotal.Text = $"Thành tiền thanh toán: {total:N0} VND";
        }
        private decimal GetDiscountRate(decimal subtotal)
        {
            if (subtotal >= 1000000)
            {
                return 10;
            }

            if (subtotal >= 500000)
            {
                return 5;
            }

            return 0;
        }
    }
}
