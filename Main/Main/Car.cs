public class Car
{
    public string Model { get; set; } // Модель автомобиля
    public decimal Price { get; set; } // Цена

    public override string ToString()
    {
        return $"{Model}, Цена: {Price}";
    }
}