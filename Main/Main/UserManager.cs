
using System.Collections.Generic;

public class UserManager
{
    public List<User> Users { get; } = new List<User>();

    public void Register(User user)
    {
        Users.Add(user);
    }
}
