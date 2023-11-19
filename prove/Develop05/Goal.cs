abstract class Goal
{
    public string Name { get; set; }
    public int Value { get; protected set; }
    public bool IsCompleted { get; protected set; }

    protected Goal(string name)
    {
        Name = name;
        Value = 0;
        IsCompleted = false;
    }

    public abstract void RecordEvent();

    public abstract string GetGoalStatus();
}