using Newtonsoft.Json;

static class Program
{
    public static void Main(string[] args)
    {
        StreamReader reader;
        try
        {
            reader = new StreamReader("People.json");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Missing JSON file. {e.Message}");
            return;
        }

        List<Person> people;
        try
        {
            people = JsonConvert.DeserializeObject<List<Person>>(reader.ReadToEnd());
            reader.Close();
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine($"Invalid JSON. {e.Message}");
            return;
        }

        people.ForEach(
            p => p.OwnedCars.ForEach(
                c => Enumerable.Range(0, 5)
                    .ToList()
                    .ForEach(n => c.Drive())));

        StreamWriter writer = new StreamWriter("People.json");

        writer.Write(JsonConvert.SerializeObject(people));
        writer.Close();
    }
}