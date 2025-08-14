using System;

internal class Program
{
    static void Main(string[] args)
    {
        Button button = new Button("Столовая#4");
        Door doorA = new Door();
        Door doorB = new Door();
        doorA.Init(button);
        doorB.Init(button);
        button.Clicked();
    }
}
