using ExercicioStringBuilder.Entities;
using System;

namespace ExercicioStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's awesome!");
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");


            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("28/01/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.AddComment(c3);
            p2.AddComment(c4);
            /*
            Console.WriteLine($"{p1.Title}\n" +
                $"{p1.Likes} Likes - {p1.Moment}\n" +
                $"{p1.Content}\nComments:\n");
            foreach(Comment comment in p1.Comments)
            {
                Console.Write(comment.Text+"\n----------\n");
            }
            */

            WritePost(p1);
            Console.WriteLine();
            WritePost(p2);

        }

        static void WritePost(Post post)
        {
            Console.WriteLine($"{post.Title}\n" +
                    $"{post.Likes} Likes - {post.Moment}\n" +
                    $"{post.Content}\nComments:\n");
            foreach (Comment comment in post.Comments)
            {
                Console.Write(comment.Text + "\n----------\n");
            }
        }
    }
}
