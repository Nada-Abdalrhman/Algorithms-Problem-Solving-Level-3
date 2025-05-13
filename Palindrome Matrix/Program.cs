namespace Palindrome_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty
        // Palindrome Matrix
        int[,] arr = new int[3,3] { { 1,2,1}, { 5,5,5}, { 7,3,7} };
        PrintMatrix("Matrix: ", arr);
        printResult(IsPalindrome(arr));
        Console.WriteLine($"-----------");
        int[,] arr2 = FillArr(3, 3, 1, 9);
        PrintMatrix("Matrix: ", arr2);
        printResult(IsPalindrome(arr2));

        Console.ReadKey();
    }
    public static Array CreateArr(int row, int column)
    {
        return new int[row, column];
    }
    public static Random rand = new Random();
    public static int[,] FillArr(int row, int column, int from, int to)
    {
        int[,] arr = (int[,])CreateArr(row, column);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = rand.Next(from, (to + 1));
            }
        }
        return arr;
    }
    public static void PrintMatrix(string text, int[,] arr)
    {
        Console.WriteLine($"{text}");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j].ToString().PadRight(6)}");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
    public static bool IsPalindrome(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        if (rows != columns)
            return false;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns / 2; j++)
            {
                if (arr[i, j] != arr[i, columns - j - 1])
                    return false;
            }
        }
        return true;
    }
    public static void printResult(bool ispalindrome)
    {
        if (ispalindrome)
        {
            Console.WriteLine($"Yes: Matrix is Palindrome");
        }
        else
        {
            Console.WriteLine($"No: Matrix is not Palindrome");
        }
    }
}

