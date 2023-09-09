static class Program
{
    const int spdOfLightInMperS = 299792458;
    const double daysInYear = 365.242199; 
    const string planetName = "LP 890-9b";
    private const double distanceFromEarthInLightYear = 100;
    
    public static void Main(string[] args)
    {
        Console.WriteLine($"The planet {planetName} is {distanceFromEarthInLightYear} lightyears away from earth");
        Console.WriteLine($"In meters this is {LightYearsToMeters(distanceFromEarthInLightYear)}");
    }

    public static double LightYearsToMeters(double lightYears) => spdOfLightInMperS * (lightYears * daysInYear * 24 * 60 * 60);
}