abstract class Goal
{
    public string Name { get; set; }
    public GoalType Type { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string name)
    {
        Name = name;
    }

    public abstract void RecordEvent();

    public abstract int GetPoints();

    public override string ToString()
    {
        return $"{Name},{Type},{GetPoints()},{IsCompleted}";
    }
}