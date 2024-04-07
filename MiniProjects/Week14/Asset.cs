namespace MiniProjects.Week14
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