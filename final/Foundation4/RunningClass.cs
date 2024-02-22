public class Running : Activity
{
    public double RunningDistance { get; set; }

    public override double GetDistance()
    {
        return RunningDistance;
    }

    public override double GetSpeed()
    {
        return RunningDistance / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / RunningDistance;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{Date:dd MMM yyyy} Running ({Minutes} min) - ";
        summary += $"Distance: {distance:F1} miles, ";
        summary += $"Speed: {speed:F1} mph, ";
        summary += $"Pace: {pace:F1} min per mile";

        return summary;
    }
}