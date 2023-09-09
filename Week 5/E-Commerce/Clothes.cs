class Clothes : Product
{
    public string Size;
    public string Material;
    
    public Clothes(string name, double price, int amountInStock, string size, string material)
        : base(name, price, amountInStock)
    {
        this.Size = size;
        this.Material = material;
    }

    public override string ToString() => base.ToString() + $"; size: {Size}; material: {Material}";
}