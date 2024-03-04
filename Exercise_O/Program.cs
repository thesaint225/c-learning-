namespace Exercise_O;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to ente a sentence
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        // Ask the user to enter a word
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        // Check for the position if the word is present in the sentence
        // it check for an integer
        int index = sentence.IndexOf(word);

        // If the word is present, display the sentence starting from the word
        if (index != -1)
        {
            string newSentence = sentence.Substring(index);
            Console.WriteLine($"Result: {newSentence}");
        }
        else
        {
            // If the word is not present, display a message
            Console.WriteLine("The word is not present in the sentence.");
        }

        Console.WriteLine();

    }
}
