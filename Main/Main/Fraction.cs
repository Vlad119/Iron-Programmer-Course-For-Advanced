using System;

public class Fraction
{
    public readonly int Numerator; // числитель
    public readonly int Denominator; // знаменатель
    public readonly double Value; // значение дроби

    public Fraction(int num, int den)
    {
        if (den <= 0)
        {
            throw new ArgumentException("Знаменатель должен быть больше 0!");
        }
        Numerator = num;
        Denominator = den;
        Value = (double)num / den;
    }
}