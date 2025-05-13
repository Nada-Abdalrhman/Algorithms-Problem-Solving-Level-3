namespace Check_Identity_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirteen
        // Check Identity Matrix
        int[,] arr = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
        PrintMatrix("Matrix: ", arr);
        CheckMatrixIdentity(arr);

        Console.ReadKey();
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
    public static bool AreIdentity(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        if (rows != columns)
            return false;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if ((i == j && arr[i, j] != 1) || (i != j && arr[i, j] != 0))
                    return false;
            }
        }
        return true;
    }
    public static void CheckMatrixIdentity(int[,] arr)
    {
        if (AreIdentity(arr))
        {
            Console.WriteLine($"Yes: Matrices is identity.");
        }
        else
        {
            Console.WriteLine($"No:  Matrices is not identity.");
        }

    }

}

