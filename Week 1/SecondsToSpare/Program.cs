namespace SecondsToSpare;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many seconds?");
        int seconds = int.Parse(Console.ReadLine() ?? "0");

        int hours = seconds / 3600;
        seconds %= 3600;

        int minutes = seconds / 60;
        seconds %= 60;

        Console.WriteLine($"Hours: {hours}\nMinutes: {minutes}\nSeconds left: {seconds}");
    }
}