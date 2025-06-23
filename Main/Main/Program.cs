using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Figure figure = new Figure();
            figure.Layer = 1;
            Console.WriteLine($"Слой:{figure.Layer}, Цвет границ:{figure.EdgeColor}, Толщина границ:{figure.EdgeThickness}, Цвет заливки:{figure.FillColor}");
            figure.EdgeThickness = 3.4;
            figure.EdgeColor = "красный";
            figure.FillColor = "зелёный";
            Console.WriteLine($"Слой:{figure.Layer}, Цвет границ:{figure.EdgeColor}, Толщина границ: {figure.EdgeThickness}, Цвет заливки:{figure.FillColor}");
        }
    }
}
