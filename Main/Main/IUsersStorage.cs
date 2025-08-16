using System.Collections.Generic;

public interface IUsersStorage
{
    List<User> GetAll();
    User TryGetById(int id);
    void Add(User user);
    bool UpdateById(int id, string name, int age);
    bool RemoveById(int id);
}
