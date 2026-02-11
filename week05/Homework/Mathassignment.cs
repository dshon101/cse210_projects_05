using System;

// Math assignment with textbook section and problem numbers
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Initialize math assignment with all required fields
    public MathAssignment(string studentName, string topic,
                         string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Returns formatted homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}