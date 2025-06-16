public class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(1, 2);
        fraction1.Print();
        Fraction result = fraction1.Sum(1);
        result.Print(); // 3/2
        result = fraction1.Difference(1);
        result.Print(); // -1/2
        result = fraction1.Multiply(2);
        result.Print(); // 2/2
        result = fraction1.Divide(2);
        result.Print(); // 1/4
    }
}
