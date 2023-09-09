public static class Program
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("Enter base: ");
        int logBase = int.Parse(Console.ReadLine() ?? "0");
        
        Console.WriteLine(RecursiveLog(num, logBase));
    }

    public static int RecursiveLog(int num, int logBase)
    {
        return num < logBase ? 0 : 1 + RecursiveLog(num / logBase, logBase);
    }
}