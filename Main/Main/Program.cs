using System;

internal class Program
{
    public static void Main()
    {
        var productDb = new ProductDb()
        {
            Id = Guid.NewGuid(),
            Name = "Молоко",
            Cost = 120,
            Description = "Натуральное молоко из деревни",
            ImagePath = "https://lenta.gcdn.co/globalassets/1/-/10/20/65/346818_2.png?preset=fulllossywhite"
        };
        ProductViewModel productViewModel = productDb.ToProductViewModel();
        Console.WriteLine(productViewModel.Name);
        Console.WriteLine(productViewModel.Cost);
    }
}
