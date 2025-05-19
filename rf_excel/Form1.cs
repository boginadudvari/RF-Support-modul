using Microsoft.Extensions.Logging;
using rf_excel.Models;
using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Linq;


namespace rf_excel
{
    public partial class Form1 : Form
    {
        private MyDnndatabaseContext context;
        private BindingSource listBox1BindingSource = new BindingSource();
        private BindingSource listBox2BindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            context = new MyDnndatabaseContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLists();
            LoadData();

            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;

            ujButton.Click += UjButton_Click;
            szerkButton.Click += SzerkButton_Click;
            torlesButton.Click += TorlesButton_Click;

            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            listBox2.SelectedIndexChanged += ListBox2_SelectedIndexChanged;
        }

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBox1.SelectedItem is null) return;

            dynamic selected = listBox1.SelectedItem;
            Guid selectedCategoryBvin = selected.Bvin;

            var kategoria = context.HccCategories.FirstOrDefault(c => c.Bvin == selectedCategoryBvin);
            if (kategoria == null) return;

            var productIds = context.HccProductXcategories
                .Where(x => x.CategoryId == selectedCategoryBvin)
                .Select(x => x.ProductId)
                .Distinct()
                .ToList();

            var termekek = context.HccProducts
                .Where(p => productIds.Contains(p.Bvin))
                .ToList();

            dataGridView1.DataSource = termekek
                .GroupBy(p => p.Id)
                .Select(g => g.First())
                .ToList();
        }

        private void ListBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBox2.SelectedItem is null) return;

            dynamic selected = listBox2.SelectedItem;
            string selectedOrderNumber = selected.Szam.ToString();

            var szurt = context.HccProducts
                .Where(p => p.Sku.Contains(selectedOrderNumber))
                .ToList();

            dataGridView1.DataSource = szurt;
        }

        private void LoadLists()
        {
            listBox1.DataSource = context.HccCategories
                .ToList()
                .GroupBy(c => c.RewriteUrl)
                .Select(g => g.First())
                .Select(c => new { c.Bvin, Nev = c.RewriteUrl })
                .ToList();

            listBox1.DisplayMember = "Nev";


            listBox2.DataSource = context.HccOrders
                .Where(c => !string.IsNullOrEmpty(c.OrderNumber))
                .Select(c => new { c.Bvin, Szam = c.OrderNumber })
                .ToList();

            listBox2.DisplayMember = "Szam";
        }

        private void LoadData()
        {
            var termek = context.HccProducts.ToList();
            dataGridView1.DataSource = termek;
        }

        private void TorlesButton_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Kérlek válassz ki egy törlendő elemet!", "Nincs kijelölés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Biztosan törölni szeretnéd a kiválasztott terméket?", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            var termek = context.HccProducts.FirstOrDefault(x => x.Id == id);
            if (termek != null)
            {
                context.HccProducts.Remove(termek);
                context.SaveChanges();
                LoadLists();
                LoadData();
                MessageBox.Show("Törlés sikeres.", "Kész", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SzerkButton_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            dataGridView1.EndEdit();

            var lista = dataGridView1.DataSource as List<HccProduct>;
            if (lista != null)
            {
                foreach (var termek in lista)
                {
                    if (string.IsNullOrWhiteSpace(termek.Sku) ||
                        string.IsNullOrWhiteSpace(termek.RewriteUrl) ||
                        string.IsNullOrWhiteSpace(termek.ImageFileMedium) ||
                        string.IsNullOrWhiteSpace(termek.ImageFileSmall))
                    {
                        MessageBox.Show(
                            $"A termék nem rendelkezik minden kötelező adattal (SKU, név, URL, kép).",
                            "Hiányzó adat",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    var letezo = context.HccProducts.FirstOrDefault(x => x.Id == termek.Id);
                    if (letezo != null)
                    {
                        context.Entry(letezo).CurrentValues.SetValues(termek);
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Mentés kész.");
            }
        }

        private void UjButton_Click(object? sender, EventArgs e)
        {
            using (var form = new NewProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var ujtermek = new HccProduct
                    {
                        Bvin = Guid.NewGuid(),
                        Sku = form.Sku,
                        RewriteUrl = form.ProductName.ToLower().Replace(' ', '-'),
                        SitePrice = form.SitePrice,

                        Status = 1,
                        CreationDate = DateTime.UtcNow,
                        LastUpdated = DateTime.UtcNow,
                        ImageFileSmall = "no-image.png",
                        ImageFileMedium = "no-image.png",
                        PostContentColumnId = "0",
                        PreContentColumnId = "0",
                        TaxClass = "None",
                        TemplateName = "Default",
                        ProductTypeId = null,
                        StoreId = 1,
                        ShippingMode = 0,
                        ShippingWeight = 0,
                        ShippingLength = 0,
                        ShippingWidth = 0,
                        ShippingHeight = 0,
                        ShippingCharge = 1,
                        UpchargeAmount = 3m,
                        UpchargeUnit = "1",
                        SiteCost = 0m,
                        ListPrice = 0m,
                        MinimumQty = 1,
                        GiftWrapPrice = 0m,
                        ExtraShipFee = 0m,
                        CustomProperties = "",
                        TaxExempt = 0,
                        NonShipping = 0,
                        ShipSeparately = 0,
                        GiftWrapAllowed = 0,
                        AllowReviews = true,
                        Featured = false,
                        IsAvailableForSale = true,
                        IsUserPrice = false,
                        HideQty = false,
                        IsSearchable = true,
                        IsBundle = false,
                        IsGiftCard = false,
                        IsRecurring = false,
                        AllowUpcharge = false,
                        RecurringInterval = 0,
                        RecurringIntervalType = 0,
                        OutOfStockMode = 0,
                        ManufacturerId = null,
                        VendorId = null
                    };

                    context.HccProducts.Add(ujtermek);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void TextBox2_TextChanged(object? sender, EventArgs e)
        {
            var szurt = context.HccOrders
                       .Where(x => x.OrderNumber.Contains(textBox1.Text))
                       .ToList();

            listBox2.DataSource = szurt;
            listBox2.DisplayMember = "OrderNumber";
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            var szurt = context.HccCategories
                       .Where(x => x.RewriteUrl.Contains(textBox1.Text))
                       .ToList();

            listBox1.DataSource = szurt;
            listBox1.DisplayMember = "RewriteUrl";
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel fájl (*.xlsx)|*.xlsx",
                Title = "Exportálás Excelbe",
                FileName = "export.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Adatok");

                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                                worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                            }
                        }

                        package.SaveAs(new FileInfo(filePath));
                        MessageBox.Show("Exportálás kész!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


    }
}
