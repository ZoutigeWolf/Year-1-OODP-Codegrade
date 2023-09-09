class Temperature
{
    private double _celsius;

    public double Celsius
    {
        get => _celsius;
        set => _celsius = value >= -273.15 ? value : _celsius;
    }

    public double Kelvin
    {
        get => _celsius + 273.15;
        set => _celsius = value >= 0 ? value - 273.15 : _celsius;
    }
}