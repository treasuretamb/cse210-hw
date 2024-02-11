class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(string name, int points) : base(name)
    {
        _points = points;
        Type = GoalType.Eternal;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for an eternal goal!");
    }

    public override int GetPoints()
    {
        return _points;
    }
}