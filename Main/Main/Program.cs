using System;

internal class Program
{
    static void Main(string[] args)
    {
        //Money money1 = new Money(10, 50);
        //Console.WriteLine(money1);

        //money1.Ruble = 4;
        //money1.Kopeck = 5;
        //Console.WriteLine(money1);

        //money1.Kopeck = 100;

        //Money money2 = new Money(10, -50);

        Money money3 = new Money(-10, -50);
        Console.WriteLine(money3);


        Money money4 = new Money(0, -20);
        Console.WriteLine(money4);
    }
}
