using Microsoft.Data.SqlClient;
using ProductManager.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager;

/// <summary>
/// Provides helper methods to interact with the ProductManagerDb database.
/// </summary>
public static class ProductDb
{
    /// <summary>
    /// Gets a connection object for the ProductManagerDb.
    /// The connection needs to be opened and closed after it's used.
    /// </summary>
    public static SqlConnection GetConnection()
    {
        return new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductManagerDb;Integrated Security=True;");
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
        // Raw string literal - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/raw-string
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

    /// <summary>
    /// Adds a new product to the database.
    /// </summary>
    /// <param name="p">The product to be added</param>
    /// <exception cref="SqlException">Throws if db is not available</exception>"
    public static void AddProduct(Product p)
    {
        SqlConnection con = GetConnection();

        SqlCommand insertCommand = new()
        {
            Connection = con,
            // Skip the Id column as it's an identity column
            CommandText = "INSERT INTO Products (SalesPrice, Name)" +
            " VALUES (@price, @productName)"
        };

        // Add parameters to prevent SQL Injection attacks
        insertCommand.Parameters.AddWithValue("@price", p.SalesPrice);
        insertCommand.Parameters.AddWithValue("@productName", p.Name);

        con.Open();

        int rows = insertCommand.ExecuteNonQuery();

        con.Close();
    }

    public static void UpdateProduct(Product p)
    {
        throw new NotImplementedException();
    }

    public static void DeleteProduct(Product p) 
    {
        DeleteProduct(p.Id);
    }

    /// <summary>
    /// Deletes a product from the database by its id.
    /// </summary>
    /// <param name="productId">The id of the product we want to delete</param>
    /// <exception cref="SqlException">Throws if db is not available</exception>"
    public static void DeleteProduct(int productId)
    {
        SqlConnection con = GetConnection();

        SqlCommand deleteCommand = new()
        {
            Connection = con,
            CommandText = "DELETE FROM Products WHERE Id = @prodId"
        };
        // Using a parameterized query to prevent SQL Injection attacks
        deleteCommand.Parameters.AddWithValue("@prodId", productId);

        con.Open();

        int rows = deleteCommand.ExecuteNonQuery();

        con.Close();
    }
}
