class CarFactory
{
    public int Limit;

    public CarFactory(int limit)
    {
        this.Limit = limit;
    }

    public LimitedEditionCar? ProduceLimitedEditionCar()
    {
        if (LimitedEditionCar.Counter == Limit)
            return null;

        return new LimitedEditionCar();
    }
    
}