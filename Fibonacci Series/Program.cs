namespace Fibonacci_Series;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty One
        // Fibonacci Series
        CreateFibonacciUsingLoop(15);

        Console.ReadKey();
    }
    public static void CreateFibonacciUsingLoop(int num)
    {
        int prev1 = 1;
        int prev2 = 0;
        int fibo = 0;
        Console.Write($"{prev1.ToString().PadRight(6)}");
        for (int i = 1; i < num; i++)
        {
            fibo = prev2 + prev1;
            Console.Write($"{(fibo).ToString().PadRight(6)}");
            prev2 = prev1;
            prev1 = fibo;
        }
    }
}

