class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string name, int points) : base(name)
    {
        _points = points;
        Type = GoalType.Simple;
    }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }

    public override int GetPoints()
    {
        return _points;
    }
}