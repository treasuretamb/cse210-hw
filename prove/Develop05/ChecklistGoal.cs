class ChecklistGoal : Goal
{
    private int _points;
    public int Completions { get; set; }
    public int DesiredCompletions { get; }
    public int BonusPoints { get; }

    public ChecklistGoal(string name, int points, int desiredCompletions, int bonusPoints) : base(name)
    {
        _points = points;
        DesiredCompletions = desiredCompletions;
        BonusPoints = bonusPoints;
        Type = GoalType.Checklist;
    }

    public override void RecordEvent()
    {
        Completions++;
        if (Completions >= DesiredCompletions)
        {
            IsCompleted = true;
            Console.WriteLine("Congratulations! Checklist goal completed!");
        }
        else
        {
            Console.WriteLine("Event recorded for a checklist goal!");
        }
    }

    public override int GetPoints()
    {
        if (Completions >= DesiredCompletions)
        {
            return _points + BonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()},{Completions},{DesiredCompletions},{BonusPoints}";
    }
}