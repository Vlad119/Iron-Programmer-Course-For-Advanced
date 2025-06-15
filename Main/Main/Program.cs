internal class Program
{
    static void Main(string[] args)
    {
        MyClass m1 = new MyClass("test");
        MyClass m2 = new MyClass("test2", 4);
        MyClass m3 = new MyClass("test3", 4, false);
    }
}
