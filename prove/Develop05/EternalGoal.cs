class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name)
    {
        _value = value;
    }

    public override void RecordEvent()
    {
        _value += 1; // For simplicity, each event increments by 1
    }

    public override string GetGoalStatus()
    {
        return "[ ]"; // Eternal goals are never completed
    }
}