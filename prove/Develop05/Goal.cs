abstract class Goal
{
    public string _name;
    public int _value;
    public bool _isCompleted; // Change to protected set

    protected Goal(string name)
    {
        _name = name;
        _value = 0;
        _isCompleted = false;
    }

    public abstract void RecordEvent();

    public abstract string GetGoalStatus();
}