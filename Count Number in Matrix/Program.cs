namespace Count_Number_in_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fifteen
        // Count Number in Matrix
        int[,] arr = FillArr(3, 3, 1, 9);
        PrintMatrix("Matrinx: ", arr);
        CountNum(arr, ReadNum("Enter the number to count in the matrix: "));

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
    public static int ReadNum(string text)
    {
        Console.Write($"{text}");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    public static void CountNum(int[,] arr, int num)
    {
        int rows = arr.GetLength(0);
        int columns = arr.GetLength(1);
        int count = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if (arr[i, j] == num)
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Number {num} count in matrix is {count}");
    }

}

