namespace Print_Middle_Row_and_Column_of_Matrix;

class Program
{
    static void Main(string[] args)
    {
        // Problem Nine
        // Print Middle Row and Column of Matrix
        Matrix row = Matrix.Row;
        Matrix col = Matrix.Column;

        int[,] arr1 = FillArr(3, 3, 1, 10);
        PrintMatrix("Matrix1: ", arr1);
        PrintMiddle("Matrix1",arr1, row);
        PrintMiddle("Matrix1", arr1, col);
        Console.WriteLine("-------------------");
        int[,] arr2 = FillArr(9, 9, 1, 10);
        PrintMatrix("Matrix2: ", arr2);
        PrintMiddle("Matrix2", arr2, row);
        PrintMiddle("Matrix2", arr2, col);

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
    public static void PrintMiddle(string text, int[,] arr, Matrix matrix)
    {
        int row = arr.GetLength(0);
        int column = arr.GetLength(1);
        int mid = 0;
        if (matrix == Matrix.Row)
        {
            Console.WriteLine($"Middle Row of {text} is: ");
            mid = row / 2;
            for (int i = 0; i < column; i++)
            {
                Console.Write($"{arr[mid, i].ToString("D2").PadRight(6)}");
            }
            Console.WriteLine($"\n");
        }
        else
        {
            Console.WriteLine($"Middle Column of {text} is: ");
            mid = column / 2;
            for (int i = 0; i < row; i++)
            {
                Console.Write($"{arr[i, mid].ToString("D2").PadRight(6)}");
            }
            Console.WriteLine($"\n");
        }
    }
}
public enum Matrix
{
    Row = 1,
    Column = 2
}

