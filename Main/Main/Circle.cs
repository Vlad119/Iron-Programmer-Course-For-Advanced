public sealed class Circle : Figure
{
    public double Radius { get; set; }

    public Point Center { get; set; }

    public Circle()
    {
        Radius = 0;
        Center = new Point(); 
    }
}