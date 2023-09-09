public enum Color
{
    Red,
    Green,
    Blue
}


public static class ColorValidator
{
    public static void DisplayColors()
    {
        foreach (Color color in Enum.GetValues(typeof(Color)))
        {
            Console.WriteLine(color);
        }
    }

    public static bool ValidateColor(string input)
    {
        if (!Enum.TryParse(input, out Color color))
        {
            Console.WriteLine("Invalid color");
            return false;
        }
        
        Console.WriteLine($"Valid color: {color}");

        return true;
    }
}