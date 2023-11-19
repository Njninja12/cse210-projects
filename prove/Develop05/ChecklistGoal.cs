class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name)
    {
        this.targetCount = targetCount;
        _value = value;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            currentCount++;
            _value += 1; // For simplicity, each event increments by 1
            CheckCompletion();
        }
    }

    private void CheckCompletion()
    {
        if (currentCount == targetCount)
        {
            _isCompleted = true;
            _value += CalculateCompletionBonus();
        }
    }

    private int CalculateCompletionBonus()
    {
        return 500; // Bonus value for checklist completion
    }

    public override string GetGoalStatus()
    {
        return _isCompleted ? $"Completed {currentCount}/{targetCount} times" : $"Not Completed {currentCount}/{targetCount} times";
    }
}