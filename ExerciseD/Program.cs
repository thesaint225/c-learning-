/**
Exercise5 :condition
Author:Miessan H
Date : 13-02-24
*/

namespace ExerciseD;

class Program
{
    static void Main(string[] args)
    {
        // Declaration
        int currentYear = DateTime.Now.Year;
        int age;

        Console.Write("Entrez votre âge : ");
        if (int.TryParse(Console.ReadLine(), out age))
        {
            if (age < 18)
            {
                Console.WriteLine("Vous êtes mineur.");
                int yearTurning18 = currentYear + (18 - age);
                Console.WriteLine($"Vous serez majeur en {yearTurning18}.");
            }
            else if (age == 18)
            {
                Console.WriteLine("Vous avez exactement 18 ans. Vous êtes maintenant majeur.");
            }
            else
            {
                Console.WriteLine("Vous êtes majeur.");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un âge valide.");
        }




    }
}
