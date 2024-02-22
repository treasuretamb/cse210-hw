public abstract class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}