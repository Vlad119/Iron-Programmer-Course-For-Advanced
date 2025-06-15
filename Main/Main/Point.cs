using System;

namespace Main
{
    public class Point
    {
        public double x, y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public string Print()
        {
            string s = $"({x},{y})";
            return s;
        }
        public double CalculateDistance(Point otherPoint)
        {
            double distance = Math.Sqrt(Math.Pow(x - otherPoint.x, 2) + Math.Pow(y - otherPoint.y, 2));
            return distance;
        }
    }
}
