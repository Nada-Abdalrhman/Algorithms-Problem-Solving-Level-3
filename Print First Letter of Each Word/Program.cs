namespace Print_First_Letter_of_Each_Word;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Three
        // Print First Letter of Each Word
        PrintFirstLetter(ReadText("Please Enter Your String? "));

        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        return text;
    }
    public static void PrintFirstLetter(string text)
    {
        bool isFirstLetter = true;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ' && isFirstLetter)
            {
                Console.WriteLine(text[i]);
            }
            isFirstLetter = (text[i] == ' ');
        }
    }
}

