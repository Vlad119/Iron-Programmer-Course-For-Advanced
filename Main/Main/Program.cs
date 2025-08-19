using System;

public class Program
{
    static void Main(string[] args)
    {
        Flat[] flats =
        {
            new Flat { Number = 1, RoomsCount = 2 },
            new Flat { Number = 2, RoomsCount = 3 },
            new Flat { Number = 3, RoomsCount = 4 }
        };
        Entrance myEntrance = new Entrance(flats);
        foreach (Flat flat in myEntrance)
        {
            Console.WriteLine(flat);
        }
    }
}
