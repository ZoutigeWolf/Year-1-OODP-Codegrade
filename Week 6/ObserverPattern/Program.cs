static class Program
{
    public static void Main(string[] args)
    {
        switch (args[0])
        {
            case "INTERFACES": TestInterfaces(); return;
            case "CLASSES": TestClasses(); return;
            default: throw new ArgumentException();
        }
    }

    private static void TestInterfaces()
    {
        Console.WriteLine("IObservable is an interface: " + typeof(IObservable).IsInterface);

        Console.WriteLine("Methods in IObservable:");
        var methods = typeof(IObservable).GetMethods();
        Array.Sort(methods, (x, y) => string.Compare(x.Name, y.Name));
        foreach (var method in methods)
            Console.WriteLine($" - {method}");

        Console.WriteLine("\nIObserver is an interface: " + typeof(IObserver).IsInterface);
        Console.WriteLine("Methods in IObserver:");
        methods = typeof(IObserver).GetMethods();
        Array.Sort(methods, (x, y) => string.Compare(x.Name, y.Name));
        foreach (var method in methods)
            Console.WriteLine($" - {method}");

        Console.WriteLine("\nIDisplay is an interface: " + typeof(IDisplay).IsInterface);
        Console.WriteLine("Methods in IDisplay:");
        methods = typeof(IDisplay).GetMethods();
        Array.Sort(methods, (x, y) => string.Compare(x.Name, y.Name));
        foreach (var method in methods)
            Console.WriteLine($" - {method}");
    }

    private static void TestClasses()
    {
        WeatherData weatherData = new();
        CurrentConditionsDisplay currentDisplay = new(weatherData);
        weatherData.RegisterObserver(currentDisplay);
        Console.WriteLine("Adding first set of measurements...");
        weatherData.SetMeasurements(20, 65, 30.4);
        weatherData.SetMeasurements(22, 70, 29.2);
        weatherData.SetMeasurements(18, 90, 29.4);

        Console.WriteLine("\nAdding second set of measurements...");
        StatisticsDisplay statisticsDisplay = new(weatherData);
        weatherData.RegisterObserver(statisticsDisplay);
        weatherData.SetMeasurements(15, 70, 29.0);
        weatherData.SetMeasurements(20, 68, 28.7);
        weatherData.SetMeasurements(13, 67, 27.9);

        foreach (IObserver observer in new List<IObserver>() { currentDisplay, statisticsDisplay})
        {
            observer.Update();
        }

        foreach (IDisplay display in new List<IDisplay>() { currentDisplay, statisticsDisplay })
        {
            display.Display();
        }
    }
}