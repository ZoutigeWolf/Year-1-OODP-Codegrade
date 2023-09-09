public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;

    public int NumberOfReadings => _data.Length;

    public WeatherData(double[] data) => _data = data;

    public double GetHighestTemperature() => _data.Max();

    public void Sort(bool ascending)
    {
        Array.Sort(_data);
        
        if (!ascending)
            Array.Reverse(_data);
    }

    public void PrintTemperatures() => _data.ToList().ForEach(t => 
        Console.WriteLine(t >= 0 ? t : $"{t:0.0}")); 
}