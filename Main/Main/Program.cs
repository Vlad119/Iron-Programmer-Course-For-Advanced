using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Edge edge = new Edge();
            edge.FirstPoint = new Point()
            {
                X_Position = 2.3,
                Y_Position = 3.5
            };
            edge.SecondPoint = new Point()
            {
                X_Position = 3.5,
                Y_Position = 7.3
            };
            edge.Layer = -4;
            edge.EdgeThickness = 7.2;
            edge.EdgeColor = "красный";
            Console.WriteLine($"X:{edge.FirstPoint.X_Position} Y:{edge.FirstPoint.Y_Position}");
            Console.WriteLine($"X:{edge.SecondPoint.X_Position} Y:{edge.SecondPoint.Y_Position}");
            Console.WriteLine($"Слой:{edge.Layer}, Цвет границ:{edge.EdgeColor}, Толщина границ:{ edge.EdgeThickness}, Цвет заливки:{ edge.FillColor}");
}
    }
}
