/**
Exercise 10 :For boucle 
a For boucle is a derterministe boucle used when you 
know how many times you will itterate
Autor:Miessan Henri
Date :19-02-24.
*/
namespace Exercise_J;

class Program
{
    static void Main(string[] args)
    {
        // declarations
        int totalMarks = 0;
        double Average;

        // prompt the user to enter 5 marks
        Console.WriteLine("Enter 5 MARKS");

        // Loop to read 5 marks

        for (int i = 0; i < 5; i++)
        {   //Display each mark to the user
            Console.Write($"Marks:{i + 1}:");
            int mark = int.Parse(Console.ReadLine());

            // add the marks
            totalMarks += mark;
        }

        // calculate the average 
        Average = (double)totalMarks / 5;

        // display the average 
        Console.WriteLine($"Average Marks :{Average}");
        Console.ReadLine();
    }
}
