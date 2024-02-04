public abstract class Activity
{
    public string Name { get; }
    public string Description { get; }
    public int Duration { get; protected set; }

    protected Activity(string name, string description)
    {
        Name = name;
        Description = description;
        Duration = 0;
    }

    public virtual void Start()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Please set the duration in seconds for this activity:");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Pause(3); // Pause for 3 seconds
    }

    protected virtual void PrepareToBegin()
    {
        // Add any additional preparation logic specific to each activity
    }

    protected abstract void PerformActivity();

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Pause(3); // Pause for 3 seconds before finishing
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            System.Threading.Thread.Sleep(1000); // Pause for 1 second
        }
        Console.WriteLine();
    }
}