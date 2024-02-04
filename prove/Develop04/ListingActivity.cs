public class ListingActivity : Activity
{
    private readonly List<string> prompts = new List<string>()
    {
        "Who are some of your personal real-life heroes?",
        "What are some of your personal strengths?",
        "Are you spiritually self-reliant?",
        "Who are people that you appreciate?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Let's begin the listing activity!");

        int itemCounter = 0;

        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Pause(3); // Pause for 3 seconds

            Console.WriteLine("Start listing items. Press Enter after each item. Press Q to finish.");

            string input;
            while ((input = Console.ReadLine()) != "Q")
            {
                itemCounter++;
            }

            Console.WriteLine($"Number of items listed: {itemCounter}");
            itemCounter = 0;
        }
    }
}