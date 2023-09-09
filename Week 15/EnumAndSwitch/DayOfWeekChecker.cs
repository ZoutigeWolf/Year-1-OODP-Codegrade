public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public static class DayOfWeekChecker
{
    public static void CheckDayOfWeek(string input)
    {
        if (!Enum.TryParse(input, out DayOfWeek day))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine((int)day switch
        {
            < 5 => "It's a weekday.",
            _ => "It's the weekend."
        });
    }
}