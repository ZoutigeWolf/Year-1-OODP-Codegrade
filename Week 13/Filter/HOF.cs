public static class HOF
{
    public static List<T> Filter<T>(List<T> elements, Func<T, bool> predicate) => 
        elements.Where(predicate)
            .ToList();
}