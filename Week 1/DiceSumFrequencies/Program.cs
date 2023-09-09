namespace DiceSumFrequencies;

class Program
{
    public static void Main(string[] args)
    {
        Random rand = new(0);
        var howManyTimes = 500;
        var dieSides = 6;

        List<List<int>> results = new();
        for (int i = 0; i < howManyTimes; i++)
        {
            List<int> rollResults = new();
            for (int j = 0; j < 2; j++)
            {
                rollResults.Add(rand.Next(1, dieSides + 1));
            }
            results.Add(rollResults);
        }

        List<string> freqs = new()
        {
            " 2: ",
            " 3: ",
            " 4: ",
            " 5: ",
            " 6: ",
            " 7: ",
            " 8: ",
            " 9: ",
            "10: ",
            "11: ",
            "12: ",
        };

        foreach (List<int> res in results)
        {
            freqs[res.Sum() - 2] += "|";
        }

        freqs.ForEach(x => Console.WriteLine(x));;
    }
}