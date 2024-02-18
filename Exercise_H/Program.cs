namespace Exercise_H;

class Program
{
    static void Main(string[] args)
    {
        int grade;

        // Prompt the user to enter a grade
        Console.WriteLine("Enter a grade (between 0 and 20):");

        // Read the input and validate it using a do-while loop
        do
        {
            // Read the grade from the user
            Console.Write("Grade: ");
            grade = int.Parse(Console.ReadLine());

            // Check if the grade is within the valid range
            if (grade < 0 || grade > 20)
            {
                Console.WriteLine("Please enter a grade between 0 and 20.");
            }
        } while (grade < 0 || grade > 20);

        // Display the correct grade entered
        Console.WriteLine($"Correct grade entered: {grade}");

    }
}
