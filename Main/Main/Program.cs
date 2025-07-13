using System;
using System.Collections.Generic;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
    {
        new Product("Ноутбук", 6000),
        new Product("Мышка", 100),
        new Product("Наушники", 300),
        new Product("Клавиатура", 200)
    };

            decimal sumCost = products.GetSumCost();
            Console.WriteLine(sumCost);
        }
    }
}
