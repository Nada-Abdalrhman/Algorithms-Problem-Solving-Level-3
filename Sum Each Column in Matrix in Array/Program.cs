namespace Sum_Each_Column_in_Matrix_in_Array;

class Program
{
    static void Main(string[] args)
    {
        // Problem Five
        // Sum Each Column in Matrix in Array
        var arr = FillArr(3, 3, 1, 100);
        PrintSumOfEachColumn($"The following are the sum of each Column in the matrix: ", CalcSumOfEachColumn(arr));
        Console.WriteLine("--------------------");
        var arr2 = FillArr(9, 9, 5, 500);
        PrintSumOfEachColumn($"The following are the sum of each Column in the matrix: ", CalcSumOfEachColumn(arr2));


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
        PrintMatrix($"The following is a {row}x{column} random matrix: ", arr);
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
    }
    public static int[] CalcSumOfEachColumn(int[,] arr)
    {
        int[] result = new int[arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[j, i];
            }
            result[i] = sum;
        }
        return result;
    }
    public static void PrintSumOfEachColumn(string text, int[] arr)
    {
        Console.WriteLine($"{text}");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Column {i + 1} Sum = {arr[i]}");
        }
    }

}

