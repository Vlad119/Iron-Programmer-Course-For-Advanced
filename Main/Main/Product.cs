using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Cost { get; set; }


    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}