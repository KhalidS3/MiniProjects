namespace MiniProjects.Week14
{
    internal class Laptop : Asset
    {
        public Laptop(string brand, string modelName, DateTimeOffset purchaseDate, double price, Office office)
        {
            Brand = brand;
            ModelName = modelName;
            PurchaseDate = purchaseDate;
            Price = price;
            Office = office;
        }
  
    }
}
