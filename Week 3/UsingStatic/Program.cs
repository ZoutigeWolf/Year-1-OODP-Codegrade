static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give the circle radius:");
        double radius = double.Parse(Console.ReadLine() ?? "1");

        int area = Convert.ToInt32(Math.Round(new Circle(radius).Area()));
        
        Console.WriteLine($"Rounded circle area: {area}");
    }
}