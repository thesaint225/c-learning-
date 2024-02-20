/**
Exercise 13 :boucle sucessive 
Author : Miessan Henri
Date :  20-02 -24
*/
namespace Exercise_L;

class Program
{
    static void Main(string[] args)
    {
        // PROMPT THE USER TO ENTER AN INTEGER BETWEEN 1 TO 9
        Console.WriteLine("Enter an integer in betwwen 1 and 9 ");
        int number;
        // validate the input to ensure  it's whithin the specified range 
        while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 9)
        {
            Console.WriteLine("Invalid input . please enter an integer between 1 and 9. ");
            Console.Write("enter an integer between 1 and 9 :");
        }

        // display the multiplication table of the entered integer 
        Console.WriteLine($"multiplication talbe of {number}");

        for (int i = 0; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i}={result}");
        }

    }
}
