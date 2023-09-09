using System.Collections;

public class ProductCatalogue : IEnumerable<Product>
{
    private List<Product> _products = new List<Product>();
    
    public IEnumerator<Product> GetEnumerator()
    {
        foreach (Product product in _products)
        {
            yield return product;
        } 
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(Product product) => _products.Add(product);

    public void SortProducts() => _products.Sort();
}