public abstract class Plant
{
    protected string _name;
    protected string _description;
    protected string _initial;

    public Plant(string name, string description)
    {
        _name = name;
        _description = description;
        _initial = name[0].ToString();
    }

    public abstract string DisplayPlant();
    public string GetInitial ()
    {
        return _initial;
    }

    public string GetName ()
    {
        return _name;
    }

    public abstract string PlantString();
}