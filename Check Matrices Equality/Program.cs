namespace Check_Matrices_Equality;

class Program
{
    static void Main(string[] args)
    {
        // Problem Eleven
        // Check Matrices Equality
        int[,] arr1 = FillArr(3, 3, 1, 10);
        int[,] arr2 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix 1: ", arr1);
        PrintMatrix("Matrix 2: ", arr2);
        CheckMatricesEquality(arr1, arr2);

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
    public static int SumOfMatrix(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
        }
        return sum;
    }
    public static void CheckMatricesEquality(int[,] arr1, int[,] arr2)
    {
        int sumArr1 = SumOfMatrix(arr1);
        int sumArr2 = SumOfMatrix(arr2);
        if(sumArr1 == sumArr2)
        {
            Console.WriteLine($"Yes: both matrices are equal.");
        }
        else
        {
            Console.WriteLine($"No: matrices are not equal.");
        }

    }
}

