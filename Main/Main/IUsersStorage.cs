using System.Collections.Generic;

public interface IUsersStorage
{
    List<User> GetAll();
    User TryGetUser(int id);
    void Add(User user);
}
