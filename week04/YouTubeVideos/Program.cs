using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("How to Code in C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Eve", "Can you make a video on Java?"));
        
        Video video2 = new Video("Learn Python in 10 Minutes", "Jane Smith", 600);
        video2.AddComment(new Comment("Charlie", "This was awesome!"));
        video2.AddComment(new Comment("Dave", "I learned a lot, thanks!"));
        video2.AddComment(new Comment("Frank", "Can you make a video on JavaScript?"));

        Video video3 = new Video("Introduction to Machine Learning", "Dr. AI", 900);
        video3.AddComment(new Comment("Grace", "This is so informative!"));
        video3.AddComment(new Comment("Heidi", "I can't wait to learn more about ML!"));
        video3.AddComment(new Comment("Ivan", "Can you make a video on Deep Learning?"));

        List<Video> myVideos = new List<Video> { video1, video2, video3 };

        foreach (Video video in myVideos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}