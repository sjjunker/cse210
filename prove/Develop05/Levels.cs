public class Levels{
    private string _name;
    private int _pointsRequired;

    public Levels(string name, int points)
    {
        _name = name;
        _pointsRequired = points;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetPointsRequired()
    {
        return _pointsRequired;
    }
}