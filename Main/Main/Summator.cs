public class Summator
{
    protected virtual int Transform(int item)
    {
        return item; // Тождественное преобразование
    }

    public int Sum(int N)
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += Transform(i);
        }
        return sum;
    }
}