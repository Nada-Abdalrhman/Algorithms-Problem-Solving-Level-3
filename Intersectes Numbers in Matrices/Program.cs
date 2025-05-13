namespace Intersectes_Numbers_in_Matrices;

class Program
{
    static void Main(string[] args)
    {
        // Problem Eighteen
        // Intersectes Numbers in Matrices
        int[,] arr1 = FillArr(3, 3, 1, 10);
        int[,] arr2 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix 1: ", arr1);
        PrintMatrix("Matrix 2: ", arr2);
        PrintIntersectes(arr1, arr2);


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
    public static bool IsFound(int[,] arr, int num)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (arr[i, j] == num)
                {
                    return true;
                }
            }
        }
        return false;
    }
    public static void PrintIntersectes(int[,] arr1, int[,] arr2)
    {
        Console.WriteLine($"Intersected Numbers are: ");
        int rows = arr1.GetLength(0);
        int columns = arr1.GetLength(1);
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if (IsFound(arr2, arr1[i,j]))
                {
                    Console.Write($"{arr1[i, j].ToString().PadRight(6)}");
                }
            }
        }
        Console.Write("\n");
    }
}

