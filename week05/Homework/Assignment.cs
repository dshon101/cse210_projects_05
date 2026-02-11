using System;

// Base class for all assignment types
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Initialize assignment with student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Returns formatted summary of assignment
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    // Returns the student's name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Returns the assignment topic
    public string GetTopic()
    {
        return _topic;
    }
}