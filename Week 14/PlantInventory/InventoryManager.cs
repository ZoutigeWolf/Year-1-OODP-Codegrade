using Newtonsoft.Json;

public static class InventoryManager
{
    public static List<Plant> ReadInventory(string dataset)
    {
        string jsonString = File.ReadAllText(dataset);
        return JsonConvert.DeserializeObject<List<Plant>>(jsonString)!;
    }

    public static List<Plant> DetectLowInventory(List<Plant> inventory) =>
        inventory
            .Where(i => i.Stock < 5)
            .OrderBy(i => i)
            .ToList();

    public static List<Plant> SearchByCategory(List<Plant> inventory, string category) =>
        inventory
            .Where(i => i.Category == category)
            .ToList();

    public static List<Plant> LastSoldItems(List<Plant> inventory)
    {
        DateOnly date = inventory
            .OrderBy(i => i.LastSold)
            .ToList()[^1].LastSold;

        return inventory.Where(i => i.LastSold == date).ToList();
    }

    public static List<Plant> PotentialRemoval(List<Plant> inventory) =>
        inventory.Where(i =>
                DateTime.Now.Year - i.LastSold.Year * 12 + DateTime.Now.Month - i.LastSold.Month > 10 
                && i.Stock >= 10)
            .ToList();
}