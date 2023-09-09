class Product
{
    public string Name;
    public double Price;
    public int AmountInStock;

    public Product(string name, double price, int amountInStock)
    {
        this.Name = name;
        this.Price = price;
        this.AmountInStock = amountInStock;
    }

    public virtual void Sell(int amount)
    {
        if (amount > AmountInStock)
        {
            Console.WriteLine($"{Name} is out of stock.");
        }
        else
        {
            AmountInStock -= amount;
        
            Console.WriteLine($"{amount} units of {Name} have been sold.");
        }

        Restock();
    }

    public virtual void Restock() {}

    public override string ToString() => $"Name: {Name}; price: {Price}; stock: {AmountInStock}";
}