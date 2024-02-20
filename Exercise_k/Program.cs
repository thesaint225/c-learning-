/**
Exercise 12: boucle for
Author:Miessan henri
Date : 20-02-24
*/

namespace Exercise_k;

class Program
{
    static void Main(string[] args)
    {
        // display of mutliplication of 3
        for (int i = 0; i <= 10; i++)
        {
            int result = 3 * i;
            Console.Write($"3 * {i}={result}");
            Console.ReadLine();
        }
    }
}
