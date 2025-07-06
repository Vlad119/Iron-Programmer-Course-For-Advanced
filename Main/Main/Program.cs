using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            User user1 = new User() { Name = "Josef" };
            User user2 = new User() { Name = "Jo" };
            Console.WriteLine(user1.Equals(user2));
            Console.WriteLine(user2.Equals(user1));
            Console.WriteLine(user1.Equals(user1));
            Console.WriteLine(user2.Equals(user2));
            Console.WriteLine(user1.GetHashCode() == user2.GetHashCode());
        }
    }
}

public class User
{
    public string Name { get; set; }
    public override string ToString()
    {
        return Name;
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (GetType() != obj.GetType()) return false;
        User other = (User)obj;
        return Name.Equals(other.Name);
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}