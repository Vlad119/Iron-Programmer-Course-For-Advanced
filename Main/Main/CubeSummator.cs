public class CubeSummator : Summator
{
    protected override int Transform(int item)
    {
        return item * item * item; 
    }
}