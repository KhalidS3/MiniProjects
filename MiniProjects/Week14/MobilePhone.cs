namespace MiniProjects.Week14
{
    internal class MobilePhone : Asset
    {
        public MobilePhone(string brand, string modelName, DateTimeOffset purchaseDate, double price, Office office)
        {
            Brand = brand;
            ModelName = modelName;
            PurchaseDate = purchaseDate;
            Price = price;
            Office = office;
        }
    }
}
