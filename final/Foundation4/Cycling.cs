
public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetDistance()
    {
        return Speed * Minutes / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{Date:dd MMM yyyy} Cycling ({Minutes} min) - ";
        summary += $"Distance: {distance:F1} miles, ";
        summary += $"Speed: {speed:F1} mph, ";
        summary += $"Pace: {pace:F1} min per mile";

        return summary;
    }
}