class ShopItem
{
    public string ID;
    public string Name;
    public double Price;

    public ShopItem(string id, string name, double price)
    {
        this.ID = id;
        this.Name = name;
        this.Price = price;
    }

    public ShopItem(string id, double price) : this(id, "Unknown", price)
    {
    }
}