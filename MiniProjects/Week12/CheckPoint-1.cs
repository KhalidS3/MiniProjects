//# Produktlista
//## Intro
//Du ska skriva en console-app som frågar efter produkter. Efter att användaren har skrivit *exit* så visas
//alla (korrekt) inmatade produkter. Den första nivån av programmet är i nivå med vad du jobbat med
//första veckan. Nivå 3 är svår. Försök komma så långt du kan. Alla hjälpmedel är tillåtna och ni får prata
//med varandra.

//## Nivå 1
//I första nivån behöver du inte bry dig om formatet på den inmatade produkten. Användare anger en
//produkt och trycker *return*. När användaren fått nog så skriver hon *exit*. Då ska alla produkter
//visas.

//## Nivå 2
//Fortsätt med programmet. Lägg till följande:
//-Användaren ska kunna skriva *exit* på olika sätt. Stora eller små bokstäver ska inte spela någon
//roll. Inledande eller avslutande mellanslag ska också accepteras.
//- När användaren är klar, visa en sorterad lista

//## Nivå 3
//using System.Reflection.Emit;

//Nu ska du validera produktnamnet och bara acceptera ett namn som består av bokstäver -
//bindestreck - siffror.
//Siffer-delen måste vara ett heltal mellan 200 och 500.
//Exempel på giltiga produktnamn:
//-CE - 400
//- XX - 480
//- LABAN - 231
//Exempel på ogiltiga produktnamn:
//-CE400
//- XX3 - 480
//- LABAN - 100
//Ge olika felmeddelande beroende på vilket fel användaren gör.
using System.Text.RegularExpressions;

string[] productList = new string[0]; // we can with array size 0
int productCount = 0;
var validPattern = new Regex("^[A-Za-z]+-([2-4][0-9]{2}|500)$", RegexOptions.Compiled);
var missingNumberPattern = new Regex("^[A-Za-z]+-[0-9]{1,2}$", RegexOptions.Compiled);
var outOfRangePattern = new Regex("^[A-Za-z]+-([0-1][0-9]{2}|[6-9][0-9]{2})$", RegexOptions.Compiled);
var missingHyphen = new Regex("^[A-Za-z]+[0-9]+$", RegexOptions.Compiled);
var tooHighNumberPattern = new Regex("^[A-Za-z]+-5[0-9]{2}$", RegexOptions.Compiled); // Numbers greater than 500
Console.WriteLine("Please add a Product in the list, type 'exit' to finish");

while (true)
{
    Console.ResetColor();
    Console.Write("Add Product to list: ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower().Trim() == "exit")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You cannot enter an empty value.");
        Console.ResetColor();
    }
    else if (!validPattern.IsMatch(userInput))
    {
        Console.ForegroundColor = ConsoleColor.Red;
         if (userInput.EndsWith("-"))
        {
            Console.WriteLine("Invalid format on the right side of the product number.");
        }
        else if (userInput.StartsWith("-"))
        {
            Console.WriteLine("Invalid format on the left side of the product number.");
        }
        else if (missingNumberPattern.IsMatch(userInput))
        {
            Console.WriteLine("Invalid number range. The number must be three digits.");
        }
        else if (outOfRangePattern.IsMatch(userInput) || tooHighNumberPattern.IsMatch(userInput))
        {
            Console.WriteLine("Invalid number range. The number must be between 200 and 500.");
        }
        else if (missingHyphen.IsMatch(userInput))
        {
            Console.WriteLine("Invalid format. Please ensure there's a hyphen between letters & numbers.");
        }
        else
        {
            Console.WriteLine("Invalid product name format.");
        }
        Console.ResetColor();
        continue;
    }
    else
    {
        if (productCount == productList.Length)
        {
            Array.Resize(ref productList, productCount + 1);
        }

        productList[productCount] = userInput;
        productCount++;
    }
    Console.ResetColor();

}
Console.WriteLine("\n--------------------------");
Console.WriteLine("\nYou have inputted following products in the list (sorted)\n");
Array.Sort(productList);
for (int i = 0; i < productCount; i++)
{
    Console.WriteLine($"* {productList[i]}");
}