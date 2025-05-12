namespace _3X3_Random_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem One
        // 3x3 Random matrix
        FillArr(3, 3, 1, 100);
        FillArr(9, 9, 5, 500);

        Console.ReadKey();
    }
    public static Array CreateArr(int row, int column)
    {
        return new int[row, column];
    }
    public static Random rand = new Random();
    public static void FillArr(int row, int column, int from, int to)
    {
        int[,] arr = (int[,])CreateArr(row, column);
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                arr[i, j] = rand.Next(from, (to + 1));
            }
        }
        PrintMatrix($"The following is a {row}x{column} random matrix: ", arr);
    }
    public static void PrintMatrix(string text, int[,] arr)
    {
        Console.WriteLine($"{text}");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j].ToString().PadRight(6)}");
            }
            Console.Write("\n");
        }
    }
}

