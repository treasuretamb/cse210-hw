public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Please enter the duration in seconds for this breathing activity:");
        Duration = int.Parse(Console.ReadLine());
    }

    
    protected override void PerformActivity()
    {
        Console.WriteLine("Let's begin the breathing activity!");

        Console.WriteLine();

        int breathDuration = Duration / 3;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Breathe in... ({breathDuration} seconds)");
            Pause(breathDuration);

            Console.WriteLine("Hold your breath...");
            Pause(breathDuration);

            Console.WriteLine($"Breathe out... ({breathDuration} seconds)");
            Pause(breathDuration);
        }
    }
}
    
