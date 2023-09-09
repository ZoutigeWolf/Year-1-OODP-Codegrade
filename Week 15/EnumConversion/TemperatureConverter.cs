public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

public static class TemperatureConverter
{
    public static string ConvertToString(TemperatureUnit unit) => unit switch
    {
        TemperatureUnit.Celsius => "C",
        TemperatureUnit.Fahrenheit => "F",
        TemperatureUnit.Kelvin => "K",
        _ => throw new ArgumentException("Value does not fall within the expected range.")
    };

    public static TemperatureUnit ConvertToEnum(string input) => input switch
    {
        "C" => TemperatureUnit.Celsius,
        "F" => TemperatureUnit.Fahrenheit,
        "K" => TemperatureUnit.Kelvin,
        _ => throw new ArgumentException("Invalid temperature unit string")
    };
}