namespace Min_Max_Number_in_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Ninteen
        // Min&Max Number in Matrix
        int[,] arr = FillArr(3, 3, 1, 9);
        PrintMatrix("Matrix: ", arr);
        PrintMinMax(arr);

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
    public static void PrintMinMax(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        int min = arr[0,0];
        int max = arr[0,0];
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                }
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }
        Console.WriteLine($"Minimum Number is: {min}\n");
        Console.WriteLine($"Maxmum Number is: {max}");
    }

}

