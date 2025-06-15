public class MyClass
{
    public string field1;
    public int field2;
    public bool field3;

    public MyClass(string s)
    {
        field1 = s;
        field2 = 0;
        field3 = false;
    }

    public MyClass(string s, int a)
    {
        field1 = s;
        field2 = a;
        field3 = false;
    }

    public MyClass(string s, int a, bool b)
    {
        field1 = s;
        field2 = a;
        field3 = b;
    }
}