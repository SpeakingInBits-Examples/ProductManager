using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProductManager;

public partial class AddUpdateProductForm : Form
{
    Product? _existingProduct;

    public AddUpdateProductForm(Product? existingProduct = null)
    {
        InitializeComponent();

        if (existingProduct != null)
        {
            btnAddProduct.Text = "Update Product";
            txtProductName.Text = existingProduct.Name;
            txtSalesPrice.Text = existingProduct.SalesPrice.ToString();
            _existingProduct = existingProduct;
            Text = "Update Product #" + existingProduct.Id;
        }
    }

    private void btnAddProduct_Click(object sender, EventArgs e)
    {
        if (_existingProduct == null)
        {
            AddNewProduct();
        }
        else
        {
            _existingProduct.Name = txtProductName.Text;
            _existingProduct.SalesPrice = Convert.ToDouble(txtSalesPrice.Text);
            ProductDb.UpdateProduct(_existingProduct);
            MessageBox.Show("Product was updated successfully");
            Close();
        }
    }

    private void AddNewProduct()
    {
        Product p = new()
        {
            Name = txtProductName.Text,
            SalesPrice = Convert.ToDouble(txtSalesPrice.Text)
        };

        ProductDb.AddProduct(p);
        MessageBox.Show("Product was added successfully");

        DialogResult = DialogResult.OK;
        Close();
    }
}
