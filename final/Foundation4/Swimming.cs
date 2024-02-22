public class Swimming : Activity
{
    public int Laps { get; set; }
    
     // meters
    private const double LapDistance = 50;

    public override double GetDistance()
    {
        return Laps * LapDistance / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{Date:dd MMM yyyy} Swimming ({Minutes} min) - ";
        summary += $"Distance: {distance:F1} km, ";
        summary += $"Speed: {speed:F1} kph, ";
        summary += $"Pace: {pace:F1} min per km";

        return summary;
    }
}