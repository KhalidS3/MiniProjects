using System;

namespace MiniProjects.Week13
{
    internal class MainClass
    {
        public static void Main()
        {
            ProductManager manager = new ProductManager();

            // Start the process by immediately prompting for the category.
            Console.WriteLine("To enter a new product - follow the steps | To quit - enter: \"Q\"");
            PromptForCategoryAndAddProduct(manager);

            while (true)
            {
                string userInput = Console.ReadLine().ToUpper();

                switch (userInput)
                {
                    case "P":
                        // If "P" is entered after quitting, prompt for the category again.
                        PromptForCategoryAndAddProduct(manager);
                        break;
                    case "Q":
                        // Display products and total amount here.
                        manager.DisplayProducts();
                        // Final prompt after displaying products.
                        Console.WriteLine("--------------------------------------------------------------------------");
                        Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter: \"S\" | To quit - enter: \"Q\"");
                        //PromptForCategoryAndAddProduct(manager);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again or enter: \"P\" | To search for a product - enter: \"S\" | To quit - enter: \"Q\".");
                        break;
                }
            }
        }

        private static void PromptForCategoryAndAddProduct(ProductManager manager)
        {
            Console.Write("Enter a Category: ");
            string category = Console.ReadLine().ToUpper();

            if (category == "Q")
            {
                manager.DisplayProducts();
                Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter: \"S\" | To quit - enter: \"Q\"");
                return;
            }
            AddProduct(category, manager);

        }

        private static void AddProduct(string category, ProductManager manager)
        {
            Console.Write("Enter a Product Name: ");
            string productName = Console.ReadLine();
            if (productName.ToUpper() == "Q")
            {
                manager.DisplayProducts();
                Console.WriteLine("To enter a new product - enter: \"P\" | To search for a product - enter: \"S\" | To quit - enter: \"Q\"");
                return;
            }

            Console.Write("Enter a Price: ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid input for price. Please input a valid number.");
                return; // Return to prompt for category again.
            }

            manager.AddProduct(category, productName, price);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product was successfully added!");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------");

            // Prompt to add another product right away.
            Console.WriteLine("To enter a new product - follow the steps | To quit - enter: \"Q\"");
            PromptForCategoryAndAddProduct(manager);
        }
    }
}
