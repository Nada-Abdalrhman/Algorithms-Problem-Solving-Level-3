namespace Multiply_Two_Matrices;

class Program
{
    static void Main(string[] args)
    {
        // Problem Eight
        // Multiply Two Matrices
        int[,] arr1 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix1: ", arr1);
        int[,] arr2 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix2: ", arr2);
        var result = MultiTwoArrays(arr1, arr2);
        PrintMatrix("Result: ", result);
        Console.WriteLine("-------------------");
        int[,] arr3 = FillArr(9, 9, 1, 10);
        PrintMatrix("Matrix1: ", arr3);
        int[,] arr4 = FillArr(9, 9, 1, 10);
        PrintMatrix("Matrix2: ", arr4);
        var result2 = MultiTwoArrays(arr3, arr4);
        PrintMatrix("Result: ", result2);


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
    public static int[,] MultiTwoArrays(int[,] arr1, int[,] arr2)
    {
        int row = arr1.GetLength(0);
        int column = arr1.GetLength(1);
        int[,] arr = new int[row, column];
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                arr[i, j] = arr1[i, j] * arr2[i, j];
            }
        }
        return arr;
    }
}

