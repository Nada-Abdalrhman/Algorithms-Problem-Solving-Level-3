namespace Transpose_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Seven
        // 3x3 Ordered Matrix
        FillArr(3, 3);
        Console.WriteLine("\n--------------\n");
        FillArr(9, 9);

        Console.ReadKey();
    }
    public static Array CreateArr(int row, int column)
    {
        return new int[row, column];
    }
    public static void FillArr(int row, int column)
    {
        int[,] arr = (int[,])CreateArr(row, column);
        int counter = 1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = counter++;
            }
        }
        PrintMatrix($"The following is a {row}x{column} ordered matrix: ", arr);
        Console.WriteLine();
        PrintTransposeMatrix($"The following is a {row}x{column} transposed matrix: ", arr);
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
    }
    public static void PrintTransposeMatrix(string text, int[,] arr)
    {
        Console.WriteLine($"{text}");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[j, i].ToString().PadRight(6)}");
            }
            Console.Write("\n");
        }
    }
}

