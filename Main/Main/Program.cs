using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            SmartHome smartHome = new SmartHome(24, true, false);
            Console.WriteLine(smartHome.Temperature);
            smartHome.SetTemperature(11);
            Console.WriteLine(smartHome.Temperature);
            smartHome.ArmSecuritySystem();
            Console.WriteLine(smartHome.IsSecuritySystemArmed);
            Console.WriteLine(smartHome.IsLightsOn);
        }
    }
}
