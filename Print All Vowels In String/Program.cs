namespace Print_All_Vowels_In_String;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Four
        // Print All Vowels In String
        PrintVowel(ReadText("Please Enter Your String? "));


        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        Console.Write($"\n");
        return text;
    }
    public static bool IsVowel(char letter)
    {
        letter = char.ToLower(letter);
        return (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u');
    }
    public static void PrintVowel(string text)
    {
        Console.Write($"Vowels in string are: ");
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (IsVowel(chars[i]))
            {
                Console.Write($"{chars[i].ToString().PadRight(6)}");
            }
        }
    }
}

