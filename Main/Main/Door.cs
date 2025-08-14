using System;

public class Door
{
    //private void Open(object sender, ButtonClickedEventArgs e)
    //{
    //    Console.WriteLine($"Дверь открыта кнопкой с номером {e.Number} в комнате {e.Location}");
    //}

    public void Init(Button button)
    {
        button.ClickHandler += (sender, e) =>
        {
            Console.WriteLine($"Дверь открыта кнопкой с номером {e.Number} в комнате {e.Location}");
        };
    }
}
