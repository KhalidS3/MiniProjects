/*
Level 1
Create at least one class for your application.
Use this class or classes when you add items to a list.
You should be able to add items to the list(s) until you write "q" (for quit).
Present a list with all items added.
*/

List<Products> products = new List<Products>();

Console.WriteLine("To enter a new product - follow the steps | To quit - enter: \"Q\"");

while (true)
{
    Console.Write("Enter a Category: ");
    string userInputCategory = Console.ReadLine();

    if (userInputCategory.Equals("Q", StringComparison.OrdinalIgnoreCase))
    {
        Console.Write("Quiting Program, Bye Bye!");
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

    products.Add(new Products(userInputCategory, userInputProName, price));
}

Console.WriteLine("\n----------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{"Category".PadRight(15)}{"Product".PadRight(15)}{"Price".PadRight(15)}");
Console.ResetColor();
foreach (Products product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine("----------------------------------");