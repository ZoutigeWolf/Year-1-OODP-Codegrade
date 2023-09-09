class Electronics : Product
{
    public string Brand;
    public string Model;
    
    public Electronics(string name, double price, int amountInStock, string brand, string model)
        : base(name, price, amountInStock)
    {
        this.Brand = brand;
        this.Model = model;
    }   

    public override void Restock()
    {
        if (AmountInStock < 10)
            AmountInStock = 10;
    }

    public override string ToString() => $"Name: {Name} ({Brand} {Model}); price: {Price}; stock: {AmountInStock}";
}