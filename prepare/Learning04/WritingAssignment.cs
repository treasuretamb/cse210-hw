public class WritingAssignment : Assignment
{
    private string writingInformation;

    public WritingAssignment(string studentName, string topic, string writingInformation) : base(studentName, topic)
    {
        this.writingInformation = writingInformation;
    }

    public string getWritingInformation()
    {
      //Assess the studentName using the getStudentName() method in the base class
        string studentName = GetStudentName(); 
        return $"Writing Information for {studentName}: \n{writingInformation}";
    }
}