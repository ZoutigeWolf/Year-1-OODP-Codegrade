public static class Program
{
    public static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        
        Console.WriteLine(RecursiveSum(n));
    }

    public static int RecursiveSum(int n) =>
        n <= 0 ? 0 : n + RecursiveSum(n - 1);
}