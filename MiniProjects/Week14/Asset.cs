class Asset
{
    public Asset(string modelName, DateTime purchaseDate, double price)
    {
        ModelName = modelName;
        PurchaseDate = purchaseDate;
        Price = price;
    }

    public string ModelName { get; set; }
    public DateTime PurchaseDate { get; set; }
    public double Price { get; set; }

    // Method to check if the asset is at its end of life (3 years)
    public bool IsEndOfLife()
    {
        return DateTime.Now.Year - PurchaseDate.Year >= 3;
    }


}