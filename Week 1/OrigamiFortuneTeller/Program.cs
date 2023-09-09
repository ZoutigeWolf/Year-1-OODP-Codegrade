namespace OrigamiFortuneTeller;

class Program
{
    public static void Main(string[] args)
    {
        string color = GetColor();
        int number = GetNumber();

        number = ((number + color.Length) % 4) + 1;

        PrintFortune(number);
    }

    static void PrintFortune(int fortuneNumber)
    {
        string fortune = fortuneNumber switch
        {
            1 => "You will be loved and be happy!",
            2 => "You will be loved and be rich!",
            3 => "You will be loved and be famous!",
            4 => "You will be loved, and you'll be happy, rich and famous!",
            _ => "Unknown. :( But you will still be loved, no matter what."
        };
        Console.WriteLine(fortune);
    }

    static string GetColor()
    {
        Console.WriteLine("Pick a color (red/blue/green/yellow):");
        string color = (Console.ReadLine() ?? "").ToLower();

        string[] allowedColors = new string[4] {"red", "blue", "green", "yellow"};

        if (!allowedColors.Contains(color))
        {
            return GetColor();
        }

        return color;
    }

    static int GetNumber()
    {
        Console.WriteLine("Pick a number (1-8):");
        int number = int.Parse(Console.ReadLine() ?? "0");

        if (!(1 <= number && number <= 8))
        {
            return GetNumber();
        }

        return number;
    }
}