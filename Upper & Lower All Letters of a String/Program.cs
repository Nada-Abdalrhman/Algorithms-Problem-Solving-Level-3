namespace Upper___Lower_All_Letters_of_a_String;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Six
        // Upper & Lower All Letters of a String
        UpperAndLowerAllLetters(ReadText("Please Enter Your String? "));

        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        return text;
    }
    public static void UpperAllLetters(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ' )
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }
        string textAfterEdit = new string(chars);
        Console.WriteLine("String after upper: ");
        Console.WriteLine($"{textAfterEdit}");
    }
    public static void LowerAllLetters(string text)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ')
            {
                chars[i] = char.ToLower(chars[i]);
            }
        }
        string textAfterEdit = new string(chars);
        Console.WriteLine("String after lower: ");
        Console.WriteLine($"{textAfterEdit}");
    }
    public static void UpperAndLowerAllLetters(string text)
    {
        UpperAllLetters(text);
        Console.WriteLine();
        LowerAllLetters(text);
    }
}

