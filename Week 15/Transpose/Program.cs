int[][] array = new int[][] {
    new int[]{ 1, 2, 3, 4, 5 },
    new int[]{ 6, 7, 8, 9, 10 },
    new int[]{ 11, 12, 13, 14, 15 },
    new int[]{ 16, 17, 18, 19, 20 },
    new int[]{ 21, 22, 23, 24, 25 }
};

List<List<int>> result = array
    .SelectMany(inner => inner.Select((item, index) => new { item, index }))
    .GroupBy(i => i.index, i => i.item)
    .Select(g => g.ToList())
    .ToList();

result.ForEach(arr =>
{
    arr.ForEach(i =>
        Console.Write($"{i} "));
    
    Console.WriteLine();
});

