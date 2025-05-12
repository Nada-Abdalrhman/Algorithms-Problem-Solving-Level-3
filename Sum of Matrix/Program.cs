namespace Sum_of_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Ten
        // Sum of Matrix
        int[,] arr1 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix1: ", arr1);
        printSumOfMatrix("Matrix1", arr1);


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
                Console.Write($"{arr[i, j].ToString("D2").PadRight(6)}");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
    public static void printSumOfMatrix(string text, int[,] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        Console.WriteLine($"Sum of {text} is: {sum}");
    }
}

