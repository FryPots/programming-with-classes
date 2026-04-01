using System;
public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comment> _comments; 

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }


}