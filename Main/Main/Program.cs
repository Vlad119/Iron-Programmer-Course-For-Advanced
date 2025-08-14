using System;

internal class Program
{
    static void Main(string[] args)
    {
        Button button = new Button("Столовая#4");
        button.ClickHandler += (object sender, ButtonClickedEventArgs e) =>
        {
            Console.WriteLine($"Нажата кнопка в локации: {e.Location}, с номером {e.Number}");
        };
        button.Clicked();
    }
}
