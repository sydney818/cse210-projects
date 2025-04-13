

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        return (_isComplete ? "[X]" : "[ ]") + $" {_name} ({_description})";
    }

    public override string SaveString()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}