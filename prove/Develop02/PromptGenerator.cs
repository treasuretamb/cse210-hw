public class Prompt
{
    private List<string> questions;

    public Prompt()
    {
        questions = new List<string>
        {
            "What worries me most about the future?",
            "What am I really scared of?",
            "What matters most in my life?",
            "Have I made someone smile today?",
            "When did I last push the boundaries of my comfort zone?",
        };
    }

    public string GetPrompt()
    {
        string randomQuestion = "";
        int randomIndex = new Random().Next(questions.Count);

        randomQuestion = questions[randomIndex];

        return randomQuestion;
    }

    public void Display()
    {
        // Display any additional information related to prompts
    }
}