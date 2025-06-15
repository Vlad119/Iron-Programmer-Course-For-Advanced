public class Phone
{
    public string Name; 
    public int Price; 
    public int Memory; 
    public bool IsAvailable; 

    public Phone(string name)
    {
        Name = name;
        Price = 5000;
        Memory = 8;
        IsAvailable = true;
    }

    public Phone(string name, int price)
    {
        Name = name;
        Price = price;
        Memory = 8;
        IsAvailable = true;
    }

    public Phone(string name, int price, int memory)
    {
        Name = name;
        Price = price;
        Memory = memory;
        IsAvailable = true;
    }
    public Phone(string name, int price, int memory, bool isAvailable)
    {
        Name = name;
        Price = price;
        Memory = memory;
        IsAvailable = isAvailable;
    }
}