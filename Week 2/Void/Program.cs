namespace Void;
class Program
{
    public static void Main(string[] args)
    {
        PrintFullName("John", "Doe");
    }

    public static void PrintFullName(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }
}