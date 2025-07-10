public class Post
{
    public int Id { get; set; }
    public int Likes { get; set; }
    public int Comments { get; set; }
    public int Views { get; set; }

    public static bool operator >(Post p1, Post p2)
    {
        return (double) (p1.Likes + p1.Comments * 5) / p1.Views > (double)(p2.Likes + p2.Comments * 5) / p2.Views;
    }

    public static bool operator <(Post p1, Post p2)
    {
        return (double)(p1.Likes + p1.Comments * 5) / p1.Views < (double)(p2.Likes + p2.Comments * 5) / p2.Views;
    }
}