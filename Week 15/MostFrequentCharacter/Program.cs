Console.Write("Input string: ");
string input = Console.ReadLine() ?? "";

char mfc = input
    .GroupBy(_ => _)
    .OrderByDescending(g => g.Count())
    .ToList()[0].Key;

Console.WriteLine(mfc);   