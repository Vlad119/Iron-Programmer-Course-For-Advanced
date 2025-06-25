public class Community : User
{
    private string description;

    public Community(string name, string description) : base(name)
    {
        this.description = description;
    }

    public override string GetInfo()
    {
        return $"Имя={base.GetInfo().Split('=')[1]}, Описание={description}";
    }
}