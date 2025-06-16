using System.Collections.Generic;
using System;

public class Order
{
    public decimal fullPrice;
    public List<Product> products;
    public Order(List<Product> products)
    {
        this.products = products;
        for (int i = 0; i < this.products.Count; i++)
        {
            fullPrice += this.products[i].price;
        }
    }

    public void ShowFullPrice()
    {
        Console.WriteLine(fullPrice);
    }
}