namespace WaterStateWatching;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is the temperature of the water? (Celsius)");
        double temp = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("At {0} degrees Celsius, the water will be {1}", temp, temp <= 0 ? "solid" : temp >= 100 ? "gas" : "liquid");
    }
}