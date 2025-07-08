using System;

internal class GeometricArea
{
    public double CalculateArea(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    public double CalculateArea(double a, double b)
    {
        return a * b;
    }

    public double CalculateArea(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}

