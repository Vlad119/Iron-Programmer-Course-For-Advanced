using System.Collections.Generic;
using System;

public class Program
{
    public static void Main()
    {
        var edge = new Edge(1, "красный", 2.5, "синий", new Point { X_Position = 0, Y_Position = 0 }, new Point { X_Position = 1, Y_Position = 1 });
        Console.WriteLine($"Layer: {edge.Layer}, EdgeColor: {edge.EdgeColor}, EdgeThickness: {edge.EdgeThickness}, FillColor: {edge.FillColor}");

        var circle = new Circle(2, "зелёный", 1.5, "жёлтый", new Point { X_Position = 5, Y_Position = 5 }, 3);
        Console.WriteLine($"Layer: {circle.Layer}, EdgeColor: {circle.EdgeColor}, EdgeThickness: {circle.EdgeThickness}, FillColor: {circle.FillColor}");

        var polygon = new Polygon(3, "фиолетовый", 3.0, "оранжевый", new List<Point>
        {
            new Point { X_Position = 0, Y_Position = 0 },
            new Point { X_Position = 1, Y_Position = 1 },
            new Point { X_Position = 2, Y_Position = 0 }
        });
        Console.WriteLine($"Layer: {polygon.Layer}, EdgeColor: {polygon.EdgeColor}, EdgeThickness: {polygon.EdgeThickness}, FillColor: {polygon.FillColor}");
    }
}