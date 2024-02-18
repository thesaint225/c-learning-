/**
Exerise N9:boucle (do/while)
Author :Miessan
Date:18-02-2024
*/
namespace Exercise_I;

class Program
{
    static void Main(string[] args)
    {
        //    declarations
        char sex;
        // prompt the user to enter  their sex(f/m)
        Console.Write("Enter your sex (f/m)");

        //  CHECK THE SEX

        do
        {
            // read the sex from the user
            Console.Write("Sex: ");
            sex = char.ToLower(Console.ReadKey().KeyChar);
            //  check if the input is  valide("m" or f")
            if (sex != 'm' && sex != 'm')
            {
                Console.WriteLine("\nPlease enter 'm'or 'f'");
            };



        } while (sex != 'm' && sex != 'f');
        // Affichage du message 
        if (sex == 'm')
        {
            Console.WriteLine("\n Good morning Sir ");
        }
        else { Console.WriteLine("Good Morning Madam"); }
    }
}
