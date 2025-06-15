using System;

public class FootballPlayer
{
    public string name, surname;
    public int goals, assists;

    public FootballPlayer(string _name, string _surname)
    {
        name = _name;
        surname = _surname;
        goals = assists = 0;
    }

    public void AddScore(int _goals)
    {
        goals += _goals;
    }

    public void AddAssists(int _assists)
    {
        assists += _assists;
    }

    public void ShowStatistics()
    {
        Console.WriteLine($"{surname} {name} - голы: {goals}, передачи: {assists}");
    }
}