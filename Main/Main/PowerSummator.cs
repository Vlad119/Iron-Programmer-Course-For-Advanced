using System;

public class PowerSummator : Summator
{
    private readonly int _power;

    public PowerSummator(int power)
    {
        _power = power;
    }

    protected override int Transform(int item)
    {
        return (int)Math.Pow(item, _power);
    }
}