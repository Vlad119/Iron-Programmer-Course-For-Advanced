public class Team
{
    private Player[] players;

    public Team()
    {
        players = new Player[10]; 
    }

    public Player this[int index]
    {
        get
        {
            return players[index];
        }
        set
        {
            players[index] = value;
        }
    }
}