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
    public AddUpdateProductForm()
    {
        InitializeComponent();
    }

    private void btnAddProduct_Click(object sender, EventArgs e)
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
