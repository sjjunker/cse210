public class Annual : Plant
{
    private string _plantingSeason;
    private int _daysToHarvest;

    public Annual(string name, string description, string plantingSeason, int daysToHarvest) : base(name, description)
    {
        _plantingSeason = plantingSeason;
        _daysToHarvest = daysToHarvest;
    }

    public override string DisplayPlant()
    {
        return $"Name: {_name}\nPlanting Season: {_plantingSeason}\tDays to Harvest: {_daysToHarvest}\nDescription:\n{_description}";
    }

    public override string PlantString()
    {
        return $"annual|{_name}|{_description}|{_initial}|{_plantingSeason}|{_daysToHarvest}";
    }
}