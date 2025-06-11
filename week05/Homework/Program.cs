using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodrigues", "Fractions", "7.3", "8-19");
        string mathSummary = mathAssignment.GetSummary();
        string homework = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathSummary);
        Console.WriteLine(homework);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string writingSummary = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);
    }
}