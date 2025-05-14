namespace Count_Small___Capital_Letters;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Nine
        // Count Small & Capital Letters
        CountSmallAndCapitalLetters(ReadText("Please Enter Your String? "));


        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        Console.Write($"\n");
        return text;
    }
    public static bool IsCapital(char letter)
    {
        return char.IsUpper(letter);
    }
    public static void CountSmallAndCapitalLetters(string text)
    {
        int capital = 0;
        int small = 0;
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ')
            {
                if (IsCapital(chars[i]))
                    capital++;
                else
                    small++;
            }
        }
        Console.WriteLine($"String Lenght = {text.Count()}");
        Console.WriteLine($"Capital Letters Count = {capital}");
        Console.WriteLine($"Small Letters Count = {small}");
    }
}

