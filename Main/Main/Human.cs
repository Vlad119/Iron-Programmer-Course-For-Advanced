using System.Collections.Generic;

namespace Main
{
    public class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        private static readonly Dictionary<string, string> dict = new Dictionary<string, string>()
    {
        { "Брюс Уейн", "Бэтмен" },
        { "Питер Паркер", "Человек-паук" },
        { "Кларк Кент" , "Супермен" }
    };

        public static implicit operator SuperHero(Human human)
        {
            string superheroName = dict.TryGetValue(human.Name, out string name) ? name : "Призрачный гонщик";
            return new SuperHero(superheroName);
        }
    }
}
