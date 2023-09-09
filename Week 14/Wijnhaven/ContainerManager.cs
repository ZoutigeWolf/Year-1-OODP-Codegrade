using Newtonsoft.Json;

public static class ContainerManager
{
    public static Queue<Container> selectedForInspection = new Queue<Container>();

    public static void Start(string manifestDir)
    {
        foreach (string file in Directory.EnumerateFiles(manifestDir))
        {
            if (file.Split("/")[^1].StartsWith("manifest") && file.EndsWith(".json"))
            {
                List<Container> containers = ProcessManifest(file);
                
                MarkForInspection(containers, c => c.Origin == "COL" && c.Categories.Contains("Fruits"));
            }
        }
    }

    public static List<Container> ProcessManifest(string path) =>
        JsonConvert.DeserializeObject<List<Container>>(File.ReadAllText(path)) ?? new List<Container>();

    public static List<Container> SearchByOrigin(List<Container> containers, string origin) =>
        containers.FindAll(c => c.Origin == origin);

    public static Container SearchForHeaviest(List<Container> containers) => 
        containers.MaxBy(c => c.Weight);

    public static void MarkForInspection(List<Container> containers, Func<Container, bool>? filter = null)
    {
        int amountMarked = 0;
        
        foreach (Container container in containers)
        {
            if (filter != null && filter(container))
            {
                container.Status = 1;
                selectedForInspection.Enqueue(container);
                amountMarked++;
            }
            else
            {
                container.Status = 9;
            }

            ContainerLogger.Log(container);
        }
        
        Console.WriteLine($"Number of containers selected for inspection: {amountMarked}");
    }
}