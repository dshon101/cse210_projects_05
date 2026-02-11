using System;

// Writing assignment with title
public class WritingAssignment : Assignment
{
    private string _title;

    // Initialize writing assignment with all required fields
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Returns formatted writing information with title and author
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}