using System;

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
            if (index < 0 || index >= players.Length)
            {
                throw new Exception("Ошибка");
            }
            return players[index];
        }
        set
        {
            if (index < 0 || index >= players.Length)
            {
                throw new Exception("Ошибка");
            }
            players[index] = value;
        }
    }
}