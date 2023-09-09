class Computer : Electronics
{
    public Computer(string name, double price, int amountInStock, string brand, string model)
        : base(name, price, amountInStock, brand, model)
    {
        
    }

    public override void Restock()
    {
        if (AmountInStock < 5)
            AmountInStock = 5;
    }
}