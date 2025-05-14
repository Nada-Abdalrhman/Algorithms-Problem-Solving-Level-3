namespace Is_Vowel;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Two
        // Is Vowel
        PrintResult(ReadChar("Please Enter a Character? "));

        Console.ReadKey();
    }
    public static char ReadChar(string question)
    {
        Console.WriteLine($"{question}");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        return letter;
    }
    public static bool IsVowel(char letter)
    {
        letter = char.ToLower(letter);
        return (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u');
    }
    public static void PrintResult(char letter)
    {
        if (IsVowel(letter))
        {
            Console.WriteLine($"Yes, letter '{letter}' is vowel");
        }
        else
        {
            Console.WriteLine($"No, letter '{letter}' is not vowel");
        }
    }
}

