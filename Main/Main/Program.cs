using System;

internal class Program
{
    public static void Main()
    {
        var user = new User()
        {
            Id = 1,
            Name = "Ivan",
            Age = 25
        };
        Console.WriteLine($"Id = {user.Id}, Name = {user.Name}, Age = {user.Age}");
    }
}
