using System;

internal partial class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Josef", 26);
        User user2 = new User("Mark", 27);
        User[] users = { user1, user2 };
        UsersStorage usersStorage = new UsersStorage(users);
        foreach (var user in usersStorage)
        {
            Console.WriteLine(user.Name); 
        }
    }
}