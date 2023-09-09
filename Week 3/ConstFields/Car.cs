class Car
{
    public const int NumberOfWheels = 4;
    public string Color;

    public Car(string color)
    {
        this.Color = color;
    }

    public void Paint(string color) => this.Color = color;

    public string Info() => $"My color is currently {Color}, but that may change. But I will always have {NumberOfWheels} wheels.";
}