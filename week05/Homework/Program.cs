using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignmentA = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignmentA.GetSummary());

        MathAssignment assignmentB = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignmentB.GetSummary());
        Console.WriteLine(assignmentB.GetHomeworkList());

        WritingAssignment assignmentC = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignmentC.GetSummary());
        Console.WriteLine(assignmentC.GetWritingInformation());
    }
}