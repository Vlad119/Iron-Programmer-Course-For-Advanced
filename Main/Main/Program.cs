using System;

public class Program
{
    public static void Main()
    {
        Driver driverA = new Driver("Иван", "Иванов", 34);
        Driver driverC = new Driver("Пётр", "Петров", 25);
        Driver driverE = new Driver("Сергей", "Сергеев", 31);
        Car carA = new Car("O123MP", "Красный", driverA);
        Car carC = new Car("K789BA", "Белый", driverC);
        Car carE = new Car("C127EC", "Фиолетовый", driverE);
        Client clientA = new Client("Григорий", "Григорьев", 21, "1234123412341234");
        Client clientB = new Client("Семён", "Семёнов", 45, "1111222233334444");
        Client clientC = new Client("Владимир", "Владимиров", 29, "5678567856785678");
        Client clientD = new Client("Борис", "Борисов", 60, "0987654309876543");
        Client clientE = new Client("Аркадий", "Аркадьев", 32, "1029384756101234");
        Order orderA = new Order(clientA, 200, carA);
        Order orderB = new Order(clientB, 150, carA);
        Order orderC = new Order(clientC, 500, carC);
        Order orderD = new Order(clientD, 300, carC);
        Order orderE = new Order(clientE, 250, carE);
        Console.WriteLine($"{driverA.LastName} : {FindPayment(new Order[] { orderA, orderB, orderC, orderD, orderE }, driverA.Id)}");
    }

    public static decimal FindPayment(Order[] orders, Guid driverId)
    {
        decimal totalAmount = 0;
        foreach (var order in orders)
        {
            if (order.Car.Driver.Id == driverId)
            {
                totalAmount += order.Price;
            }
        }
        return totalAmount * 0.8m;
    }
}
