using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLengthInSeconds() => _lengthInSeconds;
    public int GetNumberOfComments() => _comments.Count;

    public string GetDisplayText()
    {
        return $"Title: {_title}";
    }
}