using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        string studentName = "Jaxson Lucas";
        string topic = "Science";
        string textbookSection = "7.3";
        string problems = "8-19";
        string title = "The Causes of World War II by Mary Waters";

        Assignment assignmentOne = new Assignment(studentName, topic);

        MathAssignment mathAssignmentOne = new MathAssignment(studentName, topic, textbookSection, problems);

        WritingAssignment assignment = new WritingAssignment(studentName, topic, title);

        // Console.WriteLine(mathAssignmentOne.GetSummary(studentName, topic));
        // Console.WriteLine(mathAssignmentOne.GetHomeWorkList(textbookSection, problems));



        // Console.WriteLine(assignmentOne.GetSummary(studentName, topic));

        Console.WriteLine(assignment.GetSummary(studentName, topic));
        Console.WriteLine(assignment.GetWritingInformation(title));


    }
}