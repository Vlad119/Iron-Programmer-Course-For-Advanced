using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Circle circle = new Circle();
            circle.Radius = 10;
            circle.Center = new Point()
            {
                X_Position = 3.6,
                Y_Position = -2.5
            };
            circle.Layer = 3;
            circle.EdgeThickness = 3.4;
            circle.EdgeColor = "синий";
            circle.FillColor = "зелёный";
            Console.WriteLine($"Радиус:{circle.Radius}, X:{circle.Center.X_Position} Y:{circle.Center.Y_Position}");
            Console.WriteLine($"Слой:{circle.Layer}, Цвет границ:{circle.EdgeColor}, Толщина границ:{circle.EdgeThickness}, Цвет заливки:{circle.FillColor}");
        }
    }
}
