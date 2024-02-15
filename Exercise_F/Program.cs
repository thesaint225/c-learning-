/**
Exercise 7 :boucle while
Author :Miessan Henri
Date :  15-02-24
*/
namespace Exercise_F;

class Program
{
    static void Main(string[] args)
    {
        // Declarations
        double total = 0;
        double prix;

        // Input process this code tell the user to enter 0 to termiate
        // the programme
        Console.WriteLine("Entrez prix . Entrez le 0 pour arreter ");

        do
        {
            Console.Write("Entrer le prix :");
            prix = double.Parse(Console.ReadLine());
            if (prix != 0)
            {
                total += prix;
            }

        } while (prix != 0);


        // le result final 

        Console.WriteLine($"total : {total}");


    }
}
