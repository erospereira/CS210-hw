// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video 1 Title", "Author 1", 120);
        video1.AddComment("Commenter 1", "This is a comment.");
        video1.AddComment("Commenter 2", "Another comment here.");

        Video video2 = new Video("Video 2 Title", "Author 2", 180);
        video2.AddComment("Commenter 3", "Comment on video 2.");
        video2.AddComment("Commenter 1", "Another comment on video 2.");

        // Create a list of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }
    }
}
