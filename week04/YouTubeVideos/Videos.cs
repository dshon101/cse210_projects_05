using System;
using System.Collections.Generic;

// Video class - Represents a YouTube video with comments
public class Video
{
    // Private member variables (encapsulation)
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // Initialize the list
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments (abstraction)
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Getter for title
    public string GetTitle()
    {
        return _title;
    }

    // Getter for author
    public string GetAuthor()
    {
        return _author;
    }

    // Getter for length
    public int GetLength()
    {
        return _length;
    }

    // Getter for comments list
    public List<Comment> GetComments()
    {
        return _comments;
    }
}