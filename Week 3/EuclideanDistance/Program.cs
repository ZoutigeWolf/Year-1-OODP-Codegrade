static class Program
{
    public static void Main(string[] args)
    {
        Point a = new Point(1, 1);
        Point b = new Point(10, 6);

        double dist = Math.Round(Point.EuclideanDistance(a, b), 2);
        
        Console.WriteLine($"The distance between ({a.X}, {a.Y}) and ({b.X}, {b.Y}) is {dist}"); 
    }
}