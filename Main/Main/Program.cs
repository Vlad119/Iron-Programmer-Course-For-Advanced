internal class Program
{
    static void Main(string[] args)
    {
        SmartHouseDevice smartLamp = new SmartLamp() { Color = "красный" };
        SmartHouseDevice robotVacuumCleaner = new RobotVacuumCleaner();
        smartLamp.TurnOn();
        smartLamp.TurnOff();
        robotVacuumCleaner.TurnOn();
        robotVacuumCleaner.TurnOff();
    }
}
