namespace MiniProjects.Week13
{
    internal class MainClass
    {
        public static void Main() 
        {
            ProductManager manager = new ProductManager(); // instance of the ProductManger

            Console.WriteLine("To enter a new product - follow the steps | To quit - enter: \"Q\"");

            while (true)
            {
                Console.Write("Enter a Category: ");
                string userInputCategory = Console.ReadLine();

                if (userInputCategory.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Quiting Program, Bye Bye!");
                    break;
                }

                Console.Write("Enter a Product Name: ");
                string userInputProName = Console.ReadLine();

                Console.Write("Enter a Price: ");
                if (!double.TryParse(Console.ReadLine(), out double price))
                {
                    Console.Write("Invalid input for price. Please input valid number.");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The product was successfully added!");
                Console.ResetColor();
                
                manager.AddProduct(userInputCategory, userInputProName, price);
               
            }

            manager.DisplayProducts();
        }
    }
}
