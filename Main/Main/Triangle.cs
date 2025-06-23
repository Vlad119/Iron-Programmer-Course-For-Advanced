public class Triangle
{
    private readonly double sideA, sideB, sideC;

    public Triangle(double a, double b, double c)
    {
        sideA = a; sideB = b; sideC = c;
    }

    public double Perimeter()
    {
        return sideA + sideB + sideC; 
    }
}
