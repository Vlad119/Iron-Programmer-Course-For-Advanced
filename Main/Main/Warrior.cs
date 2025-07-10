using System.Collections.Generic;

public class Warrior
{
    public string Element { get; set; }
    public int Level { get; set; }

    public Warrior(string element, int level)
    {
        Element = element;
        Level = level;
    }

    private static readonly Dictionary<string, string> oppositeElements = new Dictionary<string, string>()
    {
        { "Вода", "Огонь" },
        { "Огонь", "Вода" },
        { "Земля", "Воздух" },
        { "Воздух", "Земля" }
    };

    public static Warrior operator !(Warrior warrior)
    {
        if (!oppositeElements.ContainsKey(warrior.Element))
        return warrior = null;
        string oppositeElement = oppositeElements[warrior.Element];
        return new Warrior(oppositeElement, warrior.Level + 2);
    }

    public override string ToString()
    {
        return $"Уровень:{Level} Стихия:{Element}";
    }
}