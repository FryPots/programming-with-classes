using System;
public class MathAssignment : Assignment
{
    private string _bookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _bookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_bookSection} Problems {_problems}";
    }
}