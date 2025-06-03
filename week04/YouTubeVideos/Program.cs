using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        var video1 = new Video("C# Tutorial", "Alice", 560);
        var video2 = new Video("Rice Washing", "Bob", 310);
        var video3 = new Video("Hiking With Kids", "Charlie", 750);

       
        video1._comments.Add(new Comment("Peter", "This is a great video!"));
        video1._comments.Add(new Comment("James", "Wow! This is amazing!"));
        video1._comments.Add(new Comment("John", "Great tutorial!"));

        
        video2._comments.Add(new Comment("Ace", "I love this donut!"));
        video2._comments.Add(new Comment("Luffy", "Meat meat meat!"));
        video2._comments.Add(new Comment("Usopp", "I burned my tongue!"));

        
        video3._comments.Add(new Comment("Aldous", "Labyrinth keeper!"));
        video3._comments.Add(new Comment("Layla", "Time to shine!"));
        video3._comments.Add(new Comment("Balmond", "Let's go!"));

        // Create a list of videos
        var videos = new List<Video> { video1, video2, video3 };

        // Display info for each video
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"  {comment.GetDisplayText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}