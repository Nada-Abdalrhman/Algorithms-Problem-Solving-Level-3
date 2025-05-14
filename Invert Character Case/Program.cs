namespace Invert_Character_Case;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Seven
        // Invert Character Case
        InvertChar(ReadChar("Please Enter a Character? "));


        Console.ReadKey();
    }
    public static char ReadChar(string question)
    {
        Console.WriteLine($"{question}");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        return letter;
    }
    public static void InvertChar(char letter)
    {
        Console.WriteLine($"Char after inverting case: ");
        if (char.IsLower(letter))
        {
            Console.WriteLine(char.ToUpper(letter));
        }
        else
        {
            Console.WriteLine(char.ToLower(letter));
        }
    }
}

