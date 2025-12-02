using ProductManager.Classes;

namespace ProductManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> allProducts = ProductDb.GetAllProducts();

            // Add each product to listbox
            foreach (Product p in allProducts)
            {
                lstProducts.Items.Add(p);
            }
        }
    }
}
