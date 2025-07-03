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
        List<Circle> circles = FindCircles(new Figure[] { circle, edge, polygon, edge2, circle2 });
        foreach (Circle c in circles)
        {
            Console.WriteLine($"Radius: {c.Radius}");
        }
    }

    //downcats при проверке фигур
    public static List<Circle> FindCircles(Figure[] figures)
    {
        List<Circle> result = new List<Circle>();
       foreach (Figure fig in figures)
        {
            if(fig is Circle circle)
            {
                result.Add(circle);
            }
        }
        return result;
    }
}
