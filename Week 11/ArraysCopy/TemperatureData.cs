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

    public void PrintTemperatures() => _data.ToList().ForEach(Console.WriteLine);

    public double[] GetTemperaturesSorted(bool ascending)
    {
        double[] arr = new double[_data.Length];
        
        Array.Copy(_data, arr, _data.Length);
        
        Array.Sort(arr);
        
        if (!ascending)
            Array.Reverse(arr);

        return arr;
    }
}