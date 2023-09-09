class CurrentConditionsDisplay : IObserver, IDisplay
{
    private IObservable _observable;

    private double _temperature;
    private double _humidity;

    public CurrentConditionsDisplay(IObservable observable)
    {
        this._observable = observable;
    }
    
    public void Update()
    {
        if (_observable is WeatherData data)
        {
            _temperature = data.Temperature;
            _humidity = data.Humidity;
        }
    }

    public void Display() => Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity} humidity");
}