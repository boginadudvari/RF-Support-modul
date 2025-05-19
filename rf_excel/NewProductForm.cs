using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace rf_excel
{
    public partial class NewProductForm : Form
    {
        public string ProductName { get; private set; }
        public decimal SitePrice { get; private set; }
        public string Sku { get; private set; }

        public NewProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                !decimal.TryParse(textBox2.Text, out decimal price))
            {
                MessageBox.Show("Kérlek tölts ki minden mezőt helyesen!");
                return;
            }

            ProductName = textBox1.Text.Trim();
            SitePrice = price;
            Sku = textBox3.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
