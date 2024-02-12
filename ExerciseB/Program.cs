/**
ExerciseB:Calculer la moyenne 
Author : Miessan Henri
Date: 12-02-24
*/
namespace ExerciseB;

class Program
{
    static void Main(string[] args)
    {
        // declaration
        decimal SommeDeNote ;
        int NombreDeNote ;
        decimal Moyenne;

        // entrez la La Somme de note
        Console.Write("Entrez la somme des notes = ");
        SommeDeNote = decimal.Parse(Console.ReadLine());

        // entrez le nombre de note 
        Console.Write("Entrez le nombre de notes =");
        NombreDeNote = int.Parse(Console.ReadLine());

         // calculons la moyenne
          Moyenne = SommeDeNote / NombreDeNote ;

         Console.WriteLine("moyenne :" + Moyenne);
    }
}
