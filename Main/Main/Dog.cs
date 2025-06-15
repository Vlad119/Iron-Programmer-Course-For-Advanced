namespace Main
{
    public class Dog
    {
        public string name;
        public int age;
        public Dog(string _name, int _age)
        {
            name = _name;
            age = _age;
        }
        public string GetDescription()
        {
            string s = $"{name} is {age} years old";
            return s;
        }
        public string Speak(string sound)
        {
            string s = $"{name} says {sound}";
            return s;
        }
    }
}
