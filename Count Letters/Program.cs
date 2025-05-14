namespace Count_Letters;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty
        // Count Letters
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
    public static void CountLetter(string text, char letter)
    {
        int count = 0;
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ' && chars[i] == letter)
            {
                count++;
            }
        }
        Console.WriteLine($"Letter '{letter}' Count = {count}");
    }
}

