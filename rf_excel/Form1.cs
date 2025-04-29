namespace rf_excel
{
    public partial class Form1 : Form
    {
        private RendezvényDatabaseContext context;
        private BindingSource listBox1BindingSource = new BindingSource();
        private BindingSource listBox2BindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            context = new RendezvényDatabaseContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLists();
            LoadData();

            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.TextChanged += TextBox2_TextChanged;

            ujButton.Click += UjButton_Click;
            szerkButton.Click += SzerkButton_Click;
            torlesButton.Click += TorlesButton_Click;
        }

        private void LoadLists()
        {
            listBox1BindingSource.DataSource = context.x.ToList();
            listBox2BindingSource.DataSource = context.y.ToList();

            listBox1.DataSource = listBox1BindingSource;
            listBox1.DisplayMember = "valami";

            listBox2.DataSource = listBox2BindingSource;
            listBox2.DisplayMember = "más valami";
        }

        private void LoadData()
        {
            dataGridView1.DataSource = context.???.ToList();
        }

        private void TorlesButton_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            //int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EventId"].Value);
            //var esemeny = context.Events.FirstOrDefault(x => x.EventId == id);
            //if (esemeny != null)
            //{
            //    context.Events.Remove(esemeny);
            //    context.SaveChanges();
            //    LoadLists();
            //    LoadDataGrid();
            }

        private void SzerkButton_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            //int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EventId"].Value);
            //var esemeny = context.Events.FirstOrDefault(x => x.EventId == id);
            //if (esemeny != null)
            //{
            //    esemeny.EventName = "Szerkesztett név";
            //    esemeny.Location = "Szerkesztett helyszín";
            //    context.SaveChanges();
                LoadLists();
                LoadData();
            }

        private void UjButton_Click(object? sender, EventArgs e)
        {
            //var uj = new Event
            //{
            //    EventName = "Új esemény",
            //    EventDate = DateTime.Now,
            //    Location = "Ismeretlen"
            //};
            //context.Events.Add(uj);
            //context.SaveChanges();
            LoadLists();
            LoadData();
        }

        private void TextBox2_TextChanged(object? sender, EventArgs e)
        {
            //var szurt = context.Events
            //    .Where(x => x.EventName.Contains(textBox2.Text))
            //    .ToList();
            //eventsBindingSource.DataSource = szurt;
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            //var szurt = context.Locations
            //                .Where(x => x.LocationName.Contains(textBox1.Text))
            //                .ToList();
            //locationsBindingSource.DataSource = szurt;
        }
    }
}
