using System;

internal class Program
{
    static void Main(string[] args)
    {
        ButtonClickedEventArgs buttonClickedEventArgs = new ButtonClickedEventArgs("Подвал#4");
        Console.WriteLine($"Название комнаты: {buttonClickedEventArgs.Location}");
        Console.WriteLine($"Номер кнопки: {buttonClickedEventArgs.Number}");
    }
}
