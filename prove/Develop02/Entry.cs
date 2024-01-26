public class Entry
{
    public string Date { get; set; }
    public string Question { get; set; }
    public string UserEntry { get; set; }

    public Entry(string date, string question, string userEntry)
    {
        Date = date;
        Question = question;
        UserEntry = userEntry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {Question}");
        Console.WriteLine(UserEntry);
    }
}