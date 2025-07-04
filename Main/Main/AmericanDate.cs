public class AmericanDate : BaseDate
{
    public AmericanDate(int year, int month, int day) : base(year, month, day)
    { }

    public override string GetFormat()
    {
        return $"{Month:00}.{Day:00}.{Year}";
    }
}
