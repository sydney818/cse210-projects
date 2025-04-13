

using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted == _targetCount)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetStatus()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_name} ({_description}) -- Completed {_timesCompleted}/{_targetCount} times";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_timesCompleted},{_targetCount},{_bonus}";
    }
}
