public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    public static string operator *(Fraction f1, Fraction f2)
    {
        return $"{f1.Numerator * f2.Numerator}/{f1.Denominator * f2.Denominator}";
    }

}