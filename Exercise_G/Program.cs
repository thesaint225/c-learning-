/**
Exercise 8 :boucle while
Author :Miessan Henri
Date : 15-02-24
Date :
*/
namespace Exercise_G;

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        string userInput;

        Console.WriteLine("Avez-vous un prix à saisir? (yes/no)");

        // Read user input and validate
        userInput = Console.ReadLine().ToLower();

        while (userInput == "yes")
        {
            Console.Write("Saisir un prix: ");
            double price = double.Parse(Console.ReadLine());
            total += price;

            Console.WriteLine("Avez-vous un autre prix à saisir? (yes/no)");

            // Read user input and validate
            userInput = Console.ReadLine().ToLower();

            // Check if userInput is neither "yes" nor "no"
            while (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("Veuillez entrer 'yes' ou 'no' uniquement.");
                userInput = Console.ReadLine().ToLower();
            }
        }

        // Display total price if user input is "no"
        if (userInput == "no")
        {
            Console.WriteLine($"Total price: {total}");
        }
    }
}
