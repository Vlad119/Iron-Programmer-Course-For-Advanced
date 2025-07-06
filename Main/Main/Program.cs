public class Program
{
    public static void Main()
    {
        Figure circle = new Circle(5, "голубой", -1, "чёрный", new Point(3, 5), 4);
        circle.Draw();
    }
}
