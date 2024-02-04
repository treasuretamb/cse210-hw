public class MathAssignment : Assignment
{
    private string assignmentDetails;

    public MathAssignment(string studentName, string topic, string assignmentDetails) : base(studentName, topic)
    {
        this.assignmentDetails = assignmentDetails;
    }

    public string GetAssignmentDetails()
    {
        return assignmentDetails;
    }
}