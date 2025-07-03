using System.Collections.Generic;
using System;

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(5, "r", -1, "d", new Point(3, 5), 4);
        Edge edge = new Edge(0, "t", 5.6, "d", new Point(1, 2), new Point(5, -4));
        Polygon polygon1 = new Polygon(3, "g", 6.5, "p", new List<Point> { new Point(5, 8), new Point(1, 7), new Point(4, 5) });
        Polygon polygon2 = new Polygon(2, "d", 6.7, "y", new List<Point> { new Point(1, -6), new Point(1, 6), new Point(5.6, 6), new Point(4, 7) });
        Polygon polygon = new Polygon(3, "d", 1.7, "k", new List<Point> { new Point(2, 3), new Point(5, 6), new Point(4, 9) });
        Edge edge2 = new Edge(1, "f", 7.8, "r", new Point(2, 3), new Point(4, -6));
        Circle circle2 = new Circle(89, "n", 3, "p", new Point(1, 7), 6);
        Figure[] figures = new Figure[] { circle, edge, circle2, polygon2, polygon, edge2, polygon1 };
        RepaintEdges(figures);
        Console.WriteLine(edge.EdgeColor);
        Console.WriteLine(edge2.EdgeColor);
    }

    private static void RepaintEdges(Figure[] figures)
    {
        foreach (Figure f in figures)
        {
            if(f is Edge edge)
            {
                edge.EdgeColor = "голубой";
            }
        }
    }
}
