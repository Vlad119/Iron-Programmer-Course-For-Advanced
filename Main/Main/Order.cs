public class Order
{
    public Car Car { get; set; }
    public Client Client { get; set; }
    public decimal Price { get; set; }

    public Order(Client client, decimal price, Car car)
    {
        Client = client;
        Price = price;
        Car = car;
    }

    public Order(Client client, decimal price) : this(client, price, null)
    { }
}
