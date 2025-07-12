using System.Collections.Generic;

namespace Main
{
    public class SuperHero
    {
        public string Name { get; set; }

        public SuperHero(string name)
        {
            Name = name;
        }

        private static readonly Dictionary<string, string> dict = new Dictionary<string, string>()
    {
        { "Бэтмен", "Брюс Уейн" },
        { "Человек-паук", "Питер Паркер" },
        { "Супермен", "Кларк Кент" }
    };

        public static explicit operator Human(SuperHero hero)
        {
            string humanName = dict.TryGetValue(hero.Name, out string name) ? name : "Николас Кейдж";
            return new Human(humanName);
        }
    }
}
