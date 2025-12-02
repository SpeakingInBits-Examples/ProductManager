using Microsoft.Data.SqlClient;
using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager;

public static class ProductDb
{
    public static SqlConnection GetConnection()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This will return all products from the database
    /// sorted in ascending order by Name.
    /// </summary>
    /// <returns></returns>
    public static List<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public static void AddProduct(Product p)
    {
        throw new NotImplementedException(); 
    }

    public static void UpdateProduct(Product p)
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(Product p) 
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }
}
