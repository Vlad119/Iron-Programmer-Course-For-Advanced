using System;

internal class Program
{
    static void Main(string[] args)
    {
        var order1 = new Order(1, "Самокат", "ул. Солнечная 45", 3500, "Беседин Александр Владимирович");
        Console.WriteLine(order1);
    }
}

public record Order
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string Address { get; init; }
    public int TotalPrice { get; init; }
    public string CustomerInfo { get; init; }
    public Order(int id, string name, string address, int totalPrice, string customerInfo)
    {
        Id = id; 
        Name = name; 
        Address = address; 
        TotalPrice = totalPrice; 
        CustomerInfo = customerInfo;
    }
}