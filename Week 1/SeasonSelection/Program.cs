namespace SeasonSelection;

class Program
{
    static readonly int[] monthDays = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static void Main(string[] args)
    {
        Console.WriteLine("What is the month? 1-12");
        int month = int.Parse(Console.ReadLine() ?? "1");

        Console.WriteLine("What is the day? 1-31");
        int day = int.Parse(Console.ReadLine() ?? "1");

        int n = monthDays.Take(month - 1).Sum() + day;

        string season = n switch
        {
            >= 355 => "Winter",
            >= 264 => "Autumn",
            >= 172 => "Summer",
            >= 80 => "Spring",
            _ => "Winter"
        };

        Console.WriteLine($"On {day}-{month} it is {season}");
    }
}