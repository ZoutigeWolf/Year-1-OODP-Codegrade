namespace FixTheMethods2;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Give three names.\nThe first name:");
        string name1 = Console.ReadLine() ?? "";

        Console.WriteLine("The second name:");
        string name2 = Console.ReadLine() ?? "";

        Console.WriteLine("The third name:");
        string name3 = Console.ReadLine() ?? "";

        Console.WriteLine($"{Longest(new List<string>() {name1, name2, name3})} has the longest name");
    }

    public static string Longest(List<string> strings)
    {
        strings.Sort((x, y) => x.Length - y.Length);

        return strings[^1];
    }
}