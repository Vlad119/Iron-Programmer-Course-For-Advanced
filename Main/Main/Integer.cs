using System;

class Integer
{
    private int value;
    public Integer(int n)
    {
        value = n;
    }

    public void Print()
    {
        Console.WriteLine($"value: {value}");
    }

    public static int operator *(Integer integer, int number)
    {
        return integer.value * number;
    }

    public static double operator *(Integer integer, double number)
    {
        return integer.value * number;
    }
}