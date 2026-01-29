using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("Introduction to C# Programming", "John Doe", 420);
        video1.AddComment(new Comment("Alice Smith", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Bob Johnson", "Could you make a video on advanced topics?"));
        video1.AddComment(new Comment("Carol White", "Thanks for sharing. Clear explanations!"));
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("Building Web Applications with ASP.NET", "Jane Smith", 680);
        video2.AddComment(new Comment("David Brown", "Excellent content. Well organized."));
        video2.AddComment(new Comment("Emma Davis", "This helped me pass my exam!"));
        video2.AddComment(new Comment("Frank Wilson", "More examples would be nice."));
        video2.AddComment(new Comment("Grace Lee", "Amazing work! Keep it up!"));
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("Object-Oriented Programming Concepts", "Mike Anderson", 540);
        video3.AddComment(new Comment("Henry Taylor", "Finally understand encapsulation!"));
        video3.AddComment(new Comment("Isabel Martinez", "Could you explain polymorphism more?"));
        video3.AddComment(new Comment("Jack Robinson", "Best OOP tutorial on YouTube."));
        videos.Add(video3);

        // Create Video 4
        Video video4 = new Video("Data Structures and Algorithms", "Sarah Johnson", 720);
        video4.AddComment(new Comment("Karen Clark", "This is exactly what I needed!"));
        video4.AddComment(new Comment("Leo Harris", "Great explanations of complex topics."));
        video4.AddComment(new Comment("Maria Garcia", "Please make more videos like this."));
        video4.AddComment(new Comment("Nathan King", "Subscribed after watching this!"));
        videos.Add(video4);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();
            Console.WriteLine("Comments:");

            // Display all comments for this video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
    }
}