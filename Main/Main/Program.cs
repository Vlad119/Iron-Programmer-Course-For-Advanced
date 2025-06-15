internal class Program
{
    public static void Main()
    {
        FootballPlayer player1 = new FootballPlayer("Cristiano", "Ronaldo");
        player1.AddScore(711);
        player1.AddAssists(169);
        player1.ShowStatistics();

        FootballPlayer player2 = new FootballPlayer("Lionel", "Messi");
        player2.AddScore(682);
        player2.AddAssists(240);
        player2.ShowStatistics();
    }
}
