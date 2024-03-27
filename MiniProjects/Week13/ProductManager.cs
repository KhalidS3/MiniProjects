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
            products.Add(new Products(category, productName, price));
        }

        public void DisplayProducts()
        {
            var sortedProducts = products.OrderBy(p => p.Category).ToList();
            double totalPrice = sortedProducts.Sum(p => p.Price);

            int lineLength = 15 + 15 + 15 + 10;
            Console.WriteLine("\n" + new string('-', lineLength));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{"Category".PadRight(15)}{"Product".PadRight(15)}{"Price".PadRight(15)}");
            Console.ResetColor();
            Console.WriteLine(new string('-', lineLength));

            foreach (Products product in sortedProducts)  
            {
                Console.WriteLine(product);
            }

            Console.WriteLine(new string('-', lineLength));
            Console.WriteLine($"{"Total: ".PadRight(30)}{totalPrice.ToString("C", new CultureInfo("sv-SE"))}");
        }
    }
}
