using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main()
    {
        IUsersStorage usersStorage = new UsersInMemoryStorage();
        List<User> users = usersStorage.GetAll();
        Console.WriteLine(users.Count == 0);

        User user = usersStorage.TryGetById(5);
        Console.WriteLine(user == null);

        usersStorage.Add(new User { Id = 1, Name = "Josef", Age = 26 });
        usersStorage.Add(new User { Id = 2, Name = "Mark", Age = 27 });
        Console.WriteLine(users.Count == 2);

        user = usersStorage.TryGetById(2);
        Console.WriteLine(user.Name == "Mark");

        Console.WriteLine(usersStorage.UpdateById(2, "Andrew", 27));
        Console.WriteLine(usersStorage.RemoveById(2));
    }
}
