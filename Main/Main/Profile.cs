
using System;

internal class Profile
{
    public string Name { get; set; }
    public Profile(string name)
    {
        Name = name;
    }

    protected virtual string GetInfo()
    {
        return string.Empty;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"{Name}, {GetInfo()}");
    }
}

