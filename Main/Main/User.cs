public class User
{
    private string name;
    public User(string name)
    {
        this.name = name;
    }

    public void SendMessage(User user, string message)
    { }

    public void Post(string message)
    { }

    public virtual string GetInfo()
    {
        return $"Имя={name}";
    }
}