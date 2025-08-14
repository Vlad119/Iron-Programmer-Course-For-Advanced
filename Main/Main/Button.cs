using System;

public class Button
{
    private string identity;
    public event EventHandler<ButtonClickedEventArgs> ClickHandler;
    public Button(string identity)
    {
        this.identity = identity;
    }

    public void Clicked()
    {
        ClickHandler?.Invoke(this, new ButtonClickedEventArgs(identity));
    }
}

