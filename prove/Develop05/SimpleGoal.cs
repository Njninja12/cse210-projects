class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            Value += 1; // For simplicity, each event increments by 1
            IsCompleted = true;
        }
    }

    public override string GetGoalStatus()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
