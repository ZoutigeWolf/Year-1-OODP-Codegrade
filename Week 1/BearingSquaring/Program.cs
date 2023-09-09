namespace BearingSquaring;

enum Direction
{
    North,
    East,
    South,
    West
}

class Program
{
    static List<Direction> validDirections = new List<Direction>();

    public static void Main(string[] args)
    {
        Console.WriteLine("For each direction, input Y/N if it is valid.");

        foreach (Direction dir in Enum.GetValues(typeof(Direction)))
        {
            Console.WriteLine($"{DirToString(dir)}? Y/N");
            string ans = (Console.ReadLine() ?? "N").ToUpper();

            if (ans == "Y") validDirections.Add(dir);
        }

        Console.WriteLine("From here you can go:");
        GenerateCompass(validDirections.ToArray()).ToList().ForEach(x => Console.WriteLine(x));

        Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
        int bearing = int.Parse(Console.ReadLine() ?? "0");

        while (bearing > 360) bearing -= 360;

        Direction heading = bearing switch
        {
            > 315 => Direction.North,
            > 225 => Direction.West,
            > 135 => Direction.South,
            > 45 => Direction.East,
            _ => Direction.North
        };

        GenerateCompass(validDirections.ToArray()).ToList().ForEach(x => Console.WriteLine(x));

        Console.WriteLine(validDirections.Contains(heading) ? $"You are going {DirToString(heading)}" : $"You can't go {DirToString(heading)}");
    }

    static string DirToString(Direction direction) => direction switch
    {
        Direction.North => "North",
        Direction.East => "East",
        Direction.South => "South",
        Direction.West => "West",
        _ => throw new Exception("Balls")
    };

    static string[] GenerateCompass(Direction[] directions)
    {
        List<string> lines = new List<string>();

        if (directions.Contains(Direction.North))
        {
            lines.Add("    N");
            lines.Add("    |");
        }

        string middle = "";
        middle += directions.Contains(Direction.West) ? "W---" : "    ";
        middle += "|";
        middle += directions.Contains(Direction.East) ? "---E" : "";
        lines.Add(middle);

        if (directions.Contains(Direction.South))
        {
            lines.Add("    |");
            lines.Add("    S");
        }

        return lines.ToArray();
    }
}