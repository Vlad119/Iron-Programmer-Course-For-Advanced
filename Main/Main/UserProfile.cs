using System;

public class UserProfile
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Country { get; set; }

    public UserProfile(string name)
    {
        Name = name;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Имя: {Name??"Имя не указано"}"); 
        Console.WriteLine($"Пол: {Gender??"Пол не указан"}"); 
        Console.WriteLine($"Страна: {Country??"Страна не указана"}"); 
    }
}

