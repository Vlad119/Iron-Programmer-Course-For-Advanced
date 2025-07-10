using System;
using System.Collections.Generic;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            List<Post> posts = new List<Post>()
    {
        new Post() { Id = 1, Likes = 240, Comments = 120, Views = 300},
        new Post() { Id = 2, Likes = 210, Comments = 60, Views = 300},
        new Post() { Id = 3, Likes = 150, Comments = 45, Views = 300}
    };

            Post newPost = new Post() { Id = 4, Likes = 70, Comments = 20, Views = 100 };

            foreach (var post in posts)
            {
                Console.WriteLine(newPost < post);
                Console.WriteLine(newPost > post);
            }
        }
    }
}
