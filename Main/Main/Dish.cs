public class Dish
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Dish(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Имя: {Name} Цена: {Price} рублей";
    }

    public static Dish operator +(Dish dish, int price)
    {
        return new Dish(dish.Name, dish.Price + price);
    }
}