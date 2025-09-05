using System;

internal class Program
{
    static void Main(string[] args)
    {
        var dog = new Pet("Альфред", "Золотистый ретривер", 3);
        Console.WriteLine(dog);
    }
}

public record Pet(string Name, string Type, int Age);

//public record Pet
//{
//    // Имя
//    public string Name { get; init; }
//    // Вид животного 
//    public string Type { get; init; }
//    // Возраст
//    public int Age { get; init; }

//    public Pet(string name, string type, int age)
//    {
//        Name = name;
//        Type = type;
//        Age = age;
//    }
//}