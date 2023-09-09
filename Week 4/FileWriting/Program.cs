static class Program
{
    public static void Main(string[] args)
    {
        File.AppendAllText("MyTextFile.txt", "\nAdded line.");
    }
}