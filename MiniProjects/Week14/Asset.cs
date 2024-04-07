namespace MiniProjects.Week14
{
   // I have the constructor here because both Laptop and MobilePhone classes will inherit from this class
    // and both of them share same properties. By doing this, I can avoid dubplicating the properties in both classes.
    // This method is called DRY (Don't Repeat Yourself).
    // If there is a change in the properties of the specific class, I can change it directly in the specific class. 
    // public Asset(string modelName, DateTime purchaseDate, double price) 
    internal class Asset
    {
        //public Asset(string officeLocation, string currency) : base(officeLocation, currency)
        //{
        //}

        // I have the constructor here because both Laptop and MobilePhone classes will inherit from this class
        // and both of them share same properties. By doing this, I can avoid dubplicating the properties in both classes.
        // This method is called DRY (Don't Repeat Yourself).
        // If there is a change in the properties of the specific class, I can change it directly in the specific class. 
        //public Asset(string modelName, DateTime purchaseDate, double price) 
        //{
        //    ModelName = modelName;
        //    PurchaseDate = purchaseDate;
        //    Price = price;
        //}
        public string? Brand { get; set; }
        public string? ModelName { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
        public double Price { get; set; }
        public Office? Office { get; set; } // Office is inherited from the Office class, because it not needed.

        // Method to check if the asset is at its end of life (3 years)
        public int MonthsToEndOfLife()
        {
            var monthsToEnd = (PurchaseDate.AddYears(3).AddMonths(-3) - DateTime.Now).Days / 30; // Explian the logic
            return (int)monthsToEnd;
        }
        public override string ToString()
        {
            double localPriceToday = ConvertToLocalCurrency(Price);

            return $"{GetType().Name.PadRight(15)}{Brand,-15}{ModelName?.PadRight(15)}" +
                   $"{Office?.OfficeLocation.PadRight(15)}{PurchaseDate.ToString("yyyy-MM-dd").PadRight(20)}" +
                   $"{Price.ToString().PadRight(15)}{Office?.Currency.PadRight(10)}{localPriceToday}";
        }

        // Dummy method for currency conversion
        private double ConvertToLocalCurrency(double priceInUSD)
        {
            try
            {
                double convertedPrice = GetConversionRate(Office?.Currency);
                return priceInUSD * convertedPrice;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Office property must be set before converting to local currency.");
                return 0;
            }
        }

        // Dummy method to get conversion rate
        private double GetConversionRate(string currency)
        {
            switch (currency)
            {
                case "USD":
                    return 1;
                case "EUR":
                    return 0.93;
                case "SEK":
                    return 10.68;
                default:
                    return 0;
            }
        }

    }
}