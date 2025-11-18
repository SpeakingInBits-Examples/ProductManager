namespace ProductManager;

/// <summary>
/// Represents a single product that
/// is for sale.
/// </summary>
public class Product
{
    /// <summary>
    /// The unique primary key identifier for the product
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The price the customer will be charged for this
    /// product. This is US currency and should be rounded
    /// to the nearest penny.
    /// </summary>
    public double SalesPrice { get; set; }

    /// <summary>
    /// The customer facing name of the product.
    /// </summary>
    public required string Name { get; set; }
}
