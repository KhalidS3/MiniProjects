using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects.Week14
{
    internal class AssetManager
    {
        Laptop macBook = new Laptop("MacBook Pro", new DateTime(2019, 1, 2), 2000);
        MobilePhone iPhone = new MobilePhone("iPhone 11", new DateTime(2020, 1, 2), 1000);
        public static void Main()
        {
            AssetManager manager = new AssetManager();
            manager.DisplayAssets();
            manager.CheckEndOfLife();
        }

        public void DisplayAssets()
        {
            Console.WriteLine("Laptop: ");
            Console.WriteLine($"Model: {macBook.ModelName}");
            Console.WriteLine($"Purchase Date: {macBook.PurchaseDate}");
            Console.WriteLine($"Price: {macBook.Price}");

            Console.WriteLine("\nMobile Phone: ");
            Console.WriteLine($"Model: {iPhone.ModelName}");
            Console.WriteLine($"Purchase Date: {iPhone.PurchaseDate}");
            Console.WriteLine($"Price: {iPhone.Price}");
        }

        public void CheckEndOfLife()
        {
            Console.WriteLine("\nChecking if the assets are at their end of life...");
            Console.WriteLine($"Laptop: {macBook.IsEndOfLife()}");
            Console.WriteLine($"Mobile Phone: {iPhone.IsEndOfLife()}");
        }

        // Main method
    }
}
