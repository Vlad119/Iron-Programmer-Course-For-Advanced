using System;

public class Program
{
    public static void Main()
    {
        Driver driverA = new Driver("Иван", "Иванов", 34);
        Driver driverB = new Driver("Алексей", "Алексеев", 30);
        Driver driverC = new Driver("Пётр", "Петров", 25);
        Car carA = new Car("O123MP", "Красный", driverA);
        Car carB = new Car("M456XC", "Синий", driverB);
        Car carC = new Car("K789BA", "Белый", driverC);
        Client clientA = new Client("Григорий", "Григорьев", 21, "1234123412341234");
        Client clientB = new Client("Семён", "Семёнов", 45, "1111222233334444");
        Client clientC = new Client("Владимир", "Владимиров", 29, "5678567856785678");
        Order orderA = new Order(clientA, 200, carA);
        Order orderB = new Order(clientB, 150);
        Order orderC = new Order(clientC, 500, carC);
        orderC.Car = carB;
        orderC.Client = clientA;
        orderC.Price = 300;
        string carNumber = orderA.Car == null ? "Нет машины" : orderA.Car.Number;
        Console.WriteLine($"Заказ A: {orderA.Client.LastName} {orderA.Price} {carNumber}");
        carNumber = orderB.Car == null ? "Нет машины" : orderB.Car.Number;
        Console.WriteLine($"Заказ B: {orderB.Client.LastName} {orderB.Price} {carNumber}");
        carNumber = orderC.Car == null ? "Нет машины" : orderC.Car.Number;
        Console.WriteLine($"Заказ C: {orderC.Client.LastName} {orderC.Price} {carNumber}");
    }
}
