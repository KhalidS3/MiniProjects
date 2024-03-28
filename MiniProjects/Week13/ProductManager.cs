using System.Globalization;

namespace MiniProjects.Week13
{
    internal class ProductManager
    {
        private List<Products> products;

        public ProductManager()
        {
            products = new List<Products>();
        }

        public void AddProduct(string category, string productName, double price) 
        {
            try
            {
                products.Add(new Products(category, productName, price));
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"An error occurred while adding products: {ex.Message}");
            }
        }

        public List<Products> SearchProducts(string searchP) 
        {
            return products.
                Where(p => p.ProductName.IndexOf(searchP, StringComparison.OrdinalIgnoreCase) >= 0).
                ToList();
        }

        public void DisplayProducts(string searchQuery = "", bool showTotal = true)
        {
            try
            {
                var sortedProducts = products.OrderBy(p => p.Price).ToList();
                double totalPrice = sortedProducts.Sum(p => p.Price);

                int lineLength = 15 + 15 + 15 + 10;
                Console.WriteLine("\n" + new string('-', lineLength));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{"Category".PadRight(15)}{"Product".PadRight(15)}{"Price".PadRight(15)}");
                Console.ResetColor();
                Console.WriteLine(new string('-', lineLength));

                foreach (Products product in sortedProducts)
                {
                    string productLine = product.ToString();
                    if (!string.IsNullOrWhiteSpace(searchQuery) && 
                        product.ProductName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.White;
                        productLine = productLine.PadRight(Console.WindowWidth - 1, ' ');
                    }

                    Console.WriteLine(productLine);

                    if (Console.BackgroundColor == ConsoleColor.DarkYellow)
                    {
                        Console.ResetColor();
                    }
                }

                Console.WriteLine(new string('-', lineLength));
                if (showTotal) 
                { 
                    Console.WriteLine($"{"Total: ".PadRight(30)}{totalPrice.ToString("C", new CultureInfo("sv-SE"))}");
                    Console.WriteLine(new string('-', lineLength));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while displaying products: {ex.Message}");
            }
        }


        //public void DisplayProducts()
        //{
        //    try
        //    {
        //        var sortedProducts = products.OrderBy(p => p.Price).ToList();
        //        double totalPrice = sortedProducts.Sum(p => p.Price);

        //        int lineLength = 15 + 15 + 15 + 10;
        //        Console.WriteLine("\n" + new string('-', lineLength));
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine($"{"Category".PadRight(15)}{"Product".PadRight(15)}{"Price".PadRight(15)}");
        //        Console.ResetColor();
        //        Console.WriteLine(new string('-', lineLength));

        //        foreach (Products product in sortedProducts)  
        //        {
        //            Console.WriteLine(product);
        //        }

        //        Console.WriteLine(new string('-', lineLength));
        //        Console.WriteLine($"{"Total: ".PadRight(30)}{totalPrice.ToString("C", new CultureInfo("sv-SE"))}");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"An error occurred while displaying products: {ex.Message}");
        //    }
        //}
    }
}
