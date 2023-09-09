public class Product : IEquatable<Product>, IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public bool Equals(Product? other) => 
        other != null && this.Name == other.Name;

    public override bool Equals(object? other) =>
        other is Product product && Equals(product);

    public int CompareTo(Product? other)
    {
        int price = this.Price.CompareTo(other.Price);
        int name = this.Name.CompareTo(other.Name);

        return price != 0 ? price : name;
    }

    public override string ToString() => $"{Name} ({Price} x {Quantity})";
}