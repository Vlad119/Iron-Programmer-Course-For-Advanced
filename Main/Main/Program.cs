using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            User user1 = new User("Josef", 25);
            User user2 = new User("Mark", 26);

            Console.WriteLine(user1 > user2);
            Console.WriteLine(user1 < user2);
        }
    }
}
