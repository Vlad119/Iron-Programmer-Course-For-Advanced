using System;

public class UserRegisteredEventArgs : EventArgs
{
    public string Email { get; }

    public UserRegisteredEventArgs(string value)
    {
        Email = value;
    }
}
