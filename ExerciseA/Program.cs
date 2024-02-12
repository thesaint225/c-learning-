namespace ExerciseA;

class Program
{
    static void Main(string[] args)
    {
    
         // Prompt the user to enter their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Prompt the user to enter their last name
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Display the message based on user input
        Console.WriteLine($"Good morning Mr. {lastName} {name}, you are {age} years old.");

    }
}
