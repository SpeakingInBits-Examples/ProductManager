using Microsoft.Data.SqlClient;
using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager;

public static class ProductDb
{
    /// <summary>
    /// Gets a connection object for the ProductManagerDb.
    /// The connection needs to be opened and closed after it's used.
    /// </summary>
    public static SqlConnection GetConnection()
    {
        return new SqlConnection("Data Source=localhost;Initial Catalog=ProductManagerDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
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
