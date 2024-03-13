namespace Exercise_P;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to enter a number
        Console.WriteLine("Enter a number:");
        double number = double.Parse(Console.ReadLine());

        // Ask the user to enter the square root of the number
        Console.WriteLine("Enter the square root of the number:");
        double squareRoot = double.Parse(Console.ReadLine());

        // Calculate the actual square root of the number
        double actualSquareRoot = Math.Sqrt(number);

        // Check if the entered square root is correct
        if (Math.Abs(squareRoot - actualSquareRoot) < 0.0001) // Use a small tolerance for floating-point comparison
        {
            // If the square root is correct, display "bravo"
            Console.WriteLine("Bravo!");
        }
        else
        {
            // If the square root is incorrect, display an error message along with the correct square root
            Console.WriteLine($"Error, the square root of {number} is {actualSquareRoot}");
        }

    }
}
