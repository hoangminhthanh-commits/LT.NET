using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace BaiTap2
{
    public partial class FormMain : Form
    {
        private BindingList<BookModel> books = new BindingList<BookModel>();
        private string currentCoverPath = "";
        public FormMain()
        {
            InitializeComponent();

            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataSource = books;

            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.AllowUserToAddRows = false;

            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;

            numQuantity.Minimum = 0;
            numQuantity.Maximum = 1000000;

            numPrice.Minimum = 0;
            numPrice.Maximum = 1000000000;

            timer.Interval = 1000;
            timer.Start();

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            lblTotalBooks.Text = "Tổng đầu sách: " + books.Count;

            decimal total = books.Sum(b => b.TotalValue);

            lblTotalValue.Text = "Tổng giá trị kho: " + total.ToString("N0") + " VNĐ";

            lblCurrentTime.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void btnLoadCover_Click(object sender, EventArgs e)
        {
            ofdCover.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            ofdCover.Title = "Chọn ảnh bìa sách";

            if (ofdCover.ShowDialog() == DialogResult.OK)
            {
                currentCoverPath = ofdCover.FileName;

                try
                {
                    using (Image img = Image.FromFile(currentCoverPath))
                    {
                        if (picBookCover.Image != null)
                        {
                            picBookCover.Image.Dispose();
                        }

                        picBookCover.Image = new Bitmap(img);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở ảnh: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (books.Any(b =>
                b.BookId.Equals(
                    txtBookId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sách đã tồn tại.");
                return;
            }

            BookModel book = new BookModel
            {
                BookId = txtBookId.Text.Trim(),
                BookName = txtBookName.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Quantity = (int)numQuantity.Value,
                Price = numPrice.Value,
                CoverPath = currentCoverPath
            };

            books.Add(book);

            UpdateStatus();
            ClearInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null ||
        dgvBooks.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.");
                return;
            }

            if (!ValidateInput())
                return;

            BookModel book = dgvBooks.CurrentRow.DataBoundItem as BookModel;

            if (book == null)
                return;

            if (books.Any(b =>
                b != book &&
                b.BookId.Equals(
                    txtBookId.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sách đã được sử dụng.");
                return;
            }

            book.BookId = txtBookId.Text.Trim();
            book.BookName = txtBookName.Text.Trim();
            book.Author = txtAuthor.Text.Trim();
            book.Category = txtCategory.Text.Trim();
            book.Quantity = (int)numQuantity.Value;
            book.Price = numPrice.Value;
            book.CoverPath = currentCoverPath;

            dgvBooks.Refresh();
            UpdateStatus();

            MessageBox.Show("Cập nhật sách thành công.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null || dgvBooks.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            BookModel book = dgvBooks.CurrentRow.DataBoundItem as BookModel;

            if (book == null)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa sách " + book.BookName + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                books.Remove(book);

                UpdateStatus();
                ClearInput();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sách.");
                txtBookId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sách.");
                txtBookName.Focus();
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();

            numQuantity.Value = numQuantity.Minimum;
            numPrice.Value = numPrice.Minimum;

            currentCoverPath = "";

            if (picBookCover.Image != null)
            {
                picBookCover.Image.Dispose();
                picBookCover.Image = null;
            }

            dgvBooks.ClearSelection();
            txtBookId.Focus();
        }
        private void dgvBooks_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null ||
                dgvBooks.CurrentRow.DataBoundItem == null)
                return;

            BookModel book =
                dgvBooks.CurrentRow.DataBoundItem as BookModel;

            if (book == null)
                return;

            txtBookId.Text = book.BookId;
            txtBookName.Text = book.BookName;
            txtAuthor.Text = book.Author;
            txtCategory.Text = book.Category;

            numQuantity.Value = Math.Min(
                numQuantity.Maximum,
                Math.Max(numQuantity.Minimum, book.Quantity));

            numPrice.Value = Math.Min(
                numPrice.Maximum,
                Math.Max(numPrice.Minimum, book.Price));

            currentCoverPath = book.CoverPath ?? "";

            if (picBookCover.Image != null)
            {
                picBookCover.Image.Dispose();
                picBookCover.Image = null;
            }

            if (!string.IsNullOrWhiteSpace(currentCoverPath) &&
                File.Exists(currentCoverPath))
            {
                using (Image img = Image.FromFile(currentCoverPath))
                {
                    picBookCover.Image = new Bitmap(img);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvBooks.DataSource = books;
                return;
            }

            var result = books.Where(b =>
                b.BookId.Contains(keyword) ||
                b.BookName.IndexOf(
                    keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                b.Author.IndexOf(
                    keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                b.Category.IndexOf(
                    keyword, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            dgvBooks.DataSource = new BindingList<BookModel>(result);
        }
        private string CsvEscape(string value)
        {
            value = value ?? "";
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
        private void SaveCSV()
        {
            sfdCSV.Filter = "CSV Files (*.csv)|*.csv";
            sfdCSV.Title = "Lưu danh sách sách";
            sfdCSV.FileName = "Books.csv";

            if (sfdCSV.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (StreamWriter writer = new StreamWriter(
                    sfdCSV.FileName, false, new UTF8Encoding(true)))
                {
                    writer.WriteLine(
                        "BookId,BookName,Author,Category,Quantity,Price,CoverPath");

                    foreach (BookModel b in books)
                    {
                        string[] fields =
                        {
                    b.BookId,
                    b.BookName,
                    b.Author,
                    b.Category,
                    b.Quantity.ToString(),
                    b.Price.ToString(CultureInfo.InvariantCulture),
                    b.CoverPath
                };

                        writer.WriteLine(
                            string.Join(",", fields.Select(CsvEscape)));
                    }
                }

                MessageBox.Show("Xuất CSV thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }

        private void mnuSaveCSV_Click(object sender, EventArgs e)
        {
            SaveCSV();
        }
        private string[] ParseCSVLine(string line)
        {
            var fields = new System.Collections.Generic.List<string>();
            var field = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (inQuotes &&
                        i + 1 < line.Length &&
                        line[i + 1] == '"')
                    {
                        field.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(field.ToString());
                    field.Clear();
                }
                else
                {
                    field.Append(c);
                }
            }

            fields.Add(field.ToString());
            return fields.ToArray();
        }
        private void OpenCSV()
        {
            ofdCSV.Filter = "CSV Files (*.csv)|*.csv";
            ofdCSV.Title = "Mở danh sách sách";

            if (ofdCSV.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var importedBooks = new BindingList<BookModel>();

                using (StreamReader reader = new StreamReader(
                    ofdCSV.FileName, Encoding.UTF8, true))
                {
                    string line;
                    bool isFirstLine = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        if (isFirstLine)
                        {
                            isFirstLine = false;

                            if (line.StartsWith("BookId,"))
                                continue;
                        }

                        string[] f = ParseCSVLine(line);

                        if (f.Length < 7)
                            continue;

                        int quantity;
                        decimal price;

                        if (!int.TryParse(f[4], out quantity) ||
                            !decimal.TryParse(
                                f[5],
                                NumberStyles.Number,
                                CultureInfo.InvariantCulture,
                                out price))
                            continue;

                        importedBooks.Add(new BookModel
                        {
                            BookId = f[0],
                            BookName = f[1],
                            Author = f[2],
                            Category = f[3],
                            Quantity = quantity,
                            Price = price,
                            CoverPath = f[6]
                        });
                    }
                }

                books = importedBooks;
                dgvBooks.DataSource = books;

                UpdateStatus();
                ClearInput();

                MessageBox.Show("Nhập CSV thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
            }
        }

        private void mnuOpenCSV_Click(object sender, EventArgs e)
        {
            OpenCSV();
        }

        private void btnOpenCSV_Click(object sender, EventArgs e)
        {
            OpenCSV();
        }
       
        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            SaveCSV();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtBookId.Focus();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            btnDelete_Click(sender, e);
        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
    }
}
