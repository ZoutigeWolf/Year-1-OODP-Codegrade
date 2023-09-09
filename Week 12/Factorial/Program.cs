public static class Program
{
    public static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        
        Console.WriteLine(Factorial(n));
    }

    public static int Factorial(int n)
    {
        return n switch
        {
            < 0 => -1,
            <= 1 => 1,
            _ => n * Factorial(n - 1)
        };
    }
        
}