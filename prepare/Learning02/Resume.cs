public class Resume
{
    private string _Name;
    private List<Job> _jobs;

    // Constructor for Resume class
    public Resume(string Name)
    {
        _Name = Name;
        _jobs = new List<Job>();
    }

    // AddJob method to add a Job to the list of jobs in the Resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display method for Resume class
    public void Display()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine(" ");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }

         Console.WriteLine(" ");
    }
}