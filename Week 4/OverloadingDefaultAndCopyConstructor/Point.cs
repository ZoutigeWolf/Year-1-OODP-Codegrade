class Point
{
    public double X;
    public double Y;

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public Point() : this(0, 0)
    {
    }

    public Point(Point copy) : this(copy.X, copy.Y)
    {
    }

    public static double EuclideanDistance(Point a, Point b) => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
}