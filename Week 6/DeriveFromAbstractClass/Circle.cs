class Circle : Shape
{
    public double Radius;

    public override double Area
    {
        get => Math.PI * (Radius * Radius);
    }

    public override double Perimeter
    {
        get => 2 * Math.PI * Radius;
    }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override string Info() => $"Circle with a radius of {Radius}";
}