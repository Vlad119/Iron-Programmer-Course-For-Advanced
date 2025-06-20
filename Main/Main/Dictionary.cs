public class Dictionary
{
    private Word[] words;
    public Dictionary()
    {
        words = new Word[]
        {
            new Word("red", "красный"),
            new Word("blue", "синий"),
            new Word("green", "зеленый")
        };
    }

    public string this[string source]
    {
        get
        {
            foreach (var word in words)
            {
                if (word.Source == source)
                {
                    return word.Target;
                }
            }
            return null; 
        }
        set
        {
            foreach (var word in words)
            {
                if (word.Source == source)
                {
                    word.Target = value;
                    break;
                }
            }
        }
    }
}