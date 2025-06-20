public class Matrix
{
    private int[,] numbers;
    public Matrix()
    {
        numbers = new int[,]
        {
            { 1, 2, 4 },
            { 2, 3, 6 },
            { 3, 4, 8 }
        };
    }

    public int this[int row, int col]
    {
        get { return numbers[row, col]; }
        set { numbers[row, col] = value; }
    }
}