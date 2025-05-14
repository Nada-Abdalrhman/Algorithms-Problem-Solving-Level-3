namespace Lower_First_Letter_of_Each_Word;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Five
        // Lower First Letter of Each Word
        LowerFirstLetter(ReadText("Please Enter Your String? "));

        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        return text;
    }
    public static void LowerFirstLetter(string text)
    {
        char[] chars = text.ToCharArray();
        bool isFirstLetter = true;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] != ' ' && isFirstLetter)
            {
                chars[i] = char.ToLower(chars[i]);
            }
            isFirstLetter = (chars[i] == ' ');
        }
        string textAfterEdit = new string(chars);
        Console.WriteLine("String after conversion: ");
        Console.WriteLine($"{textAfterEdit}");
    }
}

