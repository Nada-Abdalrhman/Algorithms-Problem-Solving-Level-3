namespace Check_Scalar_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourteen
        // Check Scalar Matrix
        int[,] arr = new int[3, 3] { { 9, 0, 0 }, { 0, 9, 0 }, { 0, 0, 9 } };
        PrintMatrix("Matrix: ", arr);
        CheckMatrixScalar(arr);

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
    public static bool IsScalar(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        if (rows != columns)
            return false;
        int num = arr[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if ((i == j && arr[i, j] != num) || (i != j && arr[i, j] != 0))
                    return false;
            }
        }
        return true;
    }
    public static void CheckMatrixScalar(int[,] arr)
    {
        if (IsScalar(arr))
        {
            Console.WriteLine($"Yes: Matrix is scalar.");
        }
        else
        {
            Console.WriteLine($"No:  Matrix is not scalar.");
        }

    }
}

