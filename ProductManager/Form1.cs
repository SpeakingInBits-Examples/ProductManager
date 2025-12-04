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

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            // If no product is selected, tell user and return immediately
            if (lstProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selectedProd = lstProducts.SelectedItem as Product;

            ProductDb.DeleteProduct(selectedProd);

            MessageBox.Show($"Product {selectedProd.Name} deleted.");
        }
    }
}
