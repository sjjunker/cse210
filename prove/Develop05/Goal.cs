public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    //constructor
    public Goal(string name, string descritpion, int points)
    {
        _shortName = name;
        _description = descritpion;
        _points = points;
    }

    //Methods
    public string GetName()
    {
        return _shortName;
    }
    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description}";
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
}