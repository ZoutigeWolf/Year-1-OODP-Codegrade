using Newtonsoft.Json;

static class Program
{
    public const string FileName = "Cars.json";
    
    public static void Main(string[] args)
    {
        List<Car> cars = LoadCars();

        foreach (Car car in cars)
        {  
            for (int i = 0; i < 5; i++) car.Drive();
        }
        
        SaveCars(cars);
    }

    public static List<Car> LoadCars()
    {
        using (StreamReader stream = new StreamReader(FileName))
        {
            string jsonString = stream.ReadToEnd();

            return JsonConvert.DeserializeObject<List<Car>>(jsonString);
        }
    }

    public static void SaveCars(List<Car> cars)
    {
        using (StreamWriter stream = new StreamWriter(FileName))
        {
            stream.Write(JsonConvert.SerializeObject(cars));
        }
    }
}
