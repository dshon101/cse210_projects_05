using System;

// Comment class - Represents a comment on a video
public class Comment
{
    // Private member variables (encapsulation)
    private string _name;
    private string _text;

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Getter for commenter name
    public string GetName()
    {
        return _name;
    }

    // Getter for comment text
    public string GetText()
    {
        return _text;
    }
}