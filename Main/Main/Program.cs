using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            User user = new User("Josef");
            Console.WriteLine(user.GetInfo());
            user.SendMessage(user, "123");
            user.Post("123123");

            Person person = new Person("Josef", 15);
            Console.WriteLine(person.GetInfo());
            person.SendMessage(person, "123");
            person.Post("123123");
            person.Subscribe(person);

            Community community = new Community("Josef", "desc");
            Console.WriteLine(community.GetInfo());
            community.SendMessage(community, "123");
            community.Post("123123");
        }
    }
}
