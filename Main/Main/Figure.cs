﻿using System;

public class Figure
{
    public int Layer { get; set; }
    public string EdgeColor { get; set; } = "чёрный";
    public double EdgeThickness { get; set; } = 1;
    public string FillColor { get; set; } = "белый";

    public Figure(int layer, string edgeColor, double edgeThickness, string fillColor)
    {
        Layer = layer;
        EdgeColor = edgeColor;
        EdgeThickness = edgeThickness;
        FillColor = fillColor;
    }

    public virtual void Draw()
    {
        Console.WriteLine($"Отрисовка фигуры... Слой:{Layer}, Цвет границ:{EdgeColor}, Толщина границ:{EdgeThickness:F1}, Цвет заливки:{FillColor}");
    }
}