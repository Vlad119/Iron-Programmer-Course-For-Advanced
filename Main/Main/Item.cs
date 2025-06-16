using System;

public class Item
{
    public string name;
    public int weight;
    public string specialAbility;

    public Item() : this("", 0, "")
    { }

    public Item(string name, int weight) : this(name, weight, "")
    { }

    public Item(string name, int weight, string specialAbility)
    {
        this.name = name;
        this.weight = weight;
        this.specialAbility = specialAbility;
    }

    public void ShowItem()
    {
        Console.WriteLine($"{name}:{weight}({specialAbility})");
    }
}