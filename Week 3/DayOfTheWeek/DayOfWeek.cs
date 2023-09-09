using System;

class DayOfWeek
{
    public int Day;

    public DayOfWeek(int day)
    {
        this.Day = day % 7;
    }

    public static string IndexToDay(int index)
    {
        index %= 7; 
        return index switch
        {
            0 => "Monday",
            1 => "Tuesday",
            2 => "Wednesday",
            3 => "Thursday",
            4 => "Friday",
            5 => "Saturday",
            6 => "Sunday",
        };

    }
    public bool IsWeekend() => Day == 5 || Day == 6;

    public string CurrentDay() => IndexToDay(Day);
    
    public string NextDay() => IndexToDay(Day + 1);
}