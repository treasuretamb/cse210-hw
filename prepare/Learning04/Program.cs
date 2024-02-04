using System;

class Program
{
    static void Main(string[] args)
    {
        string assignmentDetails = "Section 2.3 problems 3-15";

        MathAssignment mathAssignment = new MathAssignment("Raymond Reddington", "Addition and Subtraction", assignmentDetails);

        string summary = mathAssignment.GetSummary();
        Console.WriteLine(summary);

        string assignmentDetailsString = mathAssignment.GetAssignmentDetails();
        Console.WriteLine(assignmentDetailsString);

        Console.WriteLine();

        string writingInformation = "Write a persuasive essay on climate change.";

        WritingAssignment writingAssignment = new WritingAssignment("Raymond Reddington", "Global Warming", writingInformation);

        string writingSummary = writingAssignment.GetSummary();
        Console.WriteLine(writingSummary);

        string writingInfo = writingAssignment.getWritingInformation();
        Console.WriteLine(writingInfo);
    }
}
