namespace Main
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public static int Counter { get; set; } = 0;

        public Point(int x, int y)
        {
            Counter++;
            X = x;
            Y = y;
        }
    }
}