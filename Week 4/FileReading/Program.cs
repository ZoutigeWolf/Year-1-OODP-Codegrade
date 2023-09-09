static class Program
{
    public static void Main(string[] args)
    {
        string content = File.ReadAllText("MyTextFile.txt");
        Console.WriteLine(content);
    }
}