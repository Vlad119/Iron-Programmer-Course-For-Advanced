using System.Collections;
using System.Collections.Generic;

public class Store : IEnumerable<Product>, IEnumerator<Product>
{
    private readonly List<Product> products = new List<Product>();
    private int index = -1;
    public Store() { }
    Product IEnumerator<Product>.Current => products[index];
    object IEnumerator.Current => this;
    IEnumerator IEnumerable.GetEnumerator() => this;
    IEnumerator<Product> IEnumerable<Product>.GetEnumerator() => this;

    public bool MoveNext()
    {
        index++;
        return index < products.Count;
    }
    public void Reset() => index = -1;
    public void Dispose() { }
    internal void AddProduct(Product product) => products.Add(product);
}
