using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _isComplete = true;
                return Points; // Return bonus points only when the goal is completed
            }
            return Points; // Return points for each event recorded
        }
        return 0; // No points if already complete
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public string GetProgress()
    {
        return $"({_currentCount}/{_targetCount})";
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_currentCount}|{_bonus}|{_isComplete}";
    }
}