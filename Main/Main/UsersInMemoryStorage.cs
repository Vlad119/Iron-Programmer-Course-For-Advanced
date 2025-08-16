using System.Collections.Generic;

public class UsersInMemoryStorage : IUsersStorage
{
    List<User> users = new List<User>();

    public void Add(User user)
    {
        users.Add(user);
    }

    public List<User> GetAll()
    {
        return users;
    }

    public User TryGetById(int id)
    {
        foreach (var user in users)
        {
            if (user.Id == id) return user;
        }
        return null;
    }
}
