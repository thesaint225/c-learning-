/**
Exercise 14 =boucle imbriquee.
Author : Miessan Henri
Date : 26-02-2024

*/
namespace Exercise_M;

class Program
{
    static void Main(string[] args)
    {
        char choice;
        do
        {
            // Prompt the user to enter an integer between 1 and 9
            Console.WriteLine("Enter an integer between 1 and 9:");
            int number;

            // Validate the input to ensure it's within the specified range
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 9)
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 9.");
                Console.Write("Enter an integer between 1 and 9: ");
            }

            // Display the multiplication table of the entered integer
            Console.WriteLine($"Multiplication table of {number}:");

            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }

            // Ask if the user wants to calculate another multiplication table
            Console.Write("Do you want to calculate another multiplication table? (Y/N): ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();



            // clean the board 

            Console.Clear();

        } while (choice == 'Y');



        Console.WriteLine("Program terminated.");
    }
}





