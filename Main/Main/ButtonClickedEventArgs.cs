using System;

public class ButtonClickedEventArgs : EventArgs
{
    public string Location { get; }
    public int Number { get; }

    public ButtonClickedEventArgs(string value)
    {
        string[] split = value.Split('#');
        Location = split[0];
        Number = int.Parse(split[1]);
    }
}
