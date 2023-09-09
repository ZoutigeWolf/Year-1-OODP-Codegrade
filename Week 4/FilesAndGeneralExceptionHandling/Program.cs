using Newtonsoft.Json;

static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader("People.json");

            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(reader.ReadToEnd());
            reader.Close();

            people.ForEach(
                p => p.OwnedCars.ForEach(
                    c => Enumerable.Range(0, 5)
                        .ToList()
                        .ForEach(n => c.Drive())));

            StreamWriter writer = new StreamWriter("People.json");

            writer.Write(JsonConvert.SerializeObject(people));
            writer.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}