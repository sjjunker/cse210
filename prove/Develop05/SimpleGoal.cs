public class SimpleGoal: Goal
{
    private bool _isComplete;

    //Constructor
    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _isComplete = false;
    }

    //Methods
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        } else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {_shortName}: {_description}";
        } else
        {
            return $"[ ] {_shortName}: {_description}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}