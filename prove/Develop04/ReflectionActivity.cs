public class ReflectionActivity : Activity
{
    private readonly List<string> prompts = new List<string>()
    {
        "Think of a time when you put youself first.",
        "Think of a time when you accomplished a difficult task.",
        "Think of a time when you helped someone.",
        "Think of a time when you did something selfless."
    };

    private readonly List<string> questions = new List<string>()
    {
        "What made this experience meaningful to you?",
        "Have you engaged in a similar activity in the past?",
        "How did you initiate this project?",
        "What emotions did you experience upon its completion?",
        "In what ways did this instance differ from less successful endeavors?",
        "What aspect of this experience do you appreciate the most?",
        "How can the lessons from this experience be applied to other situations?",
        "What self-discoveries did this experience reveal about you?",
        "How can you retain the insights gained from this experience for future reference?"





    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }



    protected override void PerformActivity()
    {
        Console.WriteLine("Let's begin the reflection activity!");

        int questionIndex = 0;
        int secondsPerQuestion = Duration / questions.Count;

        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Pause(10); // Pause for 10 seconds

            for (int i = 0; i < questions.Count; i++)
            {
                string question = questions[questionIndex];
                Console.WriteLine(question);
                Pause(secondsPerQuestion);

                if (i < questions.Count - 1)
                {
                    Console.WriteLine("Press any key to continue to the next question...");
                    Console.ReadKey();
                    Console.WriteLine();
                }

                questionIndex = (questionIndex + 1) % questions.Count;
            }
        }
    }
}