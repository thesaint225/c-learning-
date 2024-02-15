namespace Exercise_E;

class Program
{
    static void Main(string[] args)
    {
        //Declaration
        int moyenne;

        Console.Write("Entrez votre moyenne :");

        // read the input from the user as a string

        string input = Console.ReadLine();

        // Convert the string input to an integer

        try
        {
            // Convert the string input to an integer
            moyenne = int.Parse(input);

            if (moyenne >= 16)
            {
                Console.WriteLine("Très bien !");
            }
            else if (moyenne <= 15)
            {

                Console.WriteLine("bien ");

            }
            else if (moyenne <= 13)
            {
                Console.WriteLine("assez-bien: ");

            }
            else if (moyenne <= 11)
            {
                Console.WriteLine("passable ");

            }
            else
            {
                Console.WriteLine("recallez ");

            }






        }
        catch (FormatException)
        {

            Console.WriteLine("Please enter a valid integer.");

        }



    }
}
