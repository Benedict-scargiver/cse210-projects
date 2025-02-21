class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
            Console.WriteLine("Excellent! You have done well!");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation() => $"[ {(IsComplete() ? "X" : " ")} ] {_shortName} - {_description}";
}