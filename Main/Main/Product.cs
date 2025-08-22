public class Product
{
    public string Name { get; set; } // Имя 
    public double Price { get; set; } // Цена
    public int Quantity { get; set; } // Количество

    public override string ToString()
    {
        return $"Название: {Name}, Цена: {Price}, Количество: {Quantity}";
    }
}