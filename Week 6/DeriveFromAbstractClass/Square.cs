class Square : Shape
{
    public double Length;

    public override double Area
    {
        get => Length * Length;
    }

    public override double Perimeter
    {
        get => Length * 4;
    }
    
    public Square(double length)
    {
        this.Length = length;
    }

    public override string Info() => $"Square with sides of {Length}";
}