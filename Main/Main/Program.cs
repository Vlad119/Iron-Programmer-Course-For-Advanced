using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Point point = new Point();
            point.X_Position = 2;
            point.Y_Position = 3.4;
            Console.WriteLine($"X:{point.X_Position} Y:{point.Y_Position}");
        }
    }
}
