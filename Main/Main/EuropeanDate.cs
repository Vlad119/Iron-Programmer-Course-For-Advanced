public class EuropeanDate : BaseDate
{
    public EuropeanDate(int year, int month, int day) : base(year, month, day)
    { }

    public override string GetFormat()
    {
        return $"{Day:00}.{Month:00}.{Year}";
    }
}
