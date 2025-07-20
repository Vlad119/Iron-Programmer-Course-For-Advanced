using System;

public struct Money
{
    private int ruble;
    private int kopeck;

    public int Ruble
    {
        get => ruble;
        set
        {
            if ((value < 0 && kopeck > 0) || (value > 0 && kopeck < 0))
                throw new Exception();
            ruble = value;
        }
    }

    public int Kopeck
    {
        get => kopeck;
        set
        {
            if (value < -99 || value > 99)
                throw new Exception();
            if ((value < 0 && ruble > 0) || (value > 0 && ruble < 0))
                throw new Exception();
            kopeck = value;
        }
    }

    public Money(int ruble, int kopeck)
    {
        this.ruble = 0;
        this.kopeck = 0;
        Ruble = ruble;
        Kopeck = kopeck;
    }

    public override string ToString()
    {
        string formattedRuble = (Ruble == 0 && Kopeck < 0) ? "-0" : Ruble.ToString();
        Ruble = Convert.ToInt32(formattedRuble);
        return $"{Ruble}, {Math.Abs(Kopeck):D2}";
    }
}