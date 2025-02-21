class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        _amountCompleted++;
        score += _points;
        if (_amountCompleted == _target)
        {
            score += _bonus;
        }
        Console.WriteLine("Excellent! You have done well!");
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetStringRepresentation() => $"[ {(IsComplete() ? "X" : " ")} ] {_shortName} - {_description} (Completed {_amountCompleted}/{_target} times)";
}