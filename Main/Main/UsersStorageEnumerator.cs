using System.Collections;

public class UsersStorageEnumerator : IEnumerator
{
    private readonly User[] users;
    private int currentIndex = -1;
    public object Current => users[currentIndex];

    public UsersStorageEnumerator(User[] users)
    {
        this.users = users;
    }

    public bool MoveNext()
    {
        currentIndex++;
        if (currentIndex >= users.Length)
        {
            return false;
        }
        return true;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
}
