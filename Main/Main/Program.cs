using System;

public class Program
{
    static void Main(string[] args)
    {
        Flat[] flats =
        {
            new Flat { Number = 1, RoomsCount = 2 },
            new Flat { Number = 2, RoomsCount = 3 },
            new Flat { Number = 26, RoomsCount = 1 }
        };
        Entrance entrance = new Entrance(flats);
        foreach (var item in entrance)
        {
            Console.WriteLine(item.Number);
        }
    }
}
