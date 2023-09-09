class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Area() => Math.PI * Math.Pow(Radius, 2);
}