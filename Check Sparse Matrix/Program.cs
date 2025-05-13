namespace Check_Sparse_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Sixteen
        // Check Sparse Matrix
        int[,] arr = new int[3, 3] { { 9, 0, 0 }, { 0, 9, 0 }, { 0, 0, 9 } };
        PrintMatrix("Matrix: ", arr);
        CheckSparseMatrix(arr);
        Console.WriteLine($"-----------");
        int[,] arr2 = FillArr(3, 3, 0, 2);
        PrintMatrix("Matrix: ", arr2);
        CheckSparseMatrix(arr2);


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
    public static bool IsSparse(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        int Mcount = rows * columns;
        int count = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if (arr[i, j] == 0)
                {
                    count++;
                }
            }
        }
        return count > Mcount / 2;
    }
    public static void CheckSparseMatrix(int[,] arr)
    {
        if (IsSparse(arr))
        {
            Console.WriteLine($"Yes: It's Sparse");
        }
        else
        {
            Console.WriteLine($"No: It's not Sparse");
        }
    }
}

