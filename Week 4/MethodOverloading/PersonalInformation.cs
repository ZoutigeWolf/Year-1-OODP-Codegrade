static class PersonalInformation
{
    public static void PrintName(string name) => Console.WriteLine(name);

    public static void PrintName(string firstName, string lastName) => Console.WriteLine($"{firstName} {lastName}");
    
    public static void PrintName(char initial, string lastName) => Console.WriteLine($"{initial}. {lastName}");

    public static int IncreaseSalary(int salary) => salary + 100;

    public static double IncreaseSalary(int salary, double multiplier) => salary + salary * multiplier;
}