public class Player
{
    public string Name { get; }
    public int Number { get; }
    public Player(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public override string ToString()
    {
        return $"{Name} играет под номером {Number}";
    }
}