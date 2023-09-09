namespace LeapYear;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine() ?? "0");

        PrintIsLeapYear(year);
    }

    public static bool IsDivisibleBy(int x, int y)
    {
        return x % y == 0;
    }

    public static bool IsLeapYear(int year)
    {
        return (IsDivisibleBy(year, 4) && !IsDivisibleBy(year, 100))|| IsDivisibleBy(year, 400);
    }

    public static void PrintIsLeapYear(int year)
    {
        Console.WriteLine($"{year} is " + (IsLeapYear(year) ? "" : "not") + " a leap year");
    }
}