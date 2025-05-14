namespace Count_Vowel;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Three
        // Count Vowel
        CountVowel(ReadText("Please Enter Your String? "));


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
    public static void CountVowel(string text)
    {
        int count = 0;
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (IsVowel(chars[i]))
            {
                count++;
            }
        }
        Console.WriteLine($"Number of vowel is: {count}");
    }
}

