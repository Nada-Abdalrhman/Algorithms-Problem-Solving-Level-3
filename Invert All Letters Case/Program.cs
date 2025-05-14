namespace Invert_All_Letters_Case;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Eight
        // Invert All Letters Case
        InvertAllLetters(ReadText("Please Enter Your String? "));

        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        return text;
    }
    public static char InvertChar(char letter)
    {
        return char.IsLower(letter) ? char.ToUpper(letter) : char.ToLower(letter);
    }
    public static void InvertAllLetters(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ')
            {
                chars[i] = InvertChar(chars[i]);
            }
        }
        string textAfterEdit = new string(chars);
        Console.WriteLine("String after inverting all letters case: ");
        Console.WriteLine($"{textAfterEdit}");
    }
    
}

