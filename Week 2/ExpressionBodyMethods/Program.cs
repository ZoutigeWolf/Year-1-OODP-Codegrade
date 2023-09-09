namespace ExpressionBodyMethods;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine() ?? "John";

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine() ?? "Doe";

        DisplayName(firstName, lastName);
    }

    public static string Name(string firstName, string lastName) => $"{firstName} {lastName}";

    public static void DisplayName(string firstName, string lastName) => Console.WriteLine(Name(firstName, lastName));
}