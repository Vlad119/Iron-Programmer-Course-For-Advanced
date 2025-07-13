public static class ProductDBExtension
{
    public static ProductViewModel ToProductViewModel(this ProductDb product)
    {
        var PVM = new ProductViewModel();
        PVM.Name = product.Name;
        PVM.Cost = product.Cost;
        return PVM;
    }
}
