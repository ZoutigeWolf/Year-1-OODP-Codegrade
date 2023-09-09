namespace TaskList;

class Program
{
    static List<string> _tasks = new List<string>();

    public static void Main(string[] args)
    {
        PrintOverview();

        _tasks.AddRange(new [] {"Mow lawn", "Pay taxes"});

        PrintOverview();

        _tasks.Remove("Mow lawn");
        _tasks.Add("Shopping");

        PrintOverview();
    }

    static void PrintOverview()
    {
        Console.WriteLine($"Amount of tasks: {_tasks.Count}");

        for (int i = 0; i < _tasks.Count; i++)
        {
            Console.WriteLine(_tasks[i]);
        }
    }
}