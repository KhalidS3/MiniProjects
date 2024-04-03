class Asset
{
    // I have the constructor here because both Laptop and MobilePhone classes will inherit from this class
    // and both of them share same properties. By doing this, I can avoid dubplicating the properties in both classes.
    // This method is called DRY (Don't Repeat Yourself).
    // If there is a change in the properties of the specific class, I can change it directly in the specific class. 
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