static class GameTools
{
    public static bool ReturnCount = true;

    public static string CoinFlip(int amount)
    {
        Random random = new Random();
        
        List<string> results = new List<string>();

        for (int i = 0; i < amount; i++)
        {
            results.Add(random.Next(0, 2) == 1 ? "Heads" : "Tails");
        }

        if (!ReturnCount)
            return string.Join('\n', results);

        int heads = results.Count(s => s == "Heads");
        int tails = amount - heads;

        return $"Heads: {heads}\nTails: {tails}";
    }

    public static string DiceRoll(int dieSides, int amount)
    {
        if (dieSides < 3)
            return "Invalid number of die sides.";

        Random random = new Random();

        List<int> results = new List<int>();

        for (int i = 0; i < amount; i++)
        {
            results.Add(random.Next(1, dieSides + 1));
        }

        if (!ReturnCount)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < results.Count(); i++)
            {
                int roll = results[i];
                
                output.Add($"Roll {i + 1}: {roll}");
            }

            return string.Join('\n', output);
        }

        List<string> res = new List<string>();

        for (int i = 1; i <= dieSides; i++)
        {
            int count = results.Count(r => r == i);
            
            res.Add($"{i} was rolled {count} {(count == 1 ? "time" : "times")}");
        }
        
        return string.Join('\n', res);
    }
}