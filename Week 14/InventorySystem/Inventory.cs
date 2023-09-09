using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private Dictionary<string, Product> _products { get; set; }

    public Inventory()
    {
        this._products = new Dictionary<string, Product>();
    }

    public void AddProduct(string name, double price, int quantity) =>
        _products.Add(name, new Product(name, price, quantity));

    public void AddProduct(string name, double price) => AddProduct(name, price, 0);

    public void RemoveProduct(string name) => _products.Remove(name);

    public Product? GetProduct(string name) => _products.TryGetValue(name, out Product? p) ? p : null;

    public string GetInventorySummary()
    {
        int totalQuantity = _products.Values.Sum(p => p.Quantity);
        double totalPrice = _products.Values.Sum(p => p.Price * p.Quantity);
        
        return $"Total products: {totalQuantity}\n" +
        $"Total value: ${totalPrice}";
    }
}