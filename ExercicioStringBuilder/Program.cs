using ExercicioStringBuilder.Entities;
using System;

namespace ExercicioStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;
            string title = "Traveling to New Zealand";
            string content = "I'm going to visit this wonderful country!";
            int likes = 12;
            Post post1 = new Post(moment, title, content, likes);

            Console.WriteLine("Título: "+ post1.Title
                + "\nContent: "+ post1.Content
                + "\nLikes: "+ post1.Likes);
        }
    }
}
