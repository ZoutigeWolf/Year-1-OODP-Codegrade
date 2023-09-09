static class Program
{
    public static void Main(string[] args)
    {
        CarFactory factory = new CarFactory(2);

        for (int i = 0; i < 3; i++)
        {
            LimitedEditionCar car = factory.ProduceLimitedEditionCar();
            Console.WriteLine(car?.ChassisNumber ?? "Limit reached");
        }
    }
}