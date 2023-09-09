static class RewardGenerator
{
    private static Random _random = new Random(0);

    public static T GetRandomElement<T>(List<T> items) => items[_random.Next(0, items.Count)];
}