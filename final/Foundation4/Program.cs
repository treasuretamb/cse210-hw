using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running
        {
            Date = new DateTime(2024, 2, 3),
            Minutes = 30,
            RunningDistance = 3.0
        };
        activities.Add(running);

        Cycling cycling = new Cycling
        {
            Date = new DateTime(2024, 2, 3),
            Minutes = 30,
            Speed = 12.0
        };
        activities.Add(cycling);

        Swimming swimming = new Swimming
        {
            Date = new DateTime(2024, 2, 3),
            Minutes = 30,
            Laps = 20
        };
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}