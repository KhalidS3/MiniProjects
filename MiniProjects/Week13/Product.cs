using System.Globalization;

class Products
{
    public Products()
    {
    }

    public Products(string category, string productName, double price)
    {
        Category = category;
        ProductName = productName;
        Price = price;
    }

    public string Category { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        CultureInfo swedish = new CultureInfo("sv-SE");
        return $"{Category.PadRight(15)}{ProductName.PadRight(15)}{Price.ToString("C", swedish).PadRight(15)}";
    }

}