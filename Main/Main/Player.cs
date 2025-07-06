
internal class Player
{
    public string Name { get; }
    public int Number { get; }
    public Player(string name, int number)
    {
        Name = name;
        Number = number;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (GetType() != obj.GetType()) return false;
        Player other = (Player)obj;
        return Name.Equals(other.Name) && Number.Equals(other.Number);
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }
}
