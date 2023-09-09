public enum Month
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}

public class Calendar
{
    private Month _currentMonth;

    public Calendar(Month initialMonth)
    {
        _currentMonth = initialMonth;
    }

    public void DisplayCurrentMonth()
    {
        Console.WriteLine($"Current month: {_currentMonth} ({(int)_currentMonth})");
    }

    public void SetNextMonth() => _currentMonth =
        (int)_currentMonth == 12 
            ? Month.January
            : (Month)((int)_currentMonth + 1);
}