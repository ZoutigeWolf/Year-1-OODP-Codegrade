using Newtonsoft.Json;

public static class ContainerManager
{
    public static void Start(string manifestDir)
    {
        foreach (string file in Directory.EnumerateFiles(manifestDir))
        {
            if (file.Split("/")[^1].StartsWith("manifest") && file.EndsWith(".json"))
            {
                ProcessManifest(file).ForEach(Console.WriteLine);
            }
        }
    }

    public static List<Container> ProcessManifest(string path) =>
        JsonConvert.DeserializeObject<List<Container>>(File.ReadAllText(path)) ?? new List<Container>();

    public static List<Container> SearchByOrigin(List<Container> containers, string origin) =>
        containers.FindAll(c => c.Origin == origin);

    public static Container SearchForHeaviest(List<Container> containers) => 
        containers.MaxBy(c => c.Weight);
}