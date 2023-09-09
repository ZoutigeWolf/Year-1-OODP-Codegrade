static class Program
{
    public static void Main(string[] args)
    {
        DbManager db = new DbManager();
        Console.WriteLine($"Current connection: {db.Connection}");
    }
}