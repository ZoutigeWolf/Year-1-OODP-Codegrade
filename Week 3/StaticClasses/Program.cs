static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Calculator.Add(69, 420));
        Console.WriteLine(Calculator.Subtract(69, 420));
        Console.WriteLine(Calculator.Multiply(69, 420));
        Console.WriteLine(Calculator.Divide(69, 420));
        Console.WriteLine(Calculator.Modulo(69, 420));
    }
}