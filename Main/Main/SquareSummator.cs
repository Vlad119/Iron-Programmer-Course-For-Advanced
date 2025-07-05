public class SquareSummator : Summator
{
    protected override int Transform(int item)
    {
        return item * item; 
    }
}