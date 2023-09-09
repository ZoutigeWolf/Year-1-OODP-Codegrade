namespace Switch;
class Program
{
    public static void Main(string[] args)
    {
        int[] pos = new int[2] { 0, 0 };

        Console.WriteLine("What direction would you like to go?");
        Console.WriteLine("Up\nDown\nLeft\nRight");

        string? dir = Console.ReadLine();

        switch (dir.ToLower())
        {
            case "up":
                pos[1]++;
                break;

            case "down":
                pos[1]--;
                break;

            case "left":
                pos[0]--;
                break;

            case "right":
                pos[0]++;
                break;

            default:
                Console.WriteLine("Invalid direction");
                break;
        }

        Console.WriteLine("Current Position");
        Console.WriteLine($"X:{pos[0]}, Y:{pos[1]}");
    }
}

