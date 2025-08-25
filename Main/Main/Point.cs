using System;

public class Point : IEquatable<Point>
{
    public double Latitude { get; set; } // Широта
    public double Longitude { get; set; } // Долгота
    public Point(double Latitude, double Longitude)
    {
        this.Latitude = Latitude;
        this.Longitude = Longitude;
    }
    public override string ToString()
    {
        return $" Координаты точки: {Latitude} широты, {Longitude} долготы";
    }

    public bool Equals(Point other)
    {
        return Math.Abs(Latitude - other.Latitude) <= 5 && Math.Abs(Longitude - other.Longitude) <= 5;
    }
}