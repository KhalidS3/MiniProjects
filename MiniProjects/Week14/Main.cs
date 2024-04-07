namespace MiniProjects.Week14
{
    internal class AssetManager
    {
        // Level 1
        //Laptop macBook = new Laptop("MacBook Pro", new DateTime(2019, 1, 2), 2000);
        //MobilePhone iPhone = new MobilePhone("iPhone 11", new DateTime(2020, 1, 2), 1000);
        // level 2
        private List<Asset> assets = new List<Asset>();
        public static void Main()
        {
            AssetManager manager = new AssetManager();
            manager.CollectAssetsFromUser();
            manager.DisplaySortedAssets();
        }

        public void CollectAssetsFromUser()
        {
            Console.WriteLine("Enter asset details (type 'laptop' or 'phone', model name, purchase date, price), or 'done' when finished.");

            string userInput = "";

            while (true)
            {
                Console.Write("What type of asset: ");
                userInput = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

                if (userInput == "done")
                {
                    break;
                }

                if (userInput != "laptop" && userInput != "phone")
                {
                    Console.WriteLine("Invalid asset type. Please enter 'laptop' or 'phone'.");
                    continue;
                }

                string type = userInput;

                string brand;
                do
                {
                    Console.Write("Brand name: ");
                    brand = Console.ReadLine()?.Trim() ?? string.Empty;
                } while (string.IsNullOrEmpty(brand));

                string modelName;
                do
                {
                    Console.Write("Model name: ");
                    modelName = Console.ReadLine()?.Trim() ?? string.Empty;
                } while (string.IsNullOrEmpty(modelName));

                DateTimeOffset purchaseDate;
                do
                {
                    Console.Write("Purchase date (yyyy-MM-dd): ");
                    userInput = Console.ReadLine()?.Trim() ?? string.Empty;
                } while (!DateTimeOffset.TryParse(userInput, out purchaseDate));

                double price;
                do
                {
                    Console.Write("Price: ");
                    userInput = Console.ReadLine()?.Trim() ?? string.Empty;
                } while (!double.TryParse(userInput, out price));

                string officeLocation;
                do
                {
                    Console.Write("Office location: ");
                    officeLocation = Console.ReadLine()?.Trim() ?? string.Empty;
                } while (string.IsNullOrEmpty(officeLocation));

                string currency;
                do
                {
                    Console.Write("Currency: ");
                    currency = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty;
                } while (string.IsNullOrEmpty(currency));

                Office office = new Office(officeLocation, currency);

                if (type == "laptop")
                {
                    assets.Add(new Laptop(brand, modelName, purchaseDate, price, office));
                }
                else if (type == "phone")
                {
                    assets.Add(new MobilePhone(brand, modelName, purchaseDate, price, office));
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Asset added successfully!");
                Console.ResetColor();
            }
        }
        public void DisplaySortedAssets()
        {
            var sortedAssets = assets.OrderBy(a => a.GetType().Name).ThenBy(a => a.PurchaseDate).ToList();

            Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) +
                "Purchase Date".PadRight(20) + "Price in USD".PadRight(15) + "Currency".PadRight(10) + "Local price today");
            Console.WriteLine(new string('-', 15) + new string('-', 15) + new string('-', 15) + new string('-', 15) +
                new string('-', 20) + new string('-', 15) + new string('-', 10) + new string('-', 17));

            foreach (var asset in sortedAssets)
            {
                // Determine if asset is near its end of life and set the console text color accordingly
                var monthsToEnd = asset.MonthsToEndOfLife();
                if (monthsToEnd <= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (monthsToEnd <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.WriteLine(asset);
            }
            Console.ResetColor();
        }
    }
}
