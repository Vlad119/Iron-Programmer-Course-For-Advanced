using System.Collections.Generic;

public static class ProductExtension
{
    public static decimal GetSumCost(this List<Product> products)
    {
        decimal result = 0;
        foreach(var p in products)
        {
            result += p.Cost;
        }
        return result;
    }
}
