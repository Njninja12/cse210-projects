class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        _value = value;
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _value += 1; // For simplicity, each event increments by 1
            _isCompleted = true;
        }
    }

    public override string GetGoalStatus()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }
}
