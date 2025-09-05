using System;

internal class Program
{
    static void Main(string[] args)
    {
        var artistData = ("Пабло Пикассо", "Мона Лиза", 1503);
        artistData.Item1 = "Леонардо да Винчи";
        Console.WriteLine(artistData);
    }
}