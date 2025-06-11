using System;

class Program
{
    static void Main(string[] args)
    {
        double c = 25;
        bool IsSuccess = ConvertTemperature(c, out double f, out double k);
        Console.WriteLine($"Температура перешла абсолютный 0 со значением {IsSuccess}. F: {f}, K: {k}");
    }

    static bool ConvertTemperature(double c, out double f, out double k)
    {
        k = c + 273.15;
        f = (c * 1.8) + 32;
        if (c <= -273.15) return false;
        return true;
    }
}