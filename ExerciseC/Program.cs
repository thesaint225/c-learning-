/**
Exercice4:calcul daffichage;
Author:Miessan Henri
Date: 13-02-24

*/
namespace ExerciseC;

class Program
{
    static void Main(string[] args)
    {


        // Input the price excluding tax (net price)
        Console.WriteLine("Enter the price excluding tax (net price):");
        decimal netPrice = decimal.Parse(Console.ReadLine());

        // Entrez  VAT rate
        Console.WriteLine("Entrez the VAT rate (in percentage):");
        decimal vatRate = decimal.Parse(Console.ReadLine());

        // Calculate the VAT amount
        decimal vatAmount = netPrice * (vatRate / 100);

        // Calculate the total price including VAT
        decimal totalPriceIncludingVAT = netPrice + vatAmount;

        // Display the result
        Console.WriteLine($"VAT Amount: {vatAmount}");
        Console.WriteLine($"Total Price Including VAT: {totalPriceIncludingVAT}");


    }
}
