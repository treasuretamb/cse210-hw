public class Job
{
    // Private member variables for Job class
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor for Job class
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Display method for Job class
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}