namespace DatHangFastFood
{
    public partial class Form1 : Form
    {
        private void LoadMenu()
        {
            lstMenu.Items.Add(new Food
            {
                Name = "Hamburger",
                Price = 50000
            });

            lstMenu.Items.Add(new Food
            {
                Name = "Pizza",
                Price = 120000
            });

            lstMenu.Items.Add(new Food
            {
                Name = "Gà Rán",
                Price = 35000
            });

            lstMenu.Items.Add(new Food
            {
                Name = "Pepsi",
                Price = 15000
            });
        }
        class Food
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public override string ToString()
            {
                return Name + " - " + Price.ToString("N0") + " VNĐ";
            }
        }
        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (Food food in lstSelected.Items)
            {
                total += food.Price;
            }

            lblTotal.Text = "Tổng tiền: " + total.ToString("N0") + " VNĐ";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);

                lstMenu.Items.Remove(lstMenu.SelectedItem);

                UpdateTotal();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);

                UpdateTotal();
            }
        }
        public Form1()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void grpSelected_Enter(object sender, EventArgs e)
        {

        }

        private void lstSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
