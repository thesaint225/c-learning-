/**
Exercise 1:affichage pesonalisé
Author: Miessan henri
Date: 12-02-24

*/
namespace Exercise;

class Program
{
    static void Main(string[] args)
    {
          string name="miessan";
   string prenom="Henri";
   int age = 30;

//    le message à afficher

   string message = $"bonjour{name} {prenom}, vous avez {age} ans";

//    Afficher le message 

  Console.WriteLine(message);
    }
}
