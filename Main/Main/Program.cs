using System;

internal class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();
        store.AddProduct(new Product { Name = "Чайник", Price = 1000, Quantity = 3 });
        store.AddProduct(new Product { Name = "Мультиварка", Price = 3000, Quantity = 7 });
        store.AddProduct(new Product { Name = "Пылесос", Price = 7500, Quantity = 15 });

        foreach (var product in store)
        {
            Console.WriteLine(product);
        }
    }
}
