namespace Fibonacci_Series_With_Recursion;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Two
        // Fibonacci Series With Recursion
        CreateFibonacciUsingResursion(10, 0, 1);
        Console.ReadKey();
    }
    public static void CreateFibonacciUsingResursion(int num, int prev1, int prev2)
    {
        int fibo = 0;
        if(num > 0)
        {
            fibo = prev2 + prev1;
            prev2 = prev1;
            prev1 = fibo;
            
            Console.Write($"{fibo.ToString().PadRight(5)}");

            CreateFibonacciUsingResursion(num - 1, prev1, prev2);
        }
    }
}

