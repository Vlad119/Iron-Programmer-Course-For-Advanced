using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ColorTranslate(Colors.Red, Languages.Russian));
        Console.WriteLine(ColorTranslate(Colors.Red, Languages.English));
    }

    public static string ColorTranslate(Colors color, Languages language)
    {
        switch (color)
        {
            case Colors.Red: return language == Languages.Russian ? "Красный" : "Red";
            case Colors.Black: return language == Languages.Russian ? "Черный" : "Black";
            case Colors.Yellow: return language == Languages.Russian ? "Желтый" : "Yellow";
            case Colors.White: return language == Languages.Russian ? "Белый" : "White";
        }

        return null;
    }

    public enum Colors
    {
        Red,
        Black,
        Yellow,
        White
    }

    public enum Languages
    {
        English,
        Russian
    }
}