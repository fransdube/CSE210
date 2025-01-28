using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    // Comment class to represent a comment on a video
    public class Comment
    {
        // Properties
        public string CommenterName { get; set; }
        public string CommentText { get; set; }

        // Constructor
        public Comment(string commenterName, string commentText)
        {
            CommenterName = commenterName;
            CommentText = commentText;
        }

        // Method to display comment details
        public override string ToString()
        {
            return $"{CommenterName}: {CommentText}";
        }
    }

    // Video class to represent a YouTube video
    public class Video
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        private List<Comment> Comments { get; set; }

        // Constructor
        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            Comments = new List<Comment>();
        }

        // Method to add a comment
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        // Method to return the number of comments
        public int GetNumberOfComments()
        {
            return Comments.Count;
        }

        // Method to display video details and comments
        public void DisplayVideoDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment}");
            }
            Console.WriteLine();
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create videos
            Video video1 = new Video("C# Tutorial", "John Doe", 600);
            Video video2 = new Video("OOP Principles", "Jane Smith", 1200);
            Video video3 = new Video("Advanced C#", "Alice Johnson", 1800);

            // Add comments to video1
            video1.AddComment(new Comment("User1", "Great tutorial!"));
            video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
            video1.AddComment(new Comment("User3", "I learned a lot."));

            // Add comments to video2
            video2.AddComment(new Comment("User4", "Nice explanation of OOP."));
            video2.AddComment(new Comment("User5", "Could you make more videos like this?"));

            // Add comments to video3
            video3.AddComment(new Comment("User6", "Advanced concepts explained well."));
            video3.AddComment(new Comment("User7", "This is exactly what I needed."));

            // Create a list of videos
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Display details for each video
            foreach (var video in videos)
            {
                video.DisplayVideoDetails();
            }
        }
    }
}