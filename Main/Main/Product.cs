public class Product
{
    public string Name;
    public decimal Price;
    public string Category;

    public Product(string name, decimal cost, string category)
    {
        Name = name;
        Price = cost;
        Category = category;
    }
}