public static class ProductDBExtension
{
    public static ProductViewModel ToProductViewModel(this ProductDb product)
    {
        return new ProductViewModel
        {
            Name = product.Name,
            Cost = product.Cost
        };
    }
}
