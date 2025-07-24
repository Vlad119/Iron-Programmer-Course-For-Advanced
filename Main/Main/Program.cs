using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
    {
        new Product("product1", 10, "furniture"),
        new Product("product2", 100, "toy"),
        new Product("product3", 1000, "toy"),
        new Product("product4", 10000, "toy"),
        new Product("product5", 100000, "furniture")
    };

        SelectAndChangePrice(products, "toy", 10, SelectCategory, IncreasePrice);
        foreach (var item in products)
        {
            Console.WriteLine($"{item.Name}, категория: {item.Category}, цена: {(int)item.Price}");
        }
    }

    static void SelectAndChangePrice(List<Product> products, string category, int price, Func<Product, string, bool> func, Action<Product, int> action)
    {
        foreach (var product in products)
        {
            if (func(product, category))
            {
                action(product, price);
            }
        }
    }

    static void IncreasePrice(Product prod, int n)
    {
        decimal percent = prod.Price / 100 * n;
        prod.Price += percent;
    }

    static bool SelectCategory(Product prod, string category)
    {
        return prod.Category.Equals(category);
    }


}
