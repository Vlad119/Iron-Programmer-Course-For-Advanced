using System.Collections.Generic;
using System;

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(2, "red", 1, "white", new Point(3, 5), 4);
        Edge edge = new Edge(0, "black", 5.6, "black", new Point(1, 2), new Point(5, -4));
        Polygon polygon = new Polygon(3, "blue", 6.7, "green", new List<Point> { new Point(2, 3), new Point(5, 6), new Point(4, 5) });
        Edge edge2 = new Edge(1, "black", 7.8, "black", new Point(2, 3), new Point(4, -6));
        Circle circle2 = new Circle(9, "yellow", 3, "black", new Point(1, 7), 6);
        Figure nearestFigure = FindNearestFigure(new Figure[] { circle, edge, polygon, edge2, circle2 });
        Console.WriteLine($"Слой:{nearestFigure.Layer}, Цвет границ:{nearestFigure.EdgeColor}, Толщина границ:{nearestFigure.EdgeThickness}, Цвет заливки:{nearestFigure.FillColor}");
    }


    public static Figure FindNearestFigure(Figure[] figures)
    {
        if (figures == null || figures.Length == 0)
        {
            return null; 
        }
        Figure nearestFigure = figures[0];
        foreach (var figure in figures)
        {
            if (figure.Layer > nearestFigure.Layer)
            {
                nearestFigure = figure; 
            }
        }
        return nearestFigure;
    }
}
