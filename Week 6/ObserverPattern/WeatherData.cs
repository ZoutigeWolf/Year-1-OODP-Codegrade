class WeatherData : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();

    public double Temperature;
    public double Humidity;
    public double Pressure;

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        this.Temperature = temperature;
        this.Humidity = humidity;
        this.Pressure = pressure;
        
        MeasurementsChanged();
    }

    public void MeasurementsChanged() => NotifyObservers();

    public void RegisterObserver(IObserver observer) => _observers.Add(observer);

    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

    public void NotifyObservers() => _observers.ForEach(o => o.Update());
}