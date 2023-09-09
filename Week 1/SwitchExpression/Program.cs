namespace SwitchExpression;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an age:");
        int age = int.Parse(Console.ReadLine() ?? "0");

        string res = age switch
        {
            > 150 => "invalid",
            >= 20 => "an adult",
            >= 13 => "a teenager",
            >= 0 => "a child",
            _ => "invalid"
        };

        Console.WriteLine($"Age {age}: {res}");
    }
}

