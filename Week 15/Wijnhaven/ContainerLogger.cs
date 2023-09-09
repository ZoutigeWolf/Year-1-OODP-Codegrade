public static class ContainerLogger
{
    public static Dictionary<string, Container> containerLog = new Dictionary<string, Container>();

    public static void Log(Container container)
    {
        if (containerLog.TryGetValue(container.Code, out _))
            containerLog.Remove(container.Code);
        
        containerLog.Add(container.Code, container);
    }

    public static void Print() =>
        containerLog.Values
            .ToList()
            .ForEach(Console.WriteLine);
    
    public static void GetAverageWeightDeviation(ContainerStatus status)
    {
        double average = containerLog.Values
            .Where(c => c.Status == status)
            .Select(c => c.ActualWeight - c.Weight)
            .Average();

        Console.WriteLine($"Average Deviation from containers with status '{status}': {Math.Round(average)}");
    }

    public static void GetDistinctCategories(ContainerStatus status)
    {
        List<string> categories = containerLog.Values
            .Where(c => c.Status == status)
            .SelectMany(c => c.Categories)
            .Distinct()
            .ToList();
        
        Console.WriteLine($"Distinct categories from containers with status '{status}': [{string.Join(',', categories)}]");
    }
}