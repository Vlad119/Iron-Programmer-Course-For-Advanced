using System;

internal class Program
{
    public static void Main()
    {
        UserManager userManager = new UserManager();
        userManager.Register(new User("Алексей", "a.potapov@gmail.com", "qwerty123"));
        Console.WriteLine($"Пользователь {userManager.Users[0].Name} зарегистрирован");
    }
}
