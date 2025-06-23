using System;
using System.Collections.Generic;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Polygon polygon = new Polygon();
            polygon.Layer = 0;
            polygon.EdgeThickness = 2.4;
            polygon.EdgeColor = "красный";
            polygon.FillColor = "белый";
            polygon.Points = new List<Point>()
            { new Point()
            { X_Position = 5.6, Y_Position = 3.4 },
            new Point()
            { X_Position = 6.7, Y_Position = 2.4 },
            new Point()
            { X_Position = 5.1, Y_Position = 2.4 },
            new Point()
            { X_Position = 2.2, Y_Position = 7.1 }};
            foreach (Point p in polygon.Points)
            {
                Console.WriteLine($"X:{p.X_Position} Y:{p.Y_Position}");
            }
            Console.WriteLine($"Слой:{polygon.Layer}, Цвет границ:{polygon.EdgeColor}, Толщина границ:{polygon.EdgeThickness}, Цвет заливки:{polygon.FillColor}");
        }
    }
}
