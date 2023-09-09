namespace CelsiusToFahrenheit;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is the temperature in Celsius?");
        double cTemp = double.Parse(Console.ReadLine() ?? "1");

        double fTemp = cTemp * 1.8 + 32.0;

        Console.WriteLine($"{cTemp} C = {fTemp} F");
        Console.WriteLine($"Rounded down that is {(int)fTemp} F");
    }
}

