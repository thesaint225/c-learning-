namespace Exercise_E;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");

        // Read the input from the user as a string
        string input = Console.ReadLine();

        try
        {
            // Convert the string input to an integer
            int number = int.Parse(input);

            // Provide feedback based on the value of the number
            if (number > 16)
            {
                Console.WriteLine("Très bien !");
            }
            else if (number >= 14)
            {
                Console.WriteLine("Bien !");
            }
            else if (number >= 12)
            {
                Console.WriteLine("Assez bien !");
            }
            else if (number >= 10)
            {
                Console.WriteLine("Passable !");
            }
            else
            {
                Console.WriteLine("Recalé !");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}
