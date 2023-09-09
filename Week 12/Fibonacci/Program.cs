public class Program
{
    static void Main()
    {
        Console.Write("What is n? ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Fibonacci({n}) = " + Fibonacci(n));
    }

    public static int Fibonacci(int n) => n switch
    {
        0 => 0,
        1 => 1,
        _ => Fibonacci(n - 1) + Fibonacci(n - 2)
    };
}