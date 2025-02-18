public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"[ {(_amountCompleted >= _target ? "X" : " ")} ] {_shortName} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetDetailsString()
    {
        return $"{base.ToString()} - Bonus: {_bonus} points";
    }
}
