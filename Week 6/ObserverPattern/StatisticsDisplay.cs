class StatisticsDisplay : IObserver, IDisplay
{
    private IObservable _observable;

    private List<Double> _temperatures = new List<double>();
    private double _minTemperature;
    private double _maxTemperature;

    public StatisticsDisplay(IObservable observable)
    {
        this._observable = observable;
    }
    
    public void Update()
    {
        if (_observable is WeatherData data)
        {
            _temperatures.Add(data.Temperature);

            double average = _temperatures.Average();

            if (average > _maxTemperature)
            {
                _maxTemperature = average;
            }
            else if (average < _minTemperature)
            {
                _minTemperature = average;
            }
        }
    }

    public void Display() =>
        Console.WriteLine($"Avg/Min/Max temperature = {_temperatures.Average()}/{_minTemperature}/{_maxTemperature}");
}