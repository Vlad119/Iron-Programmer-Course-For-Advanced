public class A
{
    public int Value { get; set; } = 1;

    public static A operator +(A a1, A a2)
    {
        return new A { Value = a1.Value + a2.Value };
    }

    public static A operator *(A a, string str)
    {
        return new A { Value = a.Value * str.Length };
    }

    public static implicit operator int(A a)
    {
        return a.Value;
    }
}