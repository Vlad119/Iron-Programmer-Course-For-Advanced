public class UsersStorage 
{
    private readonly User[] users;
    public UsersStorage(User[] _users) => users = _users;
    public UsersStorageEnumerator GetEnumerator() => new UsersStorageEnumerator(users);
}
