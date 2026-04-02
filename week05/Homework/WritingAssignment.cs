using System;

public class WritingAssignment : Assignment
{
    private string _assignmentTitle;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _assignmentTitle = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_assignmentTitle} by {studentName}";
    }
}