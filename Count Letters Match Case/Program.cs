namespace Count_Letters_Match_Case;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty One
        // Count Letters Match Case
        CountLetter(ReadText("Please Enter Your String? "), ReadChar("Please Enter a Character? "));


        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        Console.Write($"\n");
        return text;
    }
    public static char ReadChar(string question)
    {
        Console.WriteLine($"{question}");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        return letter;
    }
    public static char InvertChar(char letter)
    {
        return char.IsLower(letter) ? char.ToUpper(letter) : char.ToLower(letter);
    }
    public static void CountLetter(string text, char letter)
    {
        char invertedLetter = InvertChar(letter);
        int count = 0;
        int sensitiveCount = 0;
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ' && (chars[i] == letter || chars[i] == invertedLetter))
            {
                count++;
                if(chars[i] == letter)
                {
                    sensitiveCount++;
                }
            }
        }
        Console.WriteLine($"Letter '{letter}' Count = {sensitiveCount}");
        Console.WriteLine($"Letter '{letter}' Or '{invertedLetter} Count = {count}");
    }
}

