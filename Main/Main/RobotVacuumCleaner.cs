using System;

public class RobotVacuumCleaner : SmartHouseDevice
{
    public override void TurnOn() => Console.WriteLine("Пылесос начал работу");
    public override void TurnOff() => Console.WriteLine("Пылесос выключен");
}
