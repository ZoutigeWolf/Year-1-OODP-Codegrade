class LimitedEditionCar
{
    public static int Counter = 0;

    public const string Model = "DaBaby Car";

    public readonly string ChassisNumber;

    public LimitedEditionCar()
    {
        Counter++;
        
        this.ChassisNumber = $"CHNO{Counter}";
    }

}