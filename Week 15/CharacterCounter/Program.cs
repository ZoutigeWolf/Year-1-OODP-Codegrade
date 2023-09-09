Console.Write("Input string: ");
string input = Console.ReadLine()?? "";
List<IGrouping<char, char>> result = (from c in input group c by c).ToList();
result.ForEach(g =>
        Console.WriteLine($"Char [{g.Key}]: {g.Count()}"));