using ProductManager.Classes;

namespace ProductManager
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        /// <summary>
        /// This clears and reloads all the products into
        /// the listbox
        /// </summary>
        private void LoadAllProducts()
        {
            lstProducts.Items.Clear(); // Clear existing items

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
            LoadAllProducts(); // Refresh product list

            MessageBox.Show($"Product {selectedProd.Name} deleted.");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddUpdateProductForm addForm = new();
            DialogResult result = addForm.ShowDialog();

            // Only refresh is a new product was added
            if (result == DialogResult.OK)
            {
                LoadAllProducts();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            Product selectedProduct = lstProducts.SelectedItem as Product;
            AddUpdateProductForm updateForm = new(selectedProduct);
            updateForm.ShowDialog();
            LoadAllProducts();
        }
    }
}
