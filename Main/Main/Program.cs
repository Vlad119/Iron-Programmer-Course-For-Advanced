using System;

internal partial class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Josef", 26);
        User user2 = new User("Mark", 27);
        User[] users = new User[] { user1, user2 };
        UsersStorage usersStorage = new UsersStorage(users);
        foreach (var user in usersStorage) // Ok
        {
            Console.WriteLine(((User)user).Name); // конвертация к User
        }
    }
}