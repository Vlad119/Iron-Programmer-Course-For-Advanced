using System;

public class SmartLamp : SmartHouseDevice
{
    public string Color { get; set; }
    public override void TurnOn() => Console.WriteLine($"Лампа включена, цвет лампы - {Color}");
    public override void TurnOff() => Console.WriteLine("Лампа выключена");
}
