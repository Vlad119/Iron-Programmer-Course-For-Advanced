public class UsersStorageEnumerator
{
    private readonly User[] users;
    private int currentIndex = -1;
    public User Current => users[currentIndex];
    public UsersStorageEnumerator(User[] _users) => users = _users;
    public void Reset() => currentIndex = -1;
    public bool MoveNext()
    {
        currentIndex++;
        if (currentIndex >= users.Length)
        {
            return false;
        }
        return true;
    }
}
