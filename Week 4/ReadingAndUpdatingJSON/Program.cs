using Newtonsoft.Json;

static class Program
{
    public static void Main(string[] args)
    {
        Calculator.StoreInMemory(1);
        Calculator.StoreInMemory(69.420);
        Console.WriteLine(Calculator.RestoreFromMemory());
    }
}