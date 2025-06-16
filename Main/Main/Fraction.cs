using System;

public class Fraction
{
    public int numerator;
    public int denominator;

    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public void Print()
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

    public Fraction Sum(Fraction otherFraction)
    {
        int commonDenominator = denominator * otherFraction.denominator;
        int resultNumerator = numerator * otherFraction.denominator + otherFraction.numerator * denominator;
        Fraction result = new Fraction(resultNumerator, commonDenominator);
        return result;
    }
    public Fraction Difference(Fraction otherFraction)
    {
        int commonDenominator = denominator * otherFraction.denominator;
        int resultNumerator = numerator * otherFraction.denominator - otherFraction.numerator * denominator;
        Fraction result = new Fraction(resultNumerator, commonDenominator);
        return result;
    }


    public Fraction Multiply(Fraction otherFraction)
    {
        Fraction result = new Fraction(numerator * otherFraction.numerator, denominator * otherFraction.denominator);
        return result;
    }

    public Fraction Divide(Fraction otherFraction)
    {
        Fraction result = new Fraction(numerator * otherFraction.denominator, denominator * otherFraction.numerator);
        return result;
    }

    public Fraction Sum(int number)
    {
        Fraction otherFraction = new Fraction(number, 1);
        Fraction result = Sum(otherFraction);
        return result;
    }

    public Fraction Difference(int number)
    {
        Fraction otherFraction = new Fraction(number, 1);
        Fraction result = Difference(otherFraction);
        return result;
    }

    public Fraction Multiply(int number)
    {
        Fraction otherFraction = new Fraction(number, 1);
        Fraction result = Multiply(otherFraction);
        return result;
    }

    public Fraction Divide(int number)
    {
        Fraction otherFraction = new Fraction(number, 1);
        Fraction result = Divide(otherFraction);
        return result;
    }
}