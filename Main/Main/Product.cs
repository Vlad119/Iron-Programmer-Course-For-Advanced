using System;

public class Product : IEquatable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }
    public Product(string name, int price, string category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"Product: Название: {Name}, Цена: {Price}, Категория: {Category}";
    }

    public bool Equals(Product other)
    {
        return Name == other.Name && Price == other.Price
            || Price == other.Price && Category == other.Category
            || Name == other.Name && Category == other.Category;
    }
}