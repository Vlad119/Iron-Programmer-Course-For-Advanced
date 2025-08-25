using System;

internal class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Яблоко", 200, "Фрукты");
        Product product2 = new Product("Помидор", 150, "Овощи");
        Product product3 = new Product("Яблоко", 150, "Фрукты");
        Console.WriteLine(product1.Equals(product3));
        Console.WriteLine(product2.Equals(product3));
    }
}
