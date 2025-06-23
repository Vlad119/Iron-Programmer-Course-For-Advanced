public sealed class Edge : Figure
{
    public Point FirstPoint { get; set; } = new Point();
    public Point SecondPoint { get; set; } = new Point();

    public new string FillColor { get; } = "чёрный";
}
