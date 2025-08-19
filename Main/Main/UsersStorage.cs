using System.Collections;

public class UsersStorage : IEnumerable
{
    private readonly User[] users;

    public UsersStorage(User[] users)
    {
        this.users = users;
    }

    public IEnumerator GetEnumerator()
    {
        return new UsersStorageEnumerator(users);
    }
}
