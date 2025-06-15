namespace Main
{
    public class Dog
    {
        public string Name;
        public int age;
        public Dog(string _name, int _age)
        {
            Name = _name;
            age = _age;
        }
        public string GetDescription()
        {
            string s = $"{Name} is {age} years old";
            return s;
        }
        public string Speak(string sound)
        {
            string s = $"{Name} says {sound}";
            return s;
        }
    }
}
