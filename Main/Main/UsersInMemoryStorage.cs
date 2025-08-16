using System.Collections.Generic;

public class UsersInMemoryStorage : IUsersStorage
{
    private readonly List<User> users = new List<User>();

    public void Add(User user)
    {
        users.Add(user);
    }

    public List<User> GetAll()
    {
        return users;
    }

    public bool RemoveById(int id)
    {
        foreach (var user in users)
        {
            if (user.Id.Equals(id))
            {
                users.Remove(user);
                return true;
            }
        }
        return false;
    }

    public User TryGetById(int id)
    {
        foreach (var user in users)
        {
            if (user.Id.Equals(id)) return user;
        }
        return null;
    }

    public bool UpdateById(int id, string name, int age)
    {
        foreach (var user in users)
        {
            if (user.Id.Equals(id))
            {
                user.Name = name;
                user.Age = age;
                return true;
            }
        }
        return false;
    }
}
