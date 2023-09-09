static class Program
{
    public static void Main()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine() ?? "John";
        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine() ?? "Doe";

        string fullName = FullName(firstName, lastName);
        Console.WriteLine(fullName);
    }

    public static string FullName(string fName, string lName) => $"{fName} {lName}";
}