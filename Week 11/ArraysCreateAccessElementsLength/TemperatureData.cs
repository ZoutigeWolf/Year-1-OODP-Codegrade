public class WeatherData
{
    //Change from List to array
    private readonly double[] _data;

    public int NumberOfReadings => _data.Length;

    public WeatherData(double[] data) => _data = data;

    public double GetHighestTemperature() => _data.Max();
}