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
}