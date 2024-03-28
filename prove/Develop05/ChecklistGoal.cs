public class CheckListGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor
    public CheckListGoal(string name, string description, int points, int target, int bonus): base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //methods
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return _bonus;
        } else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        } else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {_shortName}: {_description} ({_amountCompleted}/{_target})";
        } else
        {
            return $"[ ] {_shortName}: {_description} ({_amountCompleted}/{_target})";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}