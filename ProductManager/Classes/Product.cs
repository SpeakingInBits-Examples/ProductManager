namespace ProductManager.Classes;

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

    /// <summary>
    /// This returns the Name of the product so when a Product object is displayed
    /// it will show the name instead of the fully qualified class name.
    /// </summary>
    public override string ToString()
    {
        return Name;
    }
}
