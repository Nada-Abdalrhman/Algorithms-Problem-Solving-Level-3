namespace Check_Typical_Matrices;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twelve
        // Check Typical Matrices
        int[,] arr1 = FillArr(3, 3, 1, 10);
        int[,] arr2 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix 1: ", arr1);
        PrintMatrix("Matrix 2: ", arr2);
        CheckMatricesTypically(arr1, arr2);
        Console.WriteLine($"----------");
        int[,] arr3 = arr1;
        PrintMatrix("Matrix 1: ", arr1);
        PrintMatrix("Matrix 3: ", arr3);
        CheckMatricesTypically(arr1, arr3);

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
    public static bool AreTypical(int[,] arr1, int[,] arr2)
    {
        bool isEqual = true;
        for(int i = 0; i < arr1.GetLength(0); i++)
        {
            for(int j = 0; j < arr1.GetLength(1); j++)
            {
                if (arr1[i,j] == arr2[i, j])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    return isEqual;
                }
            }
        }
        return isEqual;
    }
    public static void CheckMatricesTypically(int[,] arr1, int[,] arr2)
    {
        if (AreTypical(arr1, arr2))
        {
            Console.WriteLine($"Yes: both matrices are equal.");
        }
        else
        {
            Console.WriteLine($"No: matrices are not equal.");
        }

    }

}

