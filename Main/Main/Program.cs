using System;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            User user = (User)age;
            Console.WriteLine(user.Name + " " + user.Age);
            User user2 = new User("Josef", 26);
            int age2 = user2;
            Console.WriteLine(age2);
        }
    }
}
