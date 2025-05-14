namespace Print_Each_Word_In_String;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Five
        // Print Each Word In String
        // PrintEachWord(ReadText("Please Enter Your String? "));
        PrintEachWordAntherWay(ReadText("Please Enter Your String? "));
        Console.ReadKey();
    }
    public static string ReadText(string question)
    {
        Console.WriteLine($"{question}");
        string text = Console.ReadLine();
        Console.Write($"\n");
        return text;
    }
    
    public static void PrintEachWord(string text)
    {
        Console.WriteLine($"Your string words are: ");
        var words = text.Split(' ');
        foreach(var word in words)
        {
            Console.WriteLine(words);
        }
    }

    public static void PrintEachWordAntherWay(string text)
    {
        var delimiter = " ";
        Console.WriteLine($"Your string words are: ");
        int position = 0;
        string sWord;
        while((position = text.IndexOf(delimiter)) != -1)
        {
            sWord = text.Substring(0, position);
            if(sWord != "")
                Console.WriteLine(sWord);
            text = text.Remove(0, position + delimiter.Length);
        }
        if(text != "")
        {
            Console.WriteLine(text);
        }
    }
    
}

