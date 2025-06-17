public class Car
{
    public string Number { get; set; }
    public string Color { get; set; }
    public Driver Driver { get; set; }

    public Car(string number, string color, Driver driver)
    {
        Number = number;
        Color = color;
        Driver = driver;
    }
}

