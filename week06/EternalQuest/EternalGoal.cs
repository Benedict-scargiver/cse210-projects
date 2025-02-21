class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent(ref int score)
    {
        score += _points;
        Console.WriteLine("Excellent! You have done well!");
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation() => $"[ ∞ ] {_shortName} - {_description}";
}