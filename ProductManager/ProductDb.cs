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
        // Get a db connection
        SqlConnection con = GetConnection();

        // Open connection
        con.Open();

        // Prepare SQL command
        string query = """
            SELECT Id, SalesPrice, Name
            FROM Products
            ORDER BY Name ASC
            """;
        SqlCommand selectCommand = new()
        {
            Connection = con,
            CommandText = query
        };

        // Execute command on db
        SqlDataReader reader = selectCommand.ExecuteReader();

        // Store results
        List<Product> allProducts = new();
        while (reader.Read())
        {
            Product p = new()
            {
                Name = reader["Name"].ToString(),
                Id = Convert.ToInt32(reader["Id"]),
                SalesPrice = Convert.ToDouble(reader["SalesPrice"])
            };

            // Make sure to add each product to the list so it gets returned
            allProducts.Add(p);
        }

        // Close connection
        con.Close();

        return allProducts;
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
